// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;

namespace MS.Extensions.Fabric
{
    /// <inheritdoc />
    internal class ServicePartitionInformationWrapper : IServicePartitionInformation
    {
        internal readonly ServicePartitionInformation Item;

        /// <inheritdoc />
        public Guid Id => Item.Id;

        /// <inheritdoc />
        public ServicePartitionKind Kind => Item.Kind;

        public ServicePartitionInformationWrapper(ServicePartitionInformation item)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
        }

        public static bool operator == (ServicePartitionInformationWrapper value1, ServicePartitionInformationWrapper value2)
        {
            // ReSharper disable RedundantCast
            if ((object)value1 == (object)value2) return true;
            return (object)value1 != null && (object)value2 != null && value1.Item == value2.Item;
            // ReSharper restore RedundantCast
        }

        public static bool operator != (ServicePartitionInformationWrapper value1, ServicePartitionInformationWrapper value2)
        {
            return !(value1 == value2);
        }

        public override bool Equals(object obj)
        {
            if (obj is ServicePartitionInformationWrapper wrapper)
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
