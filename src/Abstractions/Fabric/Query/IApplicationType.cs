// MIT License
// Copyright (c) 2021 Marco Stolze

using System.Fabric.Description;
using System.Fabric.Query;

namespace MS.Extensions.Fabric.Query
{
    public interface IApplicationType
    {
        string ApplicationTypeName { get; }
        string ApplicationTypeVersion { get; }
        ApplicationTypeStatus Status { get; }
        string StatusDetails { get; }
        ApplicationParameterList DefaultParameters { get; }
        ApplicationTypeDefinitionKind ApplicationTypeDefinitionKind { get; }
    }
}
