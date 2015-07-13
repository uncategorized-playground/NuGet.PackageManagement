﻿using System;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NuGet.Common;
using NuGet.Configuration;
using NuGet.PackageManagement;
using NuGet.Packaging.Core;
using NuGet.ProjectManagement;
using NuGet.Protocol.Core.Types;
using NuGet.Resolver;
using NuGet.Versioning;

namespace NuGet.CommandLine
{
    [Command(typeof(NuGetCommand), "install", "InstallCommandDescription",
        MinArgs = 0, MaxArgs = 1, UsageSummaryResourceName = "InstallCommandUsageSummary",
        UsageDescriptionResourceName = "InstallCommandUsageDescription",
        UsageExampleResourceName = "InstallCommandUsageExamples")]
    public class InstallCommand : DownloadCommandBase
    {
        private static readonly object _satelliteLock = new object();

        [Option(typeof(NuGetCommand), "InstallCommandOutputDirDescription")]
        public string OutputDirectory { get; set; }

        [Option(typeof(NuGetCommand), "InstallCommandVersionDescription")]
        public string Version { get; set; }

        [Option(typeof(NuGetCommand), "InstallCommandExcludeVersionDescription", AltName = "x")]
        public bool ExcludeVersion { get; set; }

        [Option(typeof(NuGetCommand), "InstallCommandPrerelease")]
        public bool Prerelease { get; set; }

        [Option(typeof(NuGetCommand), "InstallCommandRequireConsent")]
        public bool RequireConsent { get; set; }

        [Option(typeof(NuGetCommand), "InstallCommandSolutionDirectory")]
        public string SolutionDirectory { get; set; }

        private Configuration.ISettings EffectiveSettings { get; set; }

        private bool AllowMultipleVersions
        {
            get { return !ExcludeVersion; }
        }

        [ImportingConstructor]
        public InstallCommand()
            : this(MachineCache.Default)
        {
        }

        protected internal InstallCommand(IPackageRepository cacheRepository) :
            base(cacheRepository)
        {
            // On mono, parallel builds are broken for some reason. See https://gist.github.com/4201936 for the errors
            // That are thrown.
            DisableParallelProcessing = EnvironmentUtility.IsMonoRuntime;
        }

        public override Task ExecuteCommandAsync()
        {
            CalculateEffectivePackageSaveMode();
            string installPath = ResolveInstallPath();

            string configFilePath = Path.GetFullPath(Arguments.Count == 0 ? Constants.PackageReferenceFile : Arguments[0]);
            string configFileName = Path.GetFileName(configFilePath);

            // If the first argument is a packages.xxx.config file, install everything it lists
            // Otherwise, treat the first argument as a package Id
            if (PackageReferenceFile.IsValidConfigFileName(configFileName))
            {
                Prerelease = true;
                return PerformV2Restore(configFilePath, installPath);
            }
            else
            {
                var packageId = Arguments[0];
                var version = Version != null ? new NuGetVersion(Version) : null;
                return InstallPackage(packageId, version, installPath);
            }
        }

        internal string ResolveInstallPath()
        {
            if (!String.IsNullOrEmpty(OutputDirectory))
            {
                // Use the OutputDirectory if specified.
                return OutputDirectory;
            }

            EffectiveSettings = Settings;
            // If the SolutionDir is specified, use the .nuget directory under it to determine the solution-level settings
            if (!String.IsNullOrEmpty(SolutionDirectory))
            {
                var solutionSettingsFile = Path.Combine(SolutionDirectory.TrimEnd(Path.DirectorySeparatorChar), NuGetConstants.NuGetSolutionSettingsFolder);

                EffectiveSettings = Configuration.Settings.LoadDefaultSettings(
                    solutionSettingsFile,
                    configFileName: null,
                    machineWideSettings: MachineWideSettings);

                // Recreate the source provider and credential provider
                SourceProvider = PackageSourceBuilder.CreateSourceProvider(EffectiveSettings);
                // TODO: Revive this
                // HttpClient.DefaultCredentialProvider = new SettingsCredentialProvider(new ConsoleCredentialProvider(Console), SourceProvider, Console);
            }

            string installPath = SettingsUtility.GetRepositoryPath(EffectiveSettings);
            if (!String.IsNullOrEmpty(installPath))
            {
                // If a value is specified in config, use that. 
                return installPath;
            }

            if (!String.IsNullOrEmpty(SolutionDirectory))
            {
                // For package restore scenarios, deduce the path of the packages directory from the solution directory.
                return Path.Combine(SolutionDirectory, CommandLineConstants.PackagesDirectoryName);
            }

            // Use the current directory as output.
            return CurrentDirectory;
        }

        private Task PerformV2Restore(string packagesConfigFilePath, string installPath)
        {
            Debug.Assert(EffectiveSettings != null);

            var sourceRepositoryProvider = GetSourceRepositoryProvider();
            var nuGetPackageManager = new NuGetPackageManager(sourceRepositoryProvider, EffectiveSettings, installPath);
            var installedPackageReferences = GetInstalledPackageReferences(packagesConfigFilePath);
            var packageRestoreData = installedPackageReferences.Select(reference =>
                new PackageRestoreData(
                    reference,
                    new[] { packagesConfigFilePath },
                    isMissing: true));
            var packageRestoreContext = new PackageRestoreContext(
                nuGetPackageManager, 
                packageRestoreData, 
                CancellationToken.None,
                packageRestoredEvent: null,
                packageRestoreFailedEvent: null,
                sourceRepositories: GetPackageSources(EffectiveSettings).Select(sourceRepositoryProvider.CreateRepository),
                maxNumberOfParallelTasks: DisableParallelProcessing ? 1 : PackageManagementConstants.DefaultMaxDegreeOfParallelism);
            return PackageRestoreManager.RestoreMissingPackagesAsync(packageRestoreContext, new ConsoleProjectContext(Logger));
        }

        private SourceRepositoryProvider GetSourceRepositoryProvider()
        {
            var packageSourceProvider = new Configuration.PackageSourceProvider(EffectiveSettings);
            var sourceRepositoryProvider = new SourceRepositoryProvider(packageSourceProvider,
                Enumerable.Concat(
                    Protocol.Core.v2.FactoryExtensionsV2.GetCoreV2(Repository.Provider),
                    Protocol.Core.v3.FactoryExtensionsV2.GetCoreV3(Repository.Provider)));
            return sourceRepositoryProvider;
        }

        private Task InstallPackage(
            string packageId,
            NuGetVersion version,
            string installPath)
        {
            if (version == null)
            {
                NoCache = true;
            }

            var folderProject = new FolderNuGetProject(
                installPath, 
                new Packaging.PackagePathResolver(installPath, !ExcludeVersion));

            var sourceRepositoryProvider = GetSourceRepositoryProvider();
            var packageManager = new NuGetPackageManager(sourceRepositoryProvider, EffectiveSettings, installPath);

            var primaryRepositories = GetPackageSources(EffectiveSettings).Select(sourceRepositoryProvider.CreateRepository);

            return packageManager.InstallPackageAsync(
                folderProject,
                new PackageIdentity(packageId, version),
                new ResolutionContext(
                    DependencyBehavior.Lowest,
                    includePrelease: Prerelease,
                    includeUnlisted: true,
                    versionConstraints: VersionConstraints.None),
                new ConsoleProjectContext(Logger),
                primaryRepositories,
                Enumerable.Empty<SourceRepository>(),
                CancellationToken.None);
        }
    }
}