// MIT License
// Copyright (c) 2021 Marco Stolze

using System.Collections.Generic;
using System.Fabric.Description;

namespace MS.Extensions.Fabric.Query
{
    public interface IServiceGroupMemberType
    {
        ICollection<ServiceGroupTypeMemberDescription> ServiceGroupMemberTypeDescription { get; }
        string ServiceManifestVersion { get; }
        string ServiceManifestName { get; }
    }
}