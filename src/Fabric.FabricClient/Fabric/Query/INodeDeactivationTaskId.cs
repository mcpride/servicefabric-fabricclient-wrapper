// MIT License
// Copyright (c) 2021 Marco Stolze

using System.Fabric;

namespace MS.Extensions.Fabric.Query
{
    public interface INodeDeactivationTaskId
    {
        string Id { get; }
        NodeDeactivationTaskType Type { get; }
    }
}
