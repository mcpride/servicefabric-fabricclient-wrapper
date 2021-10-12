// MIT License
// Copyright (c) 2021 Marco Stolze

using System.Fabric;

namespace MS.Extensions.Fabric
{
    public interface ISafetyCheck
    {
        SafetyCheckKind Kind { get; }
    }
}
