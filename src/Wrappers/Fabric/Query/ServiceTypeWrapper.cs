// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric.Query;
using MS.Extensions.Fabric.Description;

namespace MS.Extensions.Fabric.Query
{

    internal class ServiceTypeWrapper : IServiceType
    {
        internal readonly ServiceType Item;

        /// <inheritdoc />
        public IServiceTypeDescription ServiceTypeDescription => Item.ServiceTypeDescription == null ? null : new ServiceTypeDescriptionWrapper(Item.ServiceTypeDescription);

        /// <inheritdoc />
        public string ServiceManifestVersion => Item.ServiceManifestVersion;

        /// <inheritdoc />
        public string ServiceManifestName => Item.ServiceManifestName;

        /// <inheritdoc />
        public bool IsServiceGroup => Item.IsServiceGroup;

        public ServiceTypeWrapper(ServiceType item)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
        }

        public static bool operator == (ServiceTypeWrapper value1, ServiceTypeWrapper value2)
        {
            // ReSharper disable RedundantCast
            if ((object)value1 == (object)value2) return true;
            return (object)value1 != null && (object)value2 != null && value1.Item == value2.Item;
            // ReSharper restore RedundantCast
        }

        public static bool operator != (ServiceTypeWrapper value1, ServiceTypeWrapper value2)
        {
            return !(value1 == value2);
        }

        public override bool Equals(object obj)
        {
            if (obj is ServiceTypeWrapper wrapper)
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