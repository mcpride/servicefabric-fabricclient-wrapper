﻿// MIT License
// Copyright (c) 2021 Marco Stolze

using System.Fabric.Query;
using System.Threading.Tasks;
using MS.Extensions.Fabric.Query;

namespace MS.Extensions.Fabric
{
    public interface IQueryClient
    {
        //Task<NodeList> GetNodeListAsync();
        //Task<NodeList> GetNodeListAsync(string nodeNameFilter);
        //Task<NodeList> GetNodeListAsync(string nodeNameFilter, string continuationToken);
        //Task<NodeList> GetNodeListAsync(string nodeNameFilter, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<NodeList> GetNodeListAsync(string nodeNameFilter, string continuationToken, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<NodeList> GetNodeListAsync(string nodeNameFilter, NodeStatusFilter nodeStatusFilter, string continuationToken, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<NodeList> GetNodePagedListAsync();
        //Task<NodeList> GetNodePagedListAsync(NodeQueryDescription queryDescription);
        //Task<NodeList> GetNodePagedListAsync(NodeQueryDescription queryDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ApplicationTypeList> GetApplicationTypeListAsync();
        //Task<ApplicationTypeList> GetApplicationTypeListAsync(string applicationTypeNameFilter);
        //Task<ApplicationTypeList> GetApplicationTypeListAsync(string applicationTypeNameFilter, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ApplicationTypePagedList> GetApplicationTypePagedListAsync();
        //Task<ApplicationTypePagedList> GetApplicationTypePagedListAsync(PagedApplicationTypeQueryDescription queryDescription);
        //Task<ApplicationTypePagedList> GetApplicationTypePagedListAsync(PagedApplicationTypeQueryDescription queryDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServiceTypeList> GetServiceTypeListAsync(string applicationTypeName, string applicationTypeVersion);
        //Task<ServiceTypeList> GetServiceTypeListAsync(string applicationTypeName, string applicationTypeVersion, string serviceTypeNameFilter);
        //Task<ServiceTypeList> GetServiceTypeListAsync(string applicationTypeName, string applicationTypeVersion, string serviceTypeNameFilter, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServiceGroupMemberTypeList> GetServiceGroupMemberTypeListAsync(string applicationTypeName, string applicationTypeVersion);
        //Task<ServiceGroupMemberTypeList> GetServiceGroupMemberTypeListAsync(string applicationTypeName, string applicationTypeVersion, string serviceGroupTypeNameFilter);
        //Task<ServiceGroupMemberTypeList> GetServiceGroupMemberTypeListAsync(string applicationTypeName, string applicationTypeVersion, string serviceGroupTypeNameFilter, TimeSpan timeout, CancellationToken cancellationToken);
        Task<IApplicationList> GetApplicationListAsync();
        //Task<IApplicationList> GetApplicationListAsync(Uri applicationNameFilter);
        //Task<IApplicationList> GetApplicationListAsync(Uri applicationNameFilter, string continuationToken);
        //Task<IApplicationList> GetApplicationListAsync(Uri applicationNameFilter, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<IApplicationList> GetApplicationListAsync(Uri applicationNameFilter, string continuationToken, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<IApplicationList> GetApplicationPagedListAsync(ApplicationQueryDescription applicationQueryDescription);
        //Task<IApplicationList> GetApplicationPagedListAsync(ApplicationQueryDescription applicationQueryDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServiceList> GetServiceListAsync(Uri applicationName);
        //Task<ServiceList> GetServiceListAsync(Uri applicationName, Uri serviceNameFilter);
        //Task<ServiceList> GetServiceListAsync(Uri applicationName, Uri serviceNameFilter, string continuationToken);
        //Task<ServiceList> GetServiceListAsync(Uri applicationName, Uri serviceNameFilter, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServiceList> GetServiceListAsync(Uri applicationName, Uri serviceNameFilter, string continuationToken, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServiceList> GetServicePagedListAsync(ServiceQueryDescription serviceQueryDescription);
        //Task<ServiceList> GetServicePagedListAsync(ServiceQueryDescription serviceQueryDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServiceGroupMemberList> GetServiceGroupMemberListAsync(Uri applicationName);
        //Task<ServiceGroupMemberList> GetServiceGroupMemberListAsync(Uri applicationName, Uri serviceNameFilter);
        //Task<ServiceGroupMemberList> GetServiceGroupMemberListAsync(Uri applicationName, Uri serviceNameFilter, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServicePartitionList> GetPartitionListAsync(Uri serviceName);
        //Task<ServicePartitionList> GetPartitionListAsync(Uri serviceName, string continuationToken);
        //Task<ServicePartitionList> GetPartitionListAsync(Uri serviceName, Guid? partitionIdFilter);
        //Task<ServicePartitionList> GetPartitionListAsync(Uri serviceName, Guid? partitionIdFilter, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServicePartitionList> GetPartitionListAsync(Uri serviceName, Guid? partitionIdFilter, string continuationToken, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServicePartitionList> GetPartitionAsync(Guid partitionId, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServicePartitionList> GetPartitionAsync(Guid partitionId);
        //Task<PartitionLoadInformation> GetPartitionLoadInformationAsync(Guid partitionId);
        //Task<PartitionLoadInformation> GetPartitionLoadInformationAsync(Guid partitionId, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServiceReplicaList> GetReplicaListAsync(Guid partitionId);
        //Task<ServiceReplicaList> GetReplicaListAsync(Guid partitionId, string continuationToken);
        //Task<ServiceReplicaList> GetReplicaListAsync(Guid partitionId, long replicaIdOrInstanceIdFilter);
        //Task<ServiceReplicaList> GetReplicaListAsync(Guid partitionId, long replicaIdOrInstanceIdFilter, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServiceReplicaList> GetReplicaListAsync(Guid partitionId, string continuationToken, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServiceReplicaList> GetReplicaListAsync(Guid partitionId, long replicaIdOrInstanceIdFilter, ServiceReplicaStatusFilter replicaStatusFilter, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServiceReplicaList> GetReplicaListAsync(Guid partitionId, long replicaIdOrInstanceIdFilter, ServiceReplicaStatusFilter replicaStatusFilter, string continuationToken, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<DeployedApplicationPagedList> GetDeployedApplicationPagedListAsync(PagedDeployedApplicationQueryDescription queryDescription);
        //Task<DeployedApplicationPagedList> GetDeployedApplicationPagedListAsync(PagedDeployedApplicationQueryDescription queryDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<DeployedApplicationList> GetDeployedApplicationListAsync(string nodeName);
        //Task<DeployedApplicationList> GetDeployedApplicationListAsync(string nodeName, Uri applicationNameFilter);
        //Task<DeployedApplicationList> GetDeployedApplicationListAsync(string nodeName, Uri applicationNameFilter, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<DeployedServicePackageList> GetDeployedServicePackageListAsync(string nodeName, Uri applicationName);
        //Task<DeployedServicePackageList> GetDeployedServicePackageListAsync(string nodeName, Uri applicationName, string serviceManifestNameFilter);
        //Task<DeployedServicePackageList> GetDeployedServicePackageListAsync(string nodeName, Uri applicationName, string serviceManifestNameFilter, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<DeployedServicePackagePagedList> GetDeployedServicePackagePagedListAsync(PagedDeployedServicePackageQueryDescription queryDescription);
        //Task<DeployedServicePackagePagedList> GetDeployedServicePackagePagedListAsync(PagedDeployedServicePackageQueryDescription queryDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<DeployedServiceTypeList> GetDeployedServiceTypeListAsync(string nodeName, Uri applicationName);
        //Task<DeployedServiceTypeList> GetDeployedServiceTypeListAsync(string nodeName, Uri applicationName, string serviceManifestNameFilter, string serviceTypeNameFilter);
        //Task<DeployedServiceTypeList> GetDeployedServiceTypeListAsync(string nodeName, Uri applicationName, string serviceManifestNameFilter, string serviceTypeNameFilter, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<DeployedCodePackageList> GetDeployedCodePackageListAsync(string nodeName, Uri applicationName);
        //Task<DeployedCodePackageList> GetDeployedCodePackageListAsync(string nodeName, Uri applicationName, string serviceManifestNameFilter, string codePackageNameFilter);
        //Task<DeployedCodePackageList> GetDeployedCodePackageListAsync(string nodeName, Uri applicationName, string serviceManifestNameFilter, string codePackageNameFilter, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<DeployedCodePackageList> GetDeployedCodePackageListAsync(string nodeName, Uri applicationName, string serviceManifestNameFilter, string codePackageNameFilter, bool includeCodePackageUsageStats);
        //Task<DeployedCodePackageList> GetDeployedCodePackageListAsync(string nodeName, Uri applicationName, string serviceManifestNameFilter, string codePackageNameFilter, bool includeCodePackageUsageStats, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<DeployedServiceReplicaList> GetDeployedReplicaListAsync(string nodeName, Uri applicationName);
        //Task<DeployedServiceReplicaList> GetDeployedReplicaListAsync(string nodeName, Uri applicationName, Guid? partitionIdFilter);
        //Task<DeployedServiceReplicaList> GetDeployedReplicaListAsync(string nodeName, Uri applicationName, string serviceManifestNameFilter, Guid? partitionIdFilter);
        //Task<DeployedServiceReplicaList> GetDeployedReplicaListAsync(string nodeName, Uri applicationName, string serviceManifestNameFilter, Guid? partitionIdFilter, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<DeployedServiceReplicaDetail> GetDeployedReplicaDetailAsync(string nodeName, Guid partitionId, long replicaId);
        //Task<DeployedServiceReplicaDetail> GetDeployedReplicaDetailAsync(string nodeName, Guid partitionId, long replicaId, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ClusterLoadInformation> GetClusterLoadInformationAsync();
        //Task<ClusterLoadInformation> GetClusterLoadInformationAsync(TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ProvisionedFabricCodeVersionList> GetProvisionedFabricCodeVersionListAsync();
        //Task<ProvisionedFabricCodeVersionList> GetProvisionedFabricCodeVersionListAsync(string codeVersionFilter);
        //Task<ProvisionedFabricCodeVersionList> GetProvisionedFabricCodeVersionListAsync(string codeVersionFilter, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ProvisionedFabricConfigVersionList> GetProvisionedFabricConfigVersionListAsync();
        //Task<ProvisionedFabricConfigVersionList> GetProvisionedFabricConfigVersionListAsync(string configVersionFilter);
        //Task<ProvisionedFabricConfigVersionList> GetProvisionedFabricConfigVersionListAsync(string configVersionFilter, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<NodeLoadInformation> GetNodeLoadInformationAsync(string nodeName);
        //Task<NodeLoadInformation> GetNodeLoadInformationAsync(string nodeName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ReplicaLoadInformation> GetReplicaLoadInformationAsync(Guid partitionId, long replicaIdOrInstanceId);
        //Task<ReplicaLoadInformation> GetReplicaLoadInformationAsync(Guid partitionId, long replicaIdOrInstanceId, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<UnplacedReplicaInformation> GetUnplacedReplicaInformationAsync(string serviceName, Guid partitionId, bool onlyQueryPrimaries);
        //Task<UnplacedReplicaInformation> GetUnplacedReplicaInformationAsync(string serviceName, Guid partitionId, bool onlyQueryPrimaries, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ApplicationLoadInformation> GetApplicationLoadInformationAsync(string applicationName);
        //Task<ApplicationLoadInformation> GetApplicationLoadInformationAsync(string applicationName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServiceNameResult> GetServiceNameAsync(Guid partitionId, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ApplicationNameResult> GetApplicationNameAsync(Uri serviceName, TimeSpan timeout, CancellationToken cancellationToken);
    }
}