// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;
using System.Fabric.Query;

namespace MS.Extensions.Fabric.Query
{
    internal class NodeDeactivationTaskIdWrapper : INodeDeactivationTaskId
    {
        internal readonly NodeDeactivationTaskId Item;

        /// <inheritdoc />
        public string Id => Item.Id;

        /// <inheritdoc />
        public NodeDeactivationTaskType Type => Item.Type;

        public NodeDeactivationTaskIdWrapper(NodeDeactivationTaskId item)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
        }

        public static bool operator == (NodeDeactivationTaskIdWrapper value1, NodeDeactivationTaskIdWrapper value2)
        {
            // ReSharper disable RedundantCast
            if ((object)value1 == (object)value2) return true;
            return (object)value1 != null && (object)value2 != null && value1.Item == value2.Item;
            // ReSharper restore RedundantCast
        }

        public static bool operator != (NodeDeactivationTaskIdWrapper value1, NodeDeactivationTaskIdWrapper value2)
        {
            return !(value1 == value2);
        }

        public override bool Equals(object obj)
        {
            if (obj is NodeDeactivationTaskIdWrapper wrapper)
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