// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;
using System.Fabric.Health;

namespace MS.Extensions.Fabric
{
    internal class HealthClientWrapper : IHealthClient
    {
        private readonly FabricClient _fabricClient;

        public HealthClientWrapper(FabricClient fabricClient)
        {
            _fabricClient = fabricClient ?? throw new ArgumentNullException(nameof(fabricClient));
        }

        public void ReportHealth(HealthReport healthReport)
        {
            _fabricClient.HealthManager.ReportHealth(healthReport);
        }
    }
}