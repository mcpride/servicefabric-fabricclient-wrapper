// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;

namespace MS.Extensions.Fabric
{
    public interface IFabricClient : IDisposable
    {
        Uri FabricSystemApplication { get; }
        IPropertyManagementClient PropertyManager { get; }
        IServiceManagementClient ServiceManager { get; }
        IServiceGroupManagementClient ServiceGroupManager { get; }
        IApplicationManagementClient ApplicationManager { get; }
        IComposeDeploymentClient ComposeDeploymentManager { get; }
        IClusterManagementClient ClusterManager { get; }
        IRepairManagementClient RepairManager { get; }
        IQueryClient QueryManager { get; }
        IHealthClient HealthManager { get; }
        IInfrastructureServiceClient InfrastructureManager { get; }
        ITestManagementClient TestManager { get; }
        IFaultManagementClient FaultManager { get; }
        INetworkManagementClient NetworkManager { get; }
        FabricClientSettings Settings { get; }
        event EventHandler ClientConnected;
        event EventHandler ClientDisconnected;
        event FabricClient.ClaimsRetrievalEventHandler ClaimsRetrieval;
        void UpdateSettings(FabricClientSettings settings);
        void UpdateSecurityCredentials(SecurityCredentials credentials);
    }
}