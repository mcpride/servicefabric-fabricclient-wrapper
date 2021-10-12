// MIT License
// Copyright (c) 2021 Marco Stolze

using System.Collections.Generic;
using System.Fabric;

namespace MS.Extensions.Fabric.Query
{
    public interface INodeDeactivationResult
    {
        NodeDeactivationIntent EffectiveIntent { get; }
        NodeDeactivationStatus Status { get; }
        IList<INodeDeactivationTask> Tasks { get; }
        IList<ISafetyCheck> PendingSafetyChecks { get; }
    }
}
