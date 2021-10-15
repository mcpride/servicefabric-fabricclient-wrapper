// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;

namespace MS.Extensions.Fabric
{
    internal class NamedPropertyWrapper : INamedProperty
    {
        internal readonly NamedProperty Item;
        public INamedPropertyMetadata Metadata { get; }

        public NamedPropertyWrapper(NamedProperty item)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
            if (Item.Metadata != null)
            {
                Metadata = new NamedPropertyMetadataWrapper(Item.Metadata);
            }
        }

        public T GetValue<T>()
        {
            return Item.GetValue<T>();
        }

        public override bool Equals(object obj)
        {
            if (obj is NamedPropertyWrapper wrapper)
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