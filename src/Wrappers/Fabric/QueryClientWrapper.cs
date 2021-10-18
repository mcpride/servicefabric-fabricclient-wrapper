// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;
using System.Fabric.Description;
using System.Fabric.Query;
using System.Threading;
using System.Threading.Tasks;
using MS.Extensions.Fabric.Query;

namespace MS.Extensions.Fabric
{
    ///<inheritdoc/>
    internal class QueryClientWrapper : IQueryClient
    {
        private readonly FabricClient.QueryClient _client;

        public QueryClientWrapper(FabricClient.QueryClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        /// <inheritdoc />
        public async Task<INodeList> GetNodeListAsync()
        {
            var items = await _client.GetNodeListAsync();
            return items == null ? null : new NodeListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<INodeList> GetNodeListAsync(string nodeNameFilter)
        {
            var items = await _client.GetNodeListAsync(nodeNameFilter);
            return items == null ? null : new NodeListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<INodeList> GetNodeListAsync(string nodeNameFilter, string continuationToken)
        {
            var items = await _client.GetNodeListAsync(nodeNameFilter, continuationToken);
            return items == null ? null : new NodeListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<INodeList> GetNodeListAsync(string nodeNameFilter, TimeSpan timeout, CancellationToken cancellationToken)
        {
            var items = await _client.GetNodeListAsync(nodeNameFilter, timeout, cancellationToken);
            return items == null ? null : new NodeListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<INodeList> GetNodeListAsync(string nodeNameFilter, string continuationToken, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            var items = await _client.GetNodeListAsync(nodeNameFilter, continuationToken, timeout, cancellationToken);
            return items == null ? null : new NodeListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<INodeList> GetNodeListAsync(string nodeNameFilter, NodeStatusFilter nodeStatusFilter, string continuationToken,
            TimeSpan timeout, CancellationToken cancellationToken)
        {
            var items = await _client.GetNodeListAsync(nodeNameFilter, nodeStatusFilter, continuationToken, timeout, cancellationToken);
            return items == null ? null : new NodeListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<INodeList> GetNodePagedListAsync()
        {
            var items = await _client.GetNodePagedListAsync();
            return items == null ? null : new NodeListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<INodeList> GetNodePagedListAsync(NodeQueryDescription queryDescription)
        {
            var items = await _client.GetNodePagedListAsync(queryDescription);
            return items == null ? null : new NodeListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<INodeList> GetNodePagedListAsync(NodeQueryDescription queryDescription, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            var items = await _client.GetNodePagedListAsync(queryDescription, timeout, cancellationToken);
            return items == null ? null : new NodeListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IApplicationTypeList> GetApplicationTypeListAsync()
        {
            var items = await _client.GetApplicationTypeListAsync();
            return items == null ? null : new ApplicationTypeListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IApplicationTypeList> GetApplicationTypeListAsync(string applicationTypeNameFilter)
        {
            var items = await _client.GetApplicationTypeListAsync(applicationTypeNameFilter);
            return items == null ? null : new ApplicationTypeListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IApplicationTypeList> GetApplicationTypeListAsync(string applicationTypeNameFilter, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            var items = await _client.GetApplicationTypeListAsync(applicationTypeNameFilter, timeout, cancellationToken);
            return items == null ? null : new ApplicationTypeListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IApplicationTypePagedList> GetApplicationTypePagedListAsync()
        {
            var items = await _client.GetApplicationTypePagedListAsync();
            return items == null ? null : new ApplicationTypePagedListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IApplicationTypePagedList> GetApplicationTypePagedListAsync(PagedApplicationTypeQueryDescription queryDescription)
        {
            var items = await _client.GetApplicationTypePagedListAsync(queryDescription);
            return items == null ? null : new ApplicationTypePagedListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IApplicationTypePagedList> GetApplicationTypePagedListAsync(PagedApplicationTypeQueryDescription queryDescription, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            var items = await _client.GetApplicationTypePagedListAsync(queryDescription, timeout, cancellationToken);
            return items == null ? null : new ApplicationTypePagedListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServiceTypeList> GetServiceTypeListAsync(string applicationTypeName, string applicationTypeVersion)
        {
            var items = await _client.GetServiceTypeListAsync(applicationTypeName, applicationTypeVersion);
            return items == null ? null : new ServiceTypeListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServiceTypeList> GetServiceTypeListAsync(string applicationTypeName, string applicationTypeVersion, string serviceTypeNameFilter)
        {
            var items = await _client.GetServiceTypeListAsync(applicationTypeName, applicationTypeVersion, serviceTypeNameFilter);
            return items == null ? null : new ServiceTypeListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServiceTypeList> GetServiceTypeListAsync(string applicationTypeName, string applicationTypeVersion, string serviceTypeNameFilter,
            TimeSpan timeout, CancellationToken cancellationToken)
        {
            var items = await _client.GetServiceTypeListAsync(applicationTypeName, applicationTypeVersion, serviceTypeNameFilter, timeout, cancellationToken);
            return items == null ? null : new ServiceTypeListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServiceGroupMemberTypeList> GetServiceGroupMemberTypeListAsync(string applicationTypeName, string applicationTypeVersion)
        {
            var items = await _client.GetServiceGroupMemberTypeListAsync(applicationTypeName, applicationTypeVersion);
            return items == null ? null : new ServiceGroupMemberTypeListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServiceGroupMemberTypeList> GetServiceGroupMemberTypeListAsync(string applicationTypeName, string applicationTypeVersion,
            string serviceGroupTypeNameFilter)
        {
            var items = await _client.GetServiceGroupMemberTypeListAsync(applicationTypeName, applicationTypeVersion, serviceGroupTypeNameFilter);
            return items == null ? null : new ServiceGroupMemberTypeListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServiceGroupMemberTypeList> GetServiceGroupMemberTypeListAsync(string applicationTypeName, string applicationTypeVersion,
            string serviceGroupTypeNameFilter, TimeSpan timeout, CancellationToken cancellationToken)
        {
            var items = await _client.GetServiceGroupMemberTypeListAsync(applicationTypeName, applicationTypeVersion, serviceGroupTypeNameFilter, timeout, cancellationToken);
            return items == null ? null : new ServiceGroupMemberTypeListWrapper(items);
        }

        ///<inheritdoc/>
        public async Task<IApplicationList> GetApplicationListAsync()
        {
            var items = await _client.GetApplicationListAsync();
            return items == null ? null : new ApplicationListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IApplicationList> GetApplicationListAsync(Uri applicationNameFilter)
        {
            var items = await _client.GetApplicationListAsync(applicationNameFilter);
            return items == null ? null : new ApplicationListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IApplicationList> GetApplicationListAsync(Uri applicationNameFilter, string continuationToken)
        {
            var items = await _client.GetApplicationListAsync(applicationNameFilter, continuationToken);
            return items == null ? null : new ApplicationListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IApplicationList> GetApplicationListAsync(Uri applicationNameFilter, TimeSpan timeout, CancellationToken cancellationToken)
        {
            var items = await _client.GetApplicationListAsync(applicationNameFilter, timeout, cancellationToken);
            return items == null ? null : new ApplicationListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IApplicationList> GetApplicationListAsync(Uri applicationNameFilter, string continuationToken, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            var items = await _client.GetApplicationListAsync(applicationNameFilter, continuationToken, timeout, cancellationToken);
            return items == null ? null : new ApplicationListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IApplicationList> GetApplicationPagedListAsync(ApplicationQueryDescription applicationQueryDescription)
        {
            var items = await _client.GetApplicationPagedListAsync(applicationQueryDescription);
            return items == null ? null : new ApplicationListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IApplicationList> GetApplicationPagedListAsync(ApplicationQueryDescription applicationQueryDescription, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            var items = await _client.GetApplicationPagedListAsync(applicationQueryDescription, timeout, cancellationToken);
            return items == null ? null : new ApplicationListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServiceList> GetServiceListAsync(Uri applicationName)
        {
            var items = await _client.GetServiceListAsync(applicationName);
            return items == null ? null : new ServiceListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServiceList> GetServiceListAsync(Uri applicationName, Uri serviceNameFilter)
        {
            var items = await _client.GetServiceListAsync(applicationName, serviceNameFilter);
            return items == null ? null : new ServiceListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServiceList> GetServiceListAsync(Uri applicationName, Uri serviceNameFilter, string continuationToken)
        {
            var items = await _client.GetServiceListAsync(applicationName, serviceNameFilter, continuationToken);
            return items == null ? null : new ServiceListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServiceList> GetServiceListAsync(Uri applicationName, Uri serviceNameFilter, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            var items = await _client.GetServiceListAsync(applicationName, serviceNameFilter, timeout, cancellationToken);
            return items == null ? null : new ServiceListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServiceList> GetServiceListAsync(Uri applicationName, Uri serviceNameFilter, string continuationToken, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            var items = await _client.GetServiceListAsync(applicationName, serviceNameFilter, continuationToken, timeout, cancellationToken);
            return items == null ? null : new ServiceListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServiceList> GetServicePagedListAsync(ServiceQueryDescription serviceQueryDescription)
        {
            var items = await _client.GetServicePagedListAsync(serviceQueryDescription);
            return items == null ? null : new ServiceListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServiceList> GetServicePagedListAsync(ServiceQueryDescription serviceQueryDescription, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            var items = await _client.GetServicePagedListAsync(serviceQueryDescription);
            return items == null ? null : new ServiceListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServiceGroupMemberList> GetServiceGroupMemberListAsync(Uri applicationName)
        {
            var items = await _client.GetServiceGroupMemberListAsync(applicationName);
            return items == null ? null : new ServiceGroupMemberListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServiceGroupMemberList> GetServiceGroupMemberListAsync(Uri applicationName, Uri serviceNameFilter)
        {
            var items = await _client.GetServiceGroupMemberListAsync(applicationName, serviceNameFilter);
            return items == null ? null : new ServiceGroupMemberListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServiceGroupMemberList> GetServiceGroupMemberListAsync(Uri applicationName, Uri serviceNameFilter, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            var items = await _client.GetServiceGroupMemberListAsync(applicationName, serviceNameFilter, timeout, cancellationToken);
            return items == null ? null : new ServiceGroupMemberListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServicePartitionList> GetPartitionListAsync(Uri serviceName)
        {
            var items = await _client.GetPartitionListAsync(serviceName);
            return items == null ? null : new ServicePartitionListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServicePartitionList> GetPartitionListAsync(Uri serviceName, string continuationToken)
        {
            var items = await _client.GetPartitionListAsync(serviceName, continuationToken);
            return items == null ? null : new ServicePartitionListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServicePartitionList> GetPartitionListAsync(Uri serviceName, Guid? partitionIdFilter)
        {
            var items = await _client.GetPartitionListAsync(serviceName, partitionIdFilter);
            return items == null ? null : new ServicePartitionListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServicePartitionList> GetPartitionListAsync(Uri serviceName, Guid? partitionIdFilter, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            var items = await _client.GetPartitionListAsync(serviceName, partitionIdFilter, timeout, cancellationToken);
            return items == null ? null : new ServicePartitionListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServicePartitionList> GetPartitionListAsync(Uri serviceName, Guid? partitionIdFilter, string continuationToken, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            var items = await _client.GetPartitionListAsync(serviceName, partitionIdFilter, continuationToken, timeout, cancellationToken);
            return items == null ? null : new ServicePartitionListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServicePartitionList> GetPartitionAsync(Guid partitionId, TimeSpan timeout, CancellationToken cancellationToken)
        {
            var items = await _client.GetPartitionAsync(partitionId, timeout, cancellationToken);
            return items == null ? null : new ServicePartitionListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServicePartitionList> GetPartitionAsync(Guid partitionId)
        {
            var items = await _client.GetPartitionAsync(partitionId);
            return items == null ? null : new ServicePartitionListWrapper(items);
        }
    }
}