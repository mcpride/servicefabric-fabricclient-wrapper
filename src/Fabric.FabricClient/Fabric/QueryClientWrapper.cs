// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;
using System.Threading.Tasks;
using MS.Extensions.Fabric.Query;

namespace MS.Extensions.Fabric
{
    internal class QueryClientWrapper : IQueryClient
    {
        private readonly FabricClient _fabricClient;

        public QueryClientWrapper(FabricClient fabricClient)
        {
            _fabricClient = fabricClient ?? throw new ArgumentNullException(nameof(fabricClient));
        }

        public async Task<IApplicationList> GetApplicationListAsync()
        {
            var items = await _fabricClient.QueryManager.GetApplicationListAsync();
            return items == null ? null : new ApplicationListWrapper(items);
        }
    }
}