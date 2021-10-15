// MIT License
// Copyright (c) 2021 Marco Stolze

using System.Fabric.Health;
using System.Fabric.Query;

namespace MS.Extensions.Fabric.Query
{
    public interface IPartition
    {
        ServiceKind ServiceKind { get; }
        HealthState HealthState { get; }
        IServicePartitionInformation PartitionInformation { get; }
        ServicePartitionStatus PartitionStatus { get; }
    }
}
