// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;
using System.Fabric.Health;
using System.Fabric.Query;
using System.Numerics;

namespace MS.Extensions.Fabric.Query
{

    internal class NodeWrapper : INode
    {
        internal readonly Node Item;

        /// <inheritdoc />
        public string NodeName => Item.NodeName;

        /// <inheritdoc />
        public string IpAddressOrFQDN => Item.IpAddressOrFQDN;

        /// <inheritdoc />
        public string NodeType => Item.IpAddressOrFQDN;

        /// <inheritdoc />
        public string CodeVersion => Item.CodeVersion;

        /// <inheritdoc />
        public string ConfigVersion => Item.ConfigVersion;

        /// <inheritdoc />
        public NodeStatus NodeStatus => Item.NodeStatus;

        /// <inheritdoc />
        [Obsolete("This property is deprecated, use NodeUpAt instead.", false)]
        public TimeSpan NodeUpTime => Item.NodeUpTime;

        /// <inheritdoc />
        [Obsolete("This property is deprecated, use NodeDownAt instead.", false)]
        public TimeSpan NodeDownTime => Item.NodeDownTime;

        /// <inheritdoc />
        public DateTime NodeUpAt => Item.NodeUpAt;

        /// <inheritdoc />
        public DateTime NodeDownAt => Item.NodeDownAt;

        /// <inheritdoc />
        public HealthState HealthState => Item.HealthState;

        /// <inheritdoc />
        public bool IsSeedNode => Item.IsSeedNode;

        /// <inheritdoc />
        public string UpgradeDomain => Item.UpgradeDomain;

        /// <inheritdoc />
        public Uri FaultDomain => Item.FaultDomain;

        /// <inheritdoc />
        public NodeId NodeId => Item.NodeId;

        /// <inheritdoc />
        public BigInteger NodeInstanceId => Item.NodeInstanceId;

        /// <inheritdoc />
        public INodeDeactivationResult NodeDeactivationInfo => new NodeDeactivationResultWrapper(Item.NodeDeactivationInfo);

        /// <inheritdoc />
        public bool IsStopped => Item.IsStopped;

        /// <inheritdoc />
        public string InfrastructurePlacementID => Item.InfrastructurePlacementID;
        
        public NodeWrapper(Node item)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
        }

        public static bool operator == (NodeWrapper value1, NodeWrapper value2)
        {
            // ReSharper disable RedundantCast
            if ((object)value1 == (object)value2) return true;
            return (object)value1 != null && (object)value2 != null && value1.Item == value2.Item;
            // ReSharper restore RedundantCast
        }

        public static bool operator != (NodeWrapper value1, NodeWrapper value2)
        {
            return !(value1 == value2);
        }

        public override bool Equals(object obj)
        {
            if (obj is NodeWrapper wrapper)
            {
                return Item.Equals(wrapper.Item);
            }
            // ReSharper disable once BaseObjectEqualsIsObjectEquals
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Item.GetHashCode();
        }

        public override string ToString()
        {
            return Item.ToString();
        }
    }
}
