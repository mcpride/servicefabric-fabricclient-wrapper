// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric.Health;
using System.Fabric.Query;

namespace MS.Extensions.Fabric.Query
{
    /// <inheritdoc />
    internal class PartitionWrapper : IPartition
    {
        internal readonly Partition Item;

        /// <inheritdoc />
        public ServiceKind ServiceKind => Item.ServiceKind;

        /// <inheritdoc />
        public HealthState HealthState => Item.HealthState;

        /// <inheritdoc />
        public IServicePartitionInformation PartitionInformation =>
            new ServicePartitionInformationWrapper(Item.PartitionInformation);

        /// <inheritdoc />
        public ServicePartitionStatus PartitionStatus => Item.PartitionStatus;

        public PartitionWrapper(Partition item)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
        }

        public static bool operator ==(PartitionWrapper value1, PartitionWrapper value2)
        {
            // ReSharper disable RedundantCast
            if ((object)value1 == (object)value2) return true;
            return (object)value1 != null && (object)value2 != null && value1.Item == value2.Item;
            // ReSharper restore RedundantCast
        }

        public static bool operator !=(PartitionWrapper value1, PartitionWrapper value2)
        {
            return !(value1 == value2);
        }

        public override bool Equals(object obj)
        {
            if (obj is PartitionWrapper wrapper)
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