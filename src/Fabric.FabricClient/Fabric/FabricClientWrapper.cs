// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;

namespace MS.Extensions.Fabric
{
    internal class FabricClientWrapper : IFabricClient
    {
        internal static readonly TimeSpan DefaultTimeout = TimeSpan.FromMinutes(1.0);
        private readonly FabricClient _fabricClient;

        public Uri FabricSystemApplication => _fabricClient.FabricSystemApplication;
        public IPropertyManagementClient PropertyManager { get; }
        public IServiceManagementClient ServiceManager { get; }
        public IServiceGroupManagementClient ServiceGroupManager { get; }
        public IApplicationManagementClient ApplicationManager { get; }
        public IComposeDeploymentClient ComposeDeploymentManager { get; }
        public IClusterManagementClient ClusterManager { get; }
        public IRepairManagementClient RepairManager { get; }
        public IQueryClient QueryManager { get; }
        public IHealthClient HealthManager { get; }
        public IInfrastructureServiceClient InfrastructureManager { get; }
        public ITestManagementClient TestManager { get; }
        public IFaultManagementClient FaultManager { get; }
        public INetworkManagementClient NetworkManager { get; }
        public FabricClientSettings Settings => _fabricClient.Settings;

        public event EventHandler ClientConnected
        {
            add => _fabricClient.ClientConnected += value;
            remove => _fabricClient.ClientConnected -= value;
        }

        public event EventHandler ClientDisconnected
        {
            add => _fabricClient.ClientDisconnected += value;
            remove => _fabricClient.ClientDisconnected -= value;
        }

        public event FabricClient.ClaimsRetrievalEventHandler ClaimsRetrieval
        {
            add => _fabricClient.ClaimsRetrieval += value;
            remove => _fabricClient.ClaimsRetrieval -= value;
        }

        public FabricClientWrapper(FabricClient fabricClient)
        {
            _fabricClient = fabricClient ?? throw new ArgumentNullException(nameof(fabricClient));
            PropertyManager = new PropertyManagementClientWrapper(_fabricClient.PropertyManager);
            ServiceManager = new ServiceManagementClientWrapper(_fabricClient);
            ServiceGroupManager = new ServiceGroupManagementClientWrapper(_fabricClient);
            ApplicationManager = new ApplicationManagementClientWrapper(_fabricClient);
            ComposeDeploymentManager = new ComposeDeploymentClientWrapper();
            ClusterManager = new ClusterManagementClientWrapper(_fabricClient);
            RepairManager = new RepairManagementClientWrapper(_fabricClient);
            QueryManager = new QueryClientWrapper(_fabricClient.QueryManager);
            HealthManager = new HealthClientWrapper(_fabricClient);
            InfrastructureManager = new InfrastructureServiceClientWrapper(_fabricClient);
            TestManager = new TestManagementClientWrapper(_fabricClient);
            FaultManager = new FaultManagementClientWrapper(_fabricClient);
            NetworkManager = new NetworkManagementClientWrapper(_fabricClient);
        }

        public void UpdateSettings(FabricClientSettings settings)
        {
            _fabricClient.UpdateSettings(settings);
        }

        public void UpdateSecurityCredentials(SecurityCredentials credentials)
        {
            _fabricClient.UpdateSecurityCredentials(credentials);
        }

        #region disposable
        private void ReleaseUnmanagedResources()
        {
            // TODO release unmanaged resources here
        }

        protected virtual void Dispose(bool disposing)
        {
            ReleaseUnmanagedResources();
            if (disposing)
            {
                _fabricClient.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~FabricClientWrapper()
        {
            Dispose(false);
        }
        #endregion disposable
    }
}
