// MIT License
// Copyright (c) 2021 Marco Stolze

using MS.Extensions.Fabric.Description;

namespace MS.Extensions.Fabric.Query
{
    public interface IServiceType
    {
        IServiceTypeDescription ServiceTypeDescription { get; }
        string ServiceManifestVersion { get; }
        string ServiceManifestName { get; }
        bool IsServiceGroup { get; }
    }
}