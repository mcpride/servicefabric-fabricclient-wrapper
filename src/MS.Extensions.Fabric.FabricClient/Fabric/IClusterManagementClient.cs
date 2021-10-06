// MIT License
// Copyright (c) 2021 Marco Stolze

namespace MS.Extensions.Fabric
{
    public interface IClusterManagementClient
    {
        //Task DeactivateNodeAsync(string nodeName, NodeDeactivationIntent deactivationIntent);
        //Task DeactivateNodeAsync(string nodeName, NodeDeactivationIntent deactivationIntent, TimeSpan timeout, CancellationToken cancellationToken);
        //Task ActivateNodeAsync(string nodeName);
        //Task ActivateNodeAsync(string nodeName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task RemoveNodeStateAsync(string nodeName);
        //Task RemoveNodeStateAsync(string nodeName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task RecoverPartitionsAsync();
        //Task RecoverPartitionsAsync(TimeSpan timeout, CancellationToken cancellationToken);
        //Task RecoverPartitionAsync(Guid partitionId);
        //Task RecoverPartitionAsync(Guid partitionId, TimeSpan timeout, CancellationToken cancellationToken);
        //Task RecoverServicePartitionsAsync(Uri serviceName);
        //Task RecoverServicePartitionsAsync(Uri serviceName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task RecoverSystemPartitionsAsync();
        //Task RecoverSystemPartitionsAsync(TimeSpan timeout, CancellationToken cancellationToken);
        //Task ResetPartitionLoadAsync(Guid partitionId);
        //Task ResetPartitionLoadAsync(Guid partitionId, TimeSpan timeout, CancellationToken cancellationToken);
        //Task ToggleVerboseServicePlacementHealthReportingAsync(bool enabled);
        //Task ToggleVerboseServicePlacementHealthReportingAsync(bool enabled, TimeSpan timeout, CancellationToken cancellationToken);
        //Task ProvisionFabricAsync(string patchFilePath, string clusterManifestFilePath);
        //Task ProvisionFabricAsync(string patchFilePath, string clusterManifestFilePath, TimeSpan timeout, CancellationToken cancellationToken);
        //Task UnprovisionFabricAsync(string codeVersion, string configVersion);
        //Task UnprovisionFabricAsync(string codeVersion, string configVersion, TimeSpan timeout, CancellationToken cancellationToken);
        //Task UpgradeFabricAsync(FabricUpgradeDescription upgradeDescription);
        //Task UpgradeFabricAsync(FabricUpgradeDescription upgradeDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task UpdateFabricUpgradeAsync(FabricUpgradeUpdateDescription updateDescription);
        //Task UpdateFabricUpgradeAsync(FabricUpgradeUpdateDescription updateDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task RollbackFabricUpgradeAsync();
        //Task RollbackFabricUpgradeAsync(TimeSpan timeout, CancellationToken cancellationToken);
        //Task<FabricUpgradeProgress> GetFabricUpgradeProgressAsync();
        //Task<FabricUpgradeProgress> GetFabricUpgradeProgressAsync(TimeSpan timeout, CancellationToken cancellationToken);
        //Task MoveNextFabricUpgradeDomainAsync(FabricUpgradeProgress upgradeProgress);
        //Task MoveNextFabricUpgradeDomainAsync(FabricUpgradeProgress upgradeProgress, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<string> GetClusterManifestAsync();
        //Task<string> GetClusterManifestAsync(TimeSpan timeout, CancellationToken cancellationToken);
        //Task<string> GetClusterManifestAsync(ClusterManifestQueryDescription queryDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //void CopyClusterPackage(string imageStoreConnectionString, string clusterManifestPath, string clusterManifestPathInImageStore, string codePackagePath, string codePackagePathInImageStore);
        //void CopyClusterPackage(string imageStoreConnectionString, string clusterManifestPath, string clusterManifestPathInImageStore, string codePackagePath, string codePackagePathInImageStore, TimeSpan timeout);
        //void RemoveClusterPackage(string imageStoreConnectionString, string clusterManifestPathInImageStore, string codePackagePathInImageStore);
        //Task UpgradeConfigurationAsync(ConfigurationUpgradeDescription description);
        //Task UpgradeConfigurationAsync(ConfigurationUpgradeDescription description, TimeSpan timeout);
        //Task UpgradeConfigurationAsync(ConfigurationUpgradeDescription description, CancellationToken cancellationToken);
        //Task UpgradeConfigurationAsync(ConfigurationUpgradeDescription description, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<FabricOrchestrationUpgradeProgress> GetClusterConfigurationUpgradeStatusAsync();
        //Task<FabricOrchestrationUpgradeProgress> GetClusterConfigurationUpgradeStatusAsync(TimeSpan timeout);
        //Task<FabricOrchestrationUpgradeProgress> GetClusterConfigurationUpgradeStatusAsync(CancellationToken cancellationToken);
        //Task<FabricOrchestrationUpgradeProgress> GetClusterConfigurationUpgradeStatusAsync(TimeSpan timeout, CancellationToken cancellationToken);
        //Task<string> GetClusterConfigurationAsync();
        //Task<string> GetClusterConfigurationAsync(string apiVersion);
        //Task<string> GetClusterConfigurationAsync(TimeSpan timeout, CancellationToken cancellationToken);
        //Task<string> GetClusterConfigurationAsync(string apiVersion, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<string> GetUpgradeOrchestrationServiceStateAsync();
        //Task<string> GetUpgradeOrchestrationServiceStateAsync(TimeSpan timeout, CancellationToken cancellationToken);
        //Task<FabricUpgradeOrchestrationServiceState> SetUpgradeOrchestrationServiceStateAsync(string state);
        //Task<FabricUpgradeOrchestrationServiceState> SetUpgradeOrchestrationServiceStateAsync(string state, TimeSpan timeout, CancellationToken cancellationToken);
        //Task AddConfigurationParameterOverridesAsync(string nodeName, IList<ConfigParameterOverride> configurationOverrideList, bool force);
        //Task AddConfigurationParameterOverridesAsync(string nodeName, IList<ConfigParameterOverride> configurationOverrideList, bool force, TimeSpan timeout, CancellationToken cancellationToken);
        //Task RemoveConfigurationOverridesAsync(string nodeName);
        //Task RemoveConfigurationOverridesAsync(string nodeName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ConfigParameterOverrideList> GetConfigurationOverridesAsync(string nodeName);
        //Task<ConfigParameterOverrideList> GetConfigurationOverridesAsync(string nodeName, TimeSpan timeout, CancellationToken cancellationToken);
    }
}