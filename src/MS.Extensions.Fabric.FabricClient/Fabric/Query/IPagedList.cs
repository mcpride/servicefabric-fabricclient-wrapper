// MIT License
// Copyright (c) 2021 Marco Stolze

using System.Collections;
using System.Collections.Generic;

namespace MS.Extensions.Fabric.Query
{
    public interface IPagedList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
    {
        string ContinuationToken { get; set; }
    }
}