// MIT License
// Copyright (c) 2021 Marco Stolze

using System.Fabric.Health;

namespace MS.Extensions.Fabric
{
    public interface IHealthClient
    {
        void ReportHealth(HealthReport healthReport);
        //void ReportHealth(HealthReport healthReport, HealthReportSendOptions sendOptions);
        //Task<ClusterHealth> GetClusterHealthAsync();
        //Task<ClusterHealth> GetClusterHealthAsync(ClusterHealthPolicy healthPolicy);
        //Task<ClusterHealth> GetClusterHealthAsync(TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ClusterHealth> GetClusterHealthAsync(ClusterHealthPolicy healthPolicy, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ClusterHealth> GetClusterHealthAsync(ClusterHealthQueryDescription queryDescription);
        //Task<ClusterHealth> GetClusterHealthAsync(ClusterHealthQueryDescription queryDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<NodeHealth> GetNodeHealthAsync(string nodeName);
        //Task<NodeHealth> GetNodeHealthAsync(string nodeName, ClusterHealthPolicy healthPolicy);
        //Task<NodeHealth> GetNodeHealthAsync(string nodeName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<NodeHealth> GetNodeHealthAsync(string nodeName, ClusterHealthPolicy healthPolicy, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<NodeHealth> GetNodeHealthAsync(NodeHealthQueryDescription queryDescription);
        //Task<NodeHealth> GetNodeHealthAsync(NodeHealthQueryDescription queryDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ApplicationHealth> GetApplicationHealthAsync(Uri applicationName);
        //Task<ApplicationHealth> GetApplicationHealthAsync(Uri applicationName, ApplicationHealthPolicy healthPolicy);
        //Task<ApplicationHealth> GetApplicationHealthAsync(Uri applicationName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ApplicationHealth> GetApplicationHealthAsync(Uri applicationName, ApplicationHealthPolicy healthPolicy, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ApplicationHealth> GetApplicationHealthAsync(ApplicationHealthQueryDescription queryDescription);
        //Task<ApplicationHealth> GetApplicationHealthAsync(ApplicationHealthQueryDescription queryDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServiceHealth> GetServiceHealthAsync(Uri serviceName);
        //Task<ServiceHealth> GetServiceHealthAsync(Uri serviceName, ApplicationHealthPolicy healthPolicy);
        //Task<ServiceHealth> GetServiceHealthAsync(Uri serviceName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServiceHealth> GetServiceHealthAsync(Uri serviceName, ApplicationHealthPolicy healthPolicy, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServiceHealth> GetServiceHealthAsync(ServiceHealthQueryDescription queryDescription);
        //Task<ServiceHealth> GetServiceHealthAsync(ServiceHealthQueryDescription queryDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<PartitionHealth> GetPartitionHealthAsync(Guid partitionId);
        //Task<PartitionHealth> GetPartitionHealthAsync(Guid partitionId, ApplicationHealthPolicy healthPolicy);
        //Task<PartitionHealth> GetPartitionHealthAsync(Guid partitionId, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<PartitionHealth> GetPartitionHealthAsync(Guid partitionId, ApplicationHealthPolicy healthPolicy, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<PartitionHealth> GetPartitionHealthAsync(PartitionHealthQueryDescription queryDescription);
        //Task<PartitionHealth> GetPartitionHealthAsync(PartitionHealthQueryDescription queryDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ReplicaHealth> GetReplicaHealthAsync(Guid partitionId, long replicaId);
        //Task<ReplicaHealth> GetReplicaHealthAsync(Guid partitionId, long replicaId, ApplicationHealthPolicy healthPolicy);
        //Task<ReplicaHealth> GetReplicaHealthAsync(Guid partitionId, long replicaId, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ReplicaHealth> GetReplicaHealthAsync(Guid partitionId, long replicaId, ApplicationHealthPolicy healthPolicy, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ReplicaHealth> GetReplicaHealthAsync(ReplicaHealthQueryDescription queryDescription);
        //Task<ReplicaHealth> GetReplicaHealthAsync(ReplicaHealthQueryDescription queryDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<DeployedApplicationHealth> GetDeployedApplicationHealthAsync(Uri applicationName, string nodeName);
        //Task<DeployedApplicationHealth> GetDeployedApplicationHealthAsync(Uri applicationName, string nodeName, ApplicationHealthPolicy healthPolicy);
        //Task<DeployedApplicationHealth> GetDeployedApplicationHealthAsync(Uri applicationName, string nodeName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<DeployedApplicationHealth> GetDeployedApplicationHealthAsync(Uri applicationName, string nodeName, ApplicationHealthPolicy healthPolicy, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<DeployedApplicationHealth> GetDeployedApplicationHealthAsync(DeployedApplicationHealthQueryDescription queryDescription);
        //Task<DeployedApplicationHealth> GetDeployedApplicationHealthAsync(DeployedApplicationHealthQueryDescription queryDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<DeployedServicePackageHealth> GetDeployedServicePackageHealthAsync(Uri applicationName, string serviceManifestName, string nodeName);
        //Task<DeployedServicePackageHealth> GetDeployedServicePackageHealthAsync(Uri applicationName, string serviceManifestName, string nodeName, ApplicationHealthPolicy healthPolicy);
        //Task<DeployedServicePackageHealth> GetDeployedServicePackageHealthAsync(Uri applicationName, string serviceManifestName, string nodeName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<DeployedServicePackageHealth> GetDeployedServicePackageHealthAsync(Uri applicationName, string serviceManifestName, string nodeName, ApplicationHealthPolicy healthPolicy, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<DeployedServicePackageHealth> GetDeployedServicePackageHealthAsync(DeployedServicePackageHealthQueryDescription queryDescription);
        //Task<DeployedServicePackageHealth> GetDeployedServicePackageHealthAsync(DeployedServicePackageHealthQueryDescription queryDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ClusterHealthChunk> GetClusterHealthChunkAsync();
        //Task<ClusterHealthChunk> GetClusterHealthChunkAsync(TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ClusterHealthChunk> GetClusterHealthChunkAsync(ClusterHealthChunkQueryDescription queryDescription);
        //Task<ClusterHealthChunk> GetClusterHealthChunkAsync(ClusterHealthChunkQueryDescription queryDescription, TimeSpan timeout, CancellationToken cancellationToken);
    }
}