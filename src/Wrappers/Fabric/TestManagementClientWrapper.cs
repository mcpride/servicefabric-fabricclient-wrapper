// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;

namespace MS.Extensions.Fabric
{
    internal class TestManagementClientWrapper : ITestManagementClient
    {
        // ReSharper disable once NotAccessedField.Local
        private readonly FabricClient _fabricClient;

        public TestManagementClientWrapper(FabricClient fabricClient)
        {
            _fabricClient = fabricClient ?? throw new ArgumentNullException(nameof(fabricClient));
        }
    }
}