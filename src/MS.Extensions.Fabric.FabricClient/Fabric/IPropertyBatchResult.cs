// MIT License
// Copyright (c) 2021 Marco Stolze

using System;

namespace MS.Extensions.Fabric
{
    public interface IPropertyBatchResult
    {
        int FailedOperationIndex { get; }
        Exception FailedOperationException { get; }
        INamedProperty GetProperty(int index);
    }
}