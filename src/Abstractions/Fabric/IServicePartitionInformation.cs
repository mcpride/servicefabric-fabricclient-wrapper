// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;

namespace MS.Extensions.Fabric
{
    public interface IServicePartitionInformation
    {
        Guid Id { get; }
        ServicePartitionKind Kind { get; }
    }
}
