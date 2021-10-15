// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Collections.Generic;
using System.Fabric;
using System.Fabric.Query;

namespace MS.Extensions.Fabric.Query
{
    internal class NodeDeactivationResultWrapper : INodeDeactivationResult
    {
        internal readonly NodeDeactivationResult Item;

        /// <inheritdoc />
        public NodeDeactivationIntent EffectiveIntent => Item.EffectiveIntent;

        /// <inheritdoc />
        public NodeDeactivationStatus Status => Item.Status;

        /// <inheritdoc />
        public IList<INodeDeactivationTask> Tasks { get; }

        /// <inheritdoc />
        public IList<ISafetyCheck> PendingSafetyChecks { get; }

        public NodeDeactivationResultWrapper(NodeDeactivationResult item)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
            Tasks = new NodeDeactivationTaskListWrapper(Item.Tasks);
            PendingSafetyChecks = new SafetyCheckListWrapper(Item.PendingSafetyChecks);
        }

        public static bool operator == (NodeDeactivationResultWrapper value1, NodeDeactivationResultWrapper value2)
        {
            // ReSharper disable RedundantCast
            if ((object)value1 == (object)value2) return true;
            return (object)value1 != null && (object)value2 != null && value1.Item == value2.Item;
            // ReSharper enable RedundantCast
        }

        public static bool operator != (NodeDeactivationResultWrapper value1, NodeDeactivationResultWrapper value2)
        {
            return !(value1 == value2);
        }

        public override bool Equals(object obj)
        {
            if (obj is NodeDeactivationResultWrapper wrapper)
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