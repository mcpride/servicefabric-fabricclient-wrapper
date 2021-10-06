// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;

namespace MS.Extensions.Fabric
{
    internal class NamedPropertyWrapper : INamedProperty
    {
        internal readonly NamedProperty NamedProperty;
        public INamedPropertyMetadata Metadata { get; }

        public NamedPropertyWrapper(NamedProperty namedProperty)
        {
            NamedProperty = namedProperty ?? throw new ArgumentNullException(nameof(namedProperty));
            if (NamedProperty.Metadata != null)
            {
                Metadata = new NamedPropertyMetadataWrapper(NamedProperty.Metadata);
            }
        }

        public T GetValue<T>()
        {
            return NamedProperty.GetValue<T>();
        }

        public override bool Equals(object obj)
        {
            if (obj is NamedPropertyWrapper wrapper)
            {
                return NamedProperty.Equals(wrapper.NamedProperty);
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return NamedProperty.GetHashCode();
        }

        public override string ToString()
        {
            return NamedProperty.ToString();
        }
    }
}