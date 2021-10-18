// MIT License
// Copyright (c) 2021 Marco Stolze

using System;

namespace MS.Extensions.Fabric.Query
{
    public interface IServiceGroupMemberMember
    {
        Uri ServiceName { get; }
        string ServiceTypeName { get; }
    }
}
