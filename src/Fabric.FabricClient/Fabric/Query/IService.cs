// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric.Health;
using System.Fabric.Query;

namespace MS.Extensions.Fabric.Query
{
    public interface IService
    {
        ServiceKind ServiceKind { get; }
        Uri ServiceName { get; }
        string ServiceTypeName { get; }
        string ServiceManifestVersion { get; }
        HealthState HealthState { get; }
        ServiceStatus ServiceStatus { get; }
        bool IsServiceGroup { get; }
    }
}
