// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Collections.Generic;
using System.Fabric;
using System.Fabric.Health;
using System.Fabric.Query;
using System.Numerics;
using System.Text;

namespace MS.Extensions.Fabric.Query
{
    public interface INode
    {
        string NodeName { get; }
        string IpAddressOrFQDN { get; }
        string NodeType { get; }
        string CodeVersion { get; }
        string ConfigVersion { get; }
        NodeStatus NodeStatus { get; }
        [Obsolete("This property is deprecated, use NodeUpAt instead.", false)]
        TimeSpan NodeUpTime { get; }
        [Obsolete("This property is deprecated, use NodeDownAt instead.", false)]
        TimeSpan NodeDownTime { get; }
        DateTime NodeUpAt { get; }
        DateTime NodeDownAt { get; }
        HealthState HealthState { get; }
        bool IsSeedNode { get; }
        string UpgradeDomain { get; }
        Uri FaultDomain { get; }
        NodeId NodeId { get; }
        BigInteger NodeInstanceId { get; }
        INodeDeactivationResult NodeDeactivationInfo { get; }
        bool IsStopped { get; }
        string InfrastructurePlacementID { get; }
    }
}
