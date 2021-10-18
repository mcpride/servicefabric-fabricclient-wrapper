// MIT License
// Copyright (c) 2021 Marco Stolze

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Fabric.Description;

namespace MS.Extensions.Fabric.Description
{
    public interface IServiceTypeDescription
    {
        string ServiceTypeName { get; set; }
        ServiceDescriptionKind ServiceTypeKind { get; set; }
        string PlacementConstraints { get; set; }
        KeyedCollection<string, ServiceLoadMetricDescription> LoadMetrics { get; }
        IDictionary<string, string> Extensions { get; }
        IList<ServicePlacementPolicyDescription> Policies { get; set; }
    }
}