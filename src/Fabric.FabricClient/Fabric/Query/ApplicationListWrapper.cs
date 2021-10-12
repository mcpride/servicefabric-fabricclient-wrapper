// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Collections;
using System.Collections.Generic;
using System.Fabric.Query;
using System.Linq;

namespace MS.Extensions.Fabric.Query
{
    internal class ApplicationListWrapper : IApplicationList
    {
        private readonly ApplicationList _items;

        public IApplication this[int index]
        {
            get => new ApplicationWrapper(_items[index]);
            set => _items[index] = value.Unwrap<IApplication, ApplicationWrapper>().Item;
        }

        public string ContinuationToken
        {
            get => _items.ContinuationToken;
            set => _items.ContinuationToken = value;
        }

        public int Count => _items.Count;

        public bool IsReadOnly => _items.IsReadOnly;

        public ApplicationListWrapper(ApplicationList items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
        }

        public IEnumerator<IApplication> GetEnumerator()
        {
            foreach (var item in _items)
            {
                yield return new ApplicationWrapper(item);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(IApplication item)
        {
            _items.Add(item.Unwrap<IApplication, ApplicationWrapper>().Item);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public bool Contains(IApplication item)
        {
            return _items.Contains(item.Unwrap<IApplication, ApplicationWrapper>().Item);
        }

        public void CopyTo(IApplication[] array, int arrayIndex)
        {
            _items.CopyTo(
                array.Select(item => item.Unwrap<IApplication, ApplicationWrapper>().Item).ToArray(), 
                arrayIndex);
        }

        public bool Remove(IApplication item)
        {
            return _items.Remove(item.Unwrap<IApplication, ApplicationWrapper>().Item);
        }

        public int IndexOf(IApplication item)
        {
            return _items.IndexOf(item.Unwrap<IApplication, ApplicationWrapper>().Item);
        }

        public void Insert(int index, IApplication item)
        {
            _items.Insert(index, item.Unwrap<IApplication, ApplicationWrapper>().Item);
        }

        public void RemoveAt(int index)
        {
            _items.RemoveAt(index);
        }
    }
}