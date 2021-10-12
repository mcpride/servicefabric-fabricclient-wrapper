// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;
using System.Fabric.Query;

namespace MS.Extensions.Fabric.Query
{
    internal class NodeDeactivationTaskWrapper : INodeDeactivationTask
    {
        internal readonly NodeDeactivationTask Item;

        /// <inheritdoc />
        public INodeDeactivationTaskId TaskId => new NodeDeactivationTaskIdWrapper(Item.TaskId);

        /// <inheritdoc />
        public NodeDeactivationIntent Intent => Item.Intent;

        public NodeDeactivationTaskWrapper(NodeDeactivationTask item)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
        }

        public static bool operator == (NodeDeactivationTaskWrapper value1, NodeDeactivationTaskWrapper value2)
        {
            // ReSharper disable RedundantCast
            if ((object)value1 == (object)value2) return true;
            return (object)value1 != null && (object)value2 != null && value1.Item == value2.Item;
            // ReSharper restore RedundantCast
        }

        public static bool operator != (NodeDeactivationTaskWrapper value1, NodeDeactivationTaskWrapper value2)
        {
            return !(value1 == value2);
        }

        public override bool Equals(object obj)
        {
            if (obj is NodeDeactivationTaskWrapper wrapper)
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