// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;

namespace MS.Extensions.Fabric
{
    internal class ServiceManagementClientWrapper : IServiceManagementClient
    {
        private readonly FabricClient _fabricClient;

        public ServiceManagementClientWrapper(FabricClient fabricClient)
        {
            _fabricClient = fabricClient ?? throw new ArgumentNullException(nameof(fabricClient));
        }

        public event EventHandler ServiceNotificationFilterMatched
        {
            add => _fabricClient.ServiceManager.ServiceNotificationFilterMatched += value;
            remove => _fabricClient.ServiceManager.ServiceNotificationFilterMatched -= value;
        }
    }
}