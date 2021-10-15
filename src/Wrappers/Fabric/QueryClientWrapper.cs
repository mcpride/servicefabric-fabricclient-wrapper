// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;
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
        public async Task<IApplicationTypeList> GetApplicationTypeListAsync()
        {
            var items = await _client.GetApplicationTypeListAsync();
            return items == null ? null : new ApplicationTypeListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IApplicationTypePagedList> GetApplicationTypePagedListAsync()
        {
            var items = await _client.GetApplicationTypePagedListAsync();
            return items == null ? null : new ApplicationTypePagedListWrapper(items);
        }

        ///<inheritdoc/>
        public async Task<IApplicationList> GetApplicationListAsync()
        {
            var items = await _client.GetApplicationListAsync();
            return items == null ? null : new ApplicationListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServiceList> GetServiceListAsync(Uri applicationName)
        {
            var items = await _client.GetServiceListAsync(applicationName);
            return items == null ? null : new ServiceListWrapper(items);
        }

        /// <inheritdoc />
        public async Task<IServicePartitionList> GetPartitionListAsync(Uri serviceName)
        {
            var items = await _client.GetPartitionListAsync(serviceName);
            return items == null ? null : new ServicePartitionListWrapper(items);
        }
    }
}