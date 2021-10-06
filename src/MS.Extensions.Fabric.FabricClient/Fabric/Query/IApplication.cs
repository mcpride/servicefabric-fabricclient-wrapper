// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric.Description;
using System.Fabric.Health;
using System.Fabric.Query;

namespace MS.Extensions.Fabric.Query
{
    public interface IApplication
    {
        Uri ApplicationName { get; }
        string ApplicationTypeName { get; }
        string ApplicationTypeVersion { get; }
        ApplicationStatus ApplicationStatus { get; }
        HealthState HealthState { get; }
        ApplicationParameterList ApplicationParameters { get; }
        ApplicationDefinitionKind ApplicationDefinitionKind { get; }
        [Obsolete("Use ApplicationUpgradeProgress.")]
        string UpgradeTypeVersion { get; }
        [Obsolete("Use ApplicationUpgradeProgress.")]
        ApplicationParameterList UpgradeParameters { get; }
        ManagedApplicationIdentityDescription ManagedApplicationIdentity { get; set; }
    }
}