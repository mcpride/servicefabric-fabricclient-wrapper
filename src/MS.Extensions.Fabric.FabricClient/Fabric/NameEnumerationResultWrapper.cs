// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Collections;
using System.Collections.Generic;
using System.Fabric;

namespace MS.Extensions.Fabric
{
    public class NameEnumerationResultWrapper : INameEnumerationResult
    {
        internal readonly NameEnumerationResult Result;

        public bool HasMoreData => Result?.HasMoreData ?? true;
        public bool IsFinished => Result?.IsFinished ?? true;
        public bool IsBestEffort => Result?.IsBestEffort ?? false;
        public bool IsConsistent => Result?.IsConsistent ?? true;
        public bool IsValid => Result?.IsValid ?? false;
        public int Count => Result?.Count ?? 0;
        public bool IsReadOnly => true;

        public NameEnumerationResultWrapper(NameEnumerationResult result)
        {
            Result = result;
        }

        public IEnumerator<Uri> GetEnumerator()
        {
            return Result == null ? new List<Uri>().GetEnumerator() : Result.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Result == null ? new List<Uri>().GetEnumerator() : Result.GetEnumerator();
        }

        public void Add(Uri item)
        {
            if (Result == null) throw new InvalidOperationException("NameEnumerationResult not assigned!");
            Result.Add(item);
        }

        public void Clear()
        {
            Result?.Clear();
        }

        public bool Contains(Uri item)
        {
            return Result?.Contains(item) ?? false;
        }

        public void CopyTo(Uri[] array, int arrayIndex)
        {
            if (Result == null) throw new InvalidOperationException("NameEnumerationResult not assigned!");
            Result.CopyTo(array, arrayIndex);
        }

        public bool Remove(Uri item)
        {
            return Result != null && Result.Remove(item);
        }
    }
}