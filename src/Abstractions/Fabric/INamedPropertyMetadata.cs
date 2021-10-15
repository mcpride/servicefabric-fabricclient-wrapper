// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;

namespace MS.Extensions.Fabric
{
    public interface INamedPropertyMetadata
    {
        string PropertyName { get; }
        Uri Parent { get; }
        PropertyTypeId TypeId { get; }
        int ValueSize { get; }
        long SequenceNumber { get; }
        DateTime LastModifiedUtc { get; }
        string CustomTypeId { get; }
    }
}