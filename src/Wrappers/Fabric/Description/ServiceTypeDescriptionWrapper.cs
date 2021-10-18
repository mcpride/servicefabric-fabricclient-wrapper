// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Fabric.Description;

namespace MS.Extensions.Fabric.Description
{
    /// <inheritdoc />
    internal class ServiceTypeDescriptionWrapper : IServiceTypeDescription
    {
        internal readonly ServiceTypeDescription Item;

        /// <inheritdoc />
        public string ServiceTypeName
        {
            get => Item.ServiceTypeName;
            set => Item.ServiceTypeName = value;
        }

        /// <inheritdoc />
        public ServiceDescriptionKind ServiceTypeKind
        {
            get => Item.ServiceTypeKind;
            set => Item.ServiceTypeKind = value;
        }

        /// <inheritdoc />
        public string PlacementConstraints
        {
            get => Item.PlacementConstraints;
            set => Item.PlacementConstraints = value;
        }

        /// <inheritdoc />
        public KeyedCollection<string, ServiceLoadMetricDescription> LoadMetrics => Item.LoadMetrics;

        /// <inheritdoc />
        public IDictionary<string, string> Extensions => Item.Extensions;

        /// <inheritdoc />
        public IList<ServicePlacementPolicyDescription> Policies
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public ServiceTypeDescriptionWrapper(ServiceTypeDescription item)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
        }

        public static bool operator ==(ServiceTypeDescriptionWrapper value1, ServiceTypeDescriptionWrapper value2)
        {
            // ReSharper disable RedundantCast
            if ((object)value1 == (object)value2) return true;
            return (object)value1 != null && (object)value2 != null && value1.Item == value2.Item;
            // ReSharper restore RedundantCast
        }

        public static bool operator !=(ServiceTypeDescriptionWrapper value1, ServiceTypeDescriptionWrapper value2)
        {
            return !(value1 == value2);
        }

        public override bool Equals(object obj)
        {
            if (obj is ServiceTypeDescriptionWrapper wrapper)
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
