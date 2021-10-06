// MIT License
// Copyright (c) 2021 Marco Stolze

using System.Collections.Generic;

namespace MS.Extensions.Fabric
{
    public interface IPropertyEnumerationResult : ICollection<INamedProperty>
    {
        bool HasMoreData { get; }
        bool IsFinished { get; }
        bool IsBestEffort { get; }
        bool IsConsistent { get; }
        bool IsValid { get; }
    }
}