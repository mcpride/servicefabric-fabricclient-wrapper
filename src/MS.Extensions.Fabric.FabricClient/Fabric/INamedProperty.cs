// MIT License
// Copyright (c) 2021 Marco Stolze

namespace MS.Extensions.Fabric
{
    public interface INamedProperty
    {
        INamedPropertyMetadata Metadata { get; }
        T GetValue<T>();
    }
}