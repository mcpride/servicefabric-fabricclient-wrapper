// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;

namespace MS.Extensions.Fabric
{
    internal class NamedPropertyMetadataWrapper : INamedPropertyMetadata
    {
        private readonly NamedPropertyMetadata _namedPropertyMetadata;

        public string PropertyName => _namedPropertyMetadata.PropertyName;

        public Uri Parent => _namedPropertyMetadata.Parent;
        public PropertyTypeId TypeId => _namedPropertyMetadata.TypeId;
        public int ValueSize => _namedPropertyMetadata.ValueSize;
        public long SequenceNumber => _namedPropertyMetadata.SequenceNumber;
        public DateTime LastModifiedUtc => _namedPropertyMetadata.LastModifiedUtc;
        public string CustomTypeId => _namedPropertyMetadata.CustomTypeId;

        public NamedPropertyMetadataWrapper(NamedPropertyMetadata namedPropertyMetadata)
        {
            _namedPropertyMetadata = namedPropertyMetadata ?? throw new ArgumentNullException(nameof(namedPropertyMetadata));
        }
    }
}