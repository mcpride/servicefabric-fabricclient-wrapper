// MIT License
// Copyright (c) 2021 Marco Stolze

namespace MS.Extensions.Fabric
{
    public interface IApplicationManagementClient
    {
        //Task CreateApplicationAsync(ApplicationDescription applicationDescription);
        //Task CreateApplicationAsync(ApplicationDescription applicationDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task UpdateApplicationAsync(ApplicationUpdateDescription applicationUpdateDescription);
        //Task UpdateApplicationAsync(ApplicationUpdateDescription applicationUpdateDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //[Obsolete("This api is deprecated, use overload taking DeleteApplicationDescription instead.", false)]
        //Task DeleteApplicationAsync(Uri applicationName);
        //[Obsolete("This api is deprecated, use overload taking DeleteApplicationDescription instead.", false)]
        //Task DeleteApplicationAsync(Uri applicationName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task DeleteApplicationAsync(DeleteApplicationDescription deleteApplicationDescription);
        //Task DeleteApplicationAsync(DeleteApplicationDescription deleteApplicationDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task ProvisionApplicationAsync(string applicationPackagePathInImageStore);
        //Task ProvisionApplicationAsync(string applicationPackagePathInImageStore, TimeSpan timeout, CancellationToken cancellationToken);
        //Task ProvisionApplicationAsync(ProvisionApplicationTypeDescriptionBase description);
        //Task ProvisionApplicationAsync(ProvisionApplicationTypeDescriptionBase description, TimeSpan timeout, CancellationToken cancellationToken);
        //Task UnprovisionApplicationAsync(string applicationTypeName, string applicationTypeVersion);
        //Task UnprovisionApplicationAsync(string applicationTypeName, string applicationTypeVersion, TimeSpan timeout, CancellationToken cancellationToken);
        //Task UnprovisionApplicationAsync(UnprovisionApplicationTypeDescription description);
        //Task UnprovisionApplicationAsync(UnprovisionApplicationTypeDescription description, TimeSpan timeout, CancellationToken cancellationToken);
        //Task UpgradeApplicationAsync(ApplicationUpgradeDescription upgradeDescription);
        //Task UpgradeApplicationAsync(ApplicationUpgradeDescription upgradeDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task UpdateApplicationUpgradeAsync(ApplicationUpgradeUpdateDescription updateDescription);
        //Task UpdateApplicationUpgradeAsync(ApplicationUpgradeUpdateDescription updateDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task RollbackApplicationUpgradeAsync(Uri applicationName);
        //Task RollbackApplicationUpgradeAsync(Uri applicationName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ApplicationUpgradeProgress> GetApplicationUpgradeProgressAsync(Uri applicationName);
        //Task<ApplicationUpgradeProgress> GetApplicationUpgradeProgressAsync(Uri applicationName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task MoveNextApplicationUpgradeDomainAsync(ApplicationUpgradeProgress upgradeProgress);
        //Task MoveNextApplicationUpgradeDomainAsync(ApplicationUpgradeProgress upgradeProgress, TimeSpan timeout, CancellationToken cancellationToken);
        //Task DeployServicePackageToNode(string applicationTypeName, string applicationTypeVersion, string serviceManifestName, PackageSharingPolicyList sharingPolicies, string nodeName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<string> GetApplicationManifestAsync(string applicationTypeName, string applicationTypeVersion);
        //Task<string> GetApplicationManifestAsync(string applicationTypeName, string applicationTypeVersion, TimeSpan timeout, CancellationToken cancellationToken);
        //void CopyApplicationPackage(string imageStoreConnectionString, string applicationPackagePath, string applicationPackagePathInImageStore);
        //void CopyApplicationPackage(string imageStoreConnectionString, string applicationPackagePath, string applicationPackagePathInImageStore, TimeSpan timeout);
        //void CopyApplicationPackage(string imageStoreConnectionString, string applicationPackagePath, string applicationPackagePathInImageStore, IImageStoreProgressHandler progressHandler, TimeSpan timeout);
        //void RemoveApplicationPackage(string imageStoreConnectionString, string applicationPackagePathInImageStore);
    }
}