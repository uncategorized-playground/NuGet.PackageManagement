﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.PackageManagement {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.PackageManagement.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Another NuGetProject with the same name &apos;{0}&apos; exists in solution.
        /// </summary>
        internal static string AnotherNuGetProjectWithSameNameExistsInSolution {
            get {
                return ResourceManager.GetString("AnotherNuGetProjectWithSameNameExistsInSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempting to gather dependencies information for package &apos;{0}&apos; with respect to project targeting &apos;{1}&apos;.
        /// </summary>
        internal static string AttemptingToGatherDependencyInfo {
            get {
                return ResourceManager.GetString("AttemptingToGatherDependencyInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempting to gather dependencies information for multiple packages with respect to project targeting &apos;{0}&apos;.
        /// </summary>
        internal static string AttemptingToGatherDependencyInfoForMultiplePackages {
            get {
                return ResourceManager.GetString("AttemptingToGatherDependencyInfoForMultiplePackages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempting to resolve dependencies for package &apos;{0}&apos; with DependencyBehavior &apos;{1}&apos;.
        /// </summary>
        internal static string AttemptingToResolveDependencies {
            get {
                return ResourceManager.GetString("AttemptingToResolveDependencies", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempting to resolve dependencies for multiple packages.
        /// </summary>
        internal static string AttemptingToResolveDependenciesForMultiplePackages {
            get {
                return ResourceManager.GetString("AttemptingToResolveDependenciesForMultiplePackages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package restore completed with errors. Check the build output window for details..
        /// </summary>
        internal static string BuildIntegratedPackageRestoreFailed {
            get {
                return ResourceManager.GetString("BuildIntegratedPackageRestoreFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from.
        /// </summary>
        internal static string From {
            get {
                return ResourceManager.GetString("From", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installed package &apos;{0}&apos; to project.
        /// </summary>
        internal static string InstalledPackage {
            get {
                return ResourceManager.GetString("InstalledPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installing package &apos;{0}&apos; to project.
        /// </summary>
        internal static string InstallingPackage {
            get {
                return ResourceManager.GetString("InstallingPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; cannot be called on a NullSettings. This may be caused on account of insufficient permissions to read or write to &apos;%AppData%\NuGet\NuGet.config&apos;.
        /// </summary>
        internal static string InvalidNullSettingsOperation {
            get {
                return ResourceManager.GetString("InvalidNullSettingsOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When updating multiple packages, dependency behavior has to be DependencyBehavior.Highest.
        /// </summary>
        internal static string MultiplePackageInstallOrUpdateHasToBeAnUpdate {
            get {
                return ResourceManager.GetString("MultiplePackageInstallOrUpdateHasToBeAnUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Already referencing a newer version of &apos;{0}&apos;...
        /// </summary>
        internal static string NewerVersionAlreadyReferenced {
            get {
                return ResourceManager.GetString("NewerVersionAlreadyReferenced", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No latest version found for the &apos;{0}&apos; for the given source repositories and resolution context.
        /// </summary>
        internal static string NoLatestVersionFound {
            get {
                return ResourceManager.GetString("NoLatestVersionFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No NuGetProject is available with specified name &apos;{0}&apos;.
        /// </summary>
        internal static string NoNuGetProjectWithSpecifiedName {
            get {
                return ResourceManager.GetString("NoNuGetProjectWithSpecifiedName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGetProject does not have &apos;Name&apos; set in metadata. It should be set and it should be unique.
        /// </summary>
        internal static string NuGetProjectDoesNotHaveName {
            get {
                return ResourceManager.GetString("NuGetProjectDoesNotHaveName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more packages not found.
        /// </summary>
        internal static string OneOrMorePackagesNotFound {
            get {
                return ResourceManager.GetString("OneOrMorePackagesNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package &apos;{0}&apos; could not be installed.
        /// </summary>
        internal static string PackageCouldNotBeInstalled {
            get {
                return ResourceManager.GetString("PackageCouldNotBeInstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to uninstall &apos;{0}&apos; because &apos;{1}&apos; depends on it..
        /// </summary>
        internal static string PackageHasDependent {
            get {
                return ResourceManager.GetString("PackageHasDependent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to uninstall &apos;{0}&apos; because &apos;{1}&apos; depend on it..
        /// </summary>
        internal static string PackageHasDependents {
            get {
                return ResourceManager.GetString("PackageHasDependents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; package requires NuGet client version &apos;{1}&apos; or above, but the current NuGet version is &apos;{2}&apos;..
        /// </summary>
        internal static string PackageMinVersionNotSatisfied {
            get {
                return ResourceManager.GetString("PackageMinVersionNotSatisfied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package &apos;{0}&apos; is not found.
        /// </summary>
        internal static string PackageNotFound {
            get {
                return ResourceManager.GetString("PackageNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Packages could not be installed.
        /// </summary>
        internal static string PackagesCouldNotBeInstalled {
            get {
                return ResourceManager.GetString("PackagesCouldNotBeInstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package &apos;{0}&apos; to be uninstalled could not be found in project &apos;{1}&apos;.
        /// </summary>
        internal static string PackageToBeUninstalledCouldNotBeFound {
            get {
                return ResourceManager.GetString("PackageToBeUninstalledCouldNotBeFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter cannot be zero or negative.
        /// </summary>
        internal static string ParameterCannotBeZeroOrNegative {
            get {
                return ResourceManager.GetString("ParameterCannotBeZeroOrNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resolved actions to install package &apos;{0}&apos;.
        /// </summary>
        internal static string ResolvedActionsToInstallPackage {
            get {
                return ResourceManager.GetString("ResolvedActionsToInstallPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resolved actions to uninstall package &apos;{0}&apos;.
        /// </summary>
        internal static string ResolvedActionsToUninstallPackage {
            get {
                return ResourceManager.GetString("ResolvedActionsToUninstallPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resolving actions install multiple packages.
        /// </summary>
        internal static string ResolvingActionsToInstallOrUpdateMultiplePackages {
            get {
                return ResourceManager.GetString("ResolvingActionsToInstallOrUpdateMultiplePackages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resolving actions to install package &apos;{0}&apos;.
        /// </summary>
        internal static string ResolvingActionsToInstallPackage {
            get {
                return ResourceManager.GetString("ResolvingActionsToInstallPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resolving actions to uninstall package &apos;{0}&apos;.
        /// </summary>
        internal static string ResolvingActionsToUninstallPackage {
            get {
                return ResourceManager.GetString("ResolvingActionsToUninstallPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restoring NuGet package {0}..
        /// </summary>
        internal static string RestoringPackage {
            get {
                return ResourceManager.GetString("RestoringPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Solution is not opened or not saved. Please ensure you have an open and saved solution..
        /// </summary>
        internal static string SolutionDirectoryNotAvailable {
            get {
                return ResourceManager.GetString("SolutionDirectoryNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uninstall is not supported when SolutionManager is not available.
        /// </summary>
        internal static string SolutionManagerNotAvailableForUninstall {
            get {
                return ResourceManager.GetString("SolutionManagerNotAvailableForUninstall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully {0}ed &apos;{1}&apos; {2}..
        /// </summary>
        internal static string SuccessfullyExecutedPackageAction {
            get {
                return ResourceManager.GetString("SuccessfullyExecutedPackageAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to to.
        /// </summary>
        internal static string To {
            get {
                return ResourceManager.GetString("To", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to gather dependencies information for package &apos;{0}&apos;.
        /// </summary>
        internal static string UnableToGatherDependencyInfo {
            get {
                return ResourceManager.GetString("UnableToGatherDependencyInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to gather dependencies information for multiple packages.
        /// </summary>
        internal static string UnableToGatherDependencyInfoForMultiplePackages {
            get {
                return ResourceManager.GetString("UnableToGatherDependencyInfoForMultiplePackages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to resolve dependencies for package &apos;{0}&apos; with DependencyBehavior &apos;{1}&apos;.
        /// </summary>
        internal static string UnableToResolveDependencyInfo {
            get {
                return ResourceManager.GetString("UnableToResolveDependencyInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to resolve dependencies for multiple packages.
        /// </summary>
        internal static string UnableToResolveDependencyInfoForMultiplePackages {
            get {
                return ResourceManager.GetString("UnableToResolveDependencyInfoForMultiplePackages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find package &apos;{0}&apos;.
        /// </summary>
        internal static string UnknownPackage {
            get {
                return ResourceManager.GetString("UnknownPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find version &apos;{1}&apos; of package &apos;{0}&apos;..
        /// </summary>
        internal static string UnknownPackageSpecificVersion {
            get {
                return ResourceManager.GetString("UnknownPackageSpecificVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Install failed. Rolling back....
        /// </summary>
        internal static string Warning_RollingBack {
            get {
                return ResourceManager.GetString("Warning_RollingBack", resourceCulture);
            }
        }
    }
}
