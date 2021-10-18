// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Collections.Generic;
using System.Fabric.Description;
using System.Fabric.Query;

namespace MS.Extensions.Fabric.Query
{

    internal class ServiceGroupMemberTypeWrapper : IServiceGroupMemberType
    {
        internal readonly ServiceGroupMemberType Item;

        /// <inheritdoc />
        public ICollection<ServiceGroupTypeMemberDescription> ServiceGroupMemberTypeDescription => Item.ServiceGroupMemberTypeDescription;

        /// <inheritdoc />
        public string ServiceManifestVersion => Item.ServiceManifestVersion;

        /// <inheritdoc />
        public string ServiceManifestName => Item.ServiceManifestName;

        public ServiceGroupMemberTypeWrapper(ServiceGroupMemberType item)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
        }

        public static bool operator == (ServiceGroupMemberTypeWrapper value1, ServiceGroupMemberTypeWrapper value2)
        {
            // ReSharper disable RedundantCast
            if ((object)value1 == (object)value2) return true;
            return (object)value1 != null && (object)value2 != null && value1.Item == value2.Item;
            // ReSharper restore RedundantCast
        }

        public static bool operator != (ServiceGroupMemberTypeWrapper value1, ServiceGroupMemberTypeWrapper value2)
        {
            return !(value1 == value2);
        }

        public override bool Equals(object obj)
        {
            if (obj is ServiceGroupMemberTypeWrapper wrapper)
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
