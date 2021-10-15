// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Collections;
using System.Collections.Generic;
using System.Fabric;
using System.Linq;

namespace MS.Extensions.Fabric
{
    public class PropertyEnumerationResultWrapper : IPropertyEnumerationResult
    {
        internal readonly PropertyEnumerationResult Result;

        public bool HasMoreData => Result?.HasMoreData ?? true;
        public bool IsFinished => Result?.IsFinished ?? true;
        public bool IsBestEffort => Result?.IsBestEffort ?? false;
        public bool IsConsistent => Result?.IsConsistent ?? true;
        public bool IsValid => Result?.IsValid ?? false;
        public int Count => Result?.Count ?? 0;
        public bool IsReadOnly => true;

        public PropertyEnumerationResultWrapper(PropertyEnumerationResult result)
        {
            Result = result;
        }

        public IEnumerator<INamedProperty> GetEnumerator()
        {
            var list = new List<INamedProperty>();
            if (Result != null)
            {
                list.AddRange(Result.Select(item => new NamedPropertyWrapper(item)).Cast<INamedProperty>());
            }
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(INamedProperty item)
        {
            Result?.Add(Unwrap(item));
        }

        public void Clear()
        {
            Result?.Clear();
        }

        public bool Contains(INamedProperty item)
        {
            return Result != null && Result.Contains(Unwrap(item));
        }

        public void CopyTo(INamedProperty[] array, int arrayIndex)
        {
            if (Result == null) return;
            Result.CopyTo(array.Select(Unwrap).ToArray(), arrayIndex);
        }

        public bool Remove(INamedProperty item)
        {
            if (Result == null) return false;
            return Result.Remove(Unwrap(item));
        }

        private static NamedProperty Unwrap(INamedProperty item)
        {
            var wrapper = item.Unwrap<INamedProperty, NamedPropertyWrapper>();
            return wrapper.Item;
        }
    }
}