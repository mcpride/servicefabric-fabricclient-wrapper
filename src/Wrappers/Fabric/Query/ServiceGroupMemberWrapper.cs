// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric.Query;

namespace MS.Extensions.Fabric.Query
{

    internal class ServiceGroupMemberWrapper : IServiceGroupMember
    {
        internal readonly ServiceGroupMember Item;

        /// <inheritdoc />
        public Uri ServiceName => Item.ServiceName;

        /// <inheritdoc />
        public IServiceGroupMemberMemberList ServiceGroupMemberMembers => Item.ServiceGroupMemberMembers == null ? null : new ServiceGroupMemberMemberListWrapper(Item.ServiceGroupMemberMembers);

        public ServiceGroupMemberWrapper(ServiceGroupMember item)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
        }

        public static bool operator ==(ServiceGroupMemberWrapper value1, ServiceGroupMemberWrapper value2)
        {
            // ReSharper disable RedundantCast
            if ((object)value1 == (object)value2) return true;
            return (object)value1 != null && (object)value2 != null && value1.Item == value2.Item;
            // ReSharper restore RedundantCast
        }

        public static bool operator !=(ServiceGroupMemberWrapper value1, ServiceGroupMemberWrapper value2)
        {
            return !(value1 == value2);
        }

        public override bool Equals(object obj)
        {
            if (obj is ServiceGroupMemberWrapper wrapper)
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