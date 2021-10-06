// MIT License
// Copyright (c) 2021 Marco Stolze

using System;

namespace MS.Extensions.Fabric
{
    public interface IServiceManagementClient
    {
        event EventHandler ServiceNotificationFilterMatched;
        //Task CreateServiceAsync(ServiceDescription description);
        //Task CreateServiceAsync(ServiceDescription serviceDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task CreateServiceFromTemplateAsync(Uri applicationName, Uri serviceName, string serviceTypeName, byte[] initializationData);
        //Task CreateServiceFromTemplateAsync(Uri applicationName, Uri serviceName, string serviceTypeName, byte[] initializationData, TimeSpan timeout, CancellationToken cancellationToken);
        //Task CreateServiceFromTemplateAsync(ServiceFromTemplateDescription serviceFromTemplateDescription);
        //Task CreateServiceFromTemplateAsync(ServiceFromTemplateDescription serviceFromTemplateDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task UpdateServiceAsync(Uri name, ServiceUpdateDescription updateDescription);
        //Task UpdateServiceAsync(Uri name, ServiceUpdateDescription serviceUpdateDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //[Obsolete("This API is deprecated, use overload taking DeleteServiceDescription instead.", false)]
        //Task DeleteServiceAsync(Uri serviceName);
        //[Obsolete("This API is deprecated, use overload taking DeleteServiceDescription instead.", false)]
        //Task DeleteServiceAsync(Uri serviceName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task DeleteServiceAsync(DeleteServiceDescription deleteServiceDescription);
        //Task DeleteServiceAsync(DeleteServiceDescription deleteServiceDescription, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ServiceDescription> GetServiceDescriptionAsync(Uri serviceName);
        //Task<ServiceDescription> GetServiceDescriptionAsync(Uri serviceName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ResolvedServicePartition> ResolveServicePartitionAsync(Uri serviceName);
        //Task<ResolvedServicePartition> ResolveServicePartitionAsync(Uri serviceName, TimeSpan timeout);
        //Task<ResolvedServicePartition> ResolveServicePartitionAsync(Uri serviceName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ResolvedServicePartition> ResolveServicePartitionAsync(Uri serviceName, ResolvedServicePartition previousResult);
        //Task<ResolvedServicePartition> ResolveServicePartitionAsync(Uri serviceName, ResolvedServicePartition previousResult, TimeSpan timeout);
        //Task<ResolvedServicePartition> ResolveServicePartitionAsync(Uri serviceName, ResolvedServicePartition previousResult, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ResolvedServicePartition> ResolveServicePartitionAsync(Uri serviceName, long partitionKey);
        //Task<ResolvedServicePartition> ResolveServicePartitionAsync(Uri serviceName, long partitionKey, TimeSpan timeout);
        //Task<ResolvedServicePartition> ResolveServicePartitionAsync(Uri serviceName, long partitionKey, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ResolvedServicePartition> ResolveServicePartitionAsync(Uri serviceName, long partitionKey, ResolvedServicePartition previousResult);
        //Task<ResolvedServicePartition> ResolveServicePartitionAsync(Uri serviceName, long partitionKey, ResolvedServicePartition previousResult, TimeSpan timeout);
        //Task<ResolvedServicePartition> ResolveServicePartitionAsync(Uri serviceName, long partitionKey, ResolvedServicePartition previousResult, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ResolvedServicePartition> ResolveServicePartitionAsync(Uri serviceName, string partitionKey);
        //Task<ResolvedServicePartition> ResolveServicePartitionAsync(Uri serviceName, string partitionKey, TimeSpan timeout);
        //Task<ResolvedServicePartition> ResolveServicePartitionAsync(Uri serviceName, string partitionKey, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<ResolvedServicePartition> ResolveServicePartitionAsync(Uri serviceName, string partitionKey, ResolvedServicePartition previousResult);
        //Task<ResolvedServicePartition> ResolveServicePartitionAsync(Uri serviceName, string partitionKey, ResolvedServicePartition previousResult, TimeSpan timeout);
        //Task<ResolvedServicePartition> ResolveServicePartitionAsync(Uri serviceName, string partitionKey, ResolvedServicePartition previousResult, TimeSpan timeout, CancellationToken cancellationToken);
        //[Obsolete("This API is obsolete. Use RegisterServiceNotificationFilterAsync instead.", false)]
        //long RegisterServicePartitionResolutionChangeHandler(Uri serviceName, ServicePartitionResolutionChangeHandler callback);
        //[Obsolete("This API is obsolete. Use RegisterServiceNotificationFilterAsync instead.", false)]
        //long RegisterServicePartitionResolutionChangeHandler(Uri serviceName, long partitionKey, ServicePartitionResolutionChangeHandler callback);
        //[Obsolete("This API is obsolete. Use RegisterServiceNotificationFilterAsync instead.", false)]
        //long RegisterServicePartitionResolutionChangeHandler(Uri serviceName, string partitionKey, ServicePartitionResolutionChangeHandler callback);
        //void UnregisterServicePartitionResolutionChangeHandler(long callbackHandle);
        //Task<string> GetServiceManifestAsync(string applicationTypeName, string applicationTypeVersion, string serviceManifestName);
        //Task<string> GetServiceManifestAsync(string applicationTypeName, string applicationTypeVersion, string serviceManifestName, TimeSpan timeout, CancellationToken cancellationToken);
        //Task RemoveReplicaAsync(string nodeName, Guid partitionId, long replicaOrInstanceId);
        //Task RemoveReplicaAsync(string nodeName, Guid partitionId, long replicaOrInstanceId, bool forceRemove);
        //Task RemoveReplicaAsync(string nodeName, Guid partitionId, long replicaOrInstanceId, TimeSpan timeout, CancellationToken cancellationToken);
        //Task RemoveReplicaAsync(string nodeName, Guid partitionId, long replicaOrInstanceId, bool forceRemove, TimeSpan timeout, CancellationToken cancellationToken);
        //Task RestartReplicaAsync(string nodeName, Guid partitionId, long replicaOrInstanceId);
        //Task RestartReplicaAsync(string nodeName, Guid partitionId, long replicaOrInstanceId, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<long> RegisterServiceNotificationFilterAsync(ServiceNotificationFilterDescription description);
        //Task<long> RegisterServiceNotificationFilterAsync(ServiceNotificationFilterDescription description, TimeSpan timeout, CancellationToken cancellationToken);
        //Task UnregisterServiceNotificationFilterAsync(long filterId);
        //Task UnregisterServiceNotificationFilterAsync(long filterId, TimeSpan timeout, CancellationToken cancellationToken);
    }
}