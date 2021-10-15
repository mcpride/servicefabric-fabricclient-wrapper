// MIT License
// Copyright (c) 2021 Marco Stolze

using System.Fabric;

namespace MS.Extensions.Fabric.Query
{
    public interface INodeDeactivationTask
    {
        INodeDeactivationTaskId TaskId { get; }
        NodeDeactivationIntent Intent { get; }
    }
}