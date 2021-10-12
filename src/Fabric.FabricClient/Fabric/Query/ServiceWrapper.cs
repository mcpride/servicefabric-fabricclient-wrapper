// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric.Health;
using System.Fabric.Query;

namespace MS.Extensions.Fabric.Query
{
    internal class ServiceWrapper : IService
    {
        internal readonly Service Item;

        /// <inheritdoc />
        public ServiceKind ServiceKind => Item.ServiceKind;

        /// <inheritdoc />
        public Uri ServiceName => Item.ServiceName;

        /// <inheritdoc />
        public string ServiceTypeName => Item.ServiceTypeName;

        /// <inheritdoc />
        public string ServiceManifestVersion => Item.ServiceManifestVersion;

        /// <inheritdoc />
        public HealthState HealthState => Item.HealthState;

        /// <inheritdoc />
        public ServiceStatus ServiceStatus => Item.ServiceStatus;

        /// <inheritdoc />
        public bool IsServiceGroup => Item.IsServiceGroup;

        public ServiceWrapper(Service item)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
        }

        public static bool operator ==(ServiceWrapper value1, ServiceWrapper value2)
        {
            // ReSharper disable RedundantCast
            if ((object)value1 == (object)value2) return true;
            return (object)value1 != null && (object)value2 != null && value1.Item == value2.Item;
            // ReSharper restore RedundantCast
        }

        public static bool operator !=(ServiceWrapper value1, ServiceWrapper value2)
        {
            return !(value1 == value2);
        }

        public override bool Equals(object obj)
        {
            if (obj is ServiceWrapper wrapper)
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