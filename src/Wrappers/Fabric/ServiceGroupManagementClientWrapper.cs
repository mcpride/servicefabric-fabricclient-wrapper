// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;

namespace MS.Extensions.Fabric
{
    internal class ServiceGroupManagementClientWrapper : IServiceGroupManagementClient
    {
        // ReSharper disable once NotAccessedField.Local
        private readonly FabricClient _fabricClient;

        public ServiceGroupManagementClientWrapper(FabricClient fabricClient)
        {
            _fabricClient = fabricClient ?? throw new ArgumentNullException(nameof(fabricClient));
        }
    }
}