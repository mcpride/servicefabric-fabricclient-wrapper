// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Collections;
using System.Collections.Generic;
using System.Fabric.Query;
using System.Linq;

namespace MS.Extensions.Fabric.Query
{
    /// <inheritdoc />
    internal class ApplicationTypePagedListWrapper : IApplicationTypePagedList
    {
        private readonly ApplicationTypePagedList _items;

        /// <inheritdoc />
        public IApplicationType this[int index]
        {
            get => new ApplicationTypeWrapper(_items[index]);
            set => _items[index] = value.Unwrap<IApplicationType, ApplicationTypeWrapper>().Item;
        }

        /// <inheritdoc />
        public string ContinuationToken
        {
            get => _items.ContinuationToken;
            set => _items.ContinuationToken = value;
        }

        /// <inheritdoc />
        public int Count => _items.Count;

        /// <inheritdoc />
        public bool IsReadOnly => _items.IsReadOnly;

        public ApplicationTypePagedListWrapper(ApplicationTypePagedList items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
        }

        /// <inheritdoc />
        public IEnumerator<IApplicationType> GetEnumerator()
        {
            foreach (var item in _items)
            {
                yield return new ApplicationTypeWrapper(item);
            }
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc />
        public void Add(IApplicationType item)
        {
            _items.Add(item.Unwrap<IApplicationType, ApplicationTypeWrapper>().Item);
        }

        /// <inheritdoc />
        public void Clear()
        {
            _items.Clear();
        }

        /// <inheritdoc />
        public bool Contains(IApplicationType item)
        {
            return _items.Contains(item.Unwrap<IApplicationType, ApplicationTypeWrapper>().Item);
        }

        /// <inheritdoc />
        public void CopyTo(IApplicationType[] array, int arrayIndex)
        {
            _items.CopyTo(array.Select(item => item.Unwrap<IApplicationType, ApplicationTypeWrapper>()
                    .Item).ToArray(),
                arrayIndex);
        }

        /// <inheritdoc />
        public bool Remove(IApplicationType item)
        {
            return _items.Remove(item.Unwrap<IApplicationType, ApplicationTypeWrapper>().Item);
        }

        /// <inheritdoc />
        public int IndexOf(IApplicationType item)
        {
            return _items.IndexOf(item.Unwrap<IApplicationType, ApplicationTypeWrapper>().Item);
        }

        /// <inheritdoc />
        public void Insert(int index, IApplicationType item)
        {
            _items.Insert(index, item.Unwrap<IApplicationType, ApplicationTypeWrapper>().Item);
        }

        /// <inheritdoc />
        public void RemoveAt(int index)
        {
            _items.RemoveAt(index);
        }
    }
}
