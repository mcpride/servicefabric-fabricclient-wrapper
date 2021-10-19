// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Collections;
using System.Collections.Generic;
using System.Fabric.Query;
using System.Linq;
using MS.Extensions.Tools;

namespace MS.Extensions.Fabric.Query
{
    internal class ServiceListWrapper : IServiceList
    {
        private readonly ServiceList _items;

        /// <inheritdoc />
        public IService this[int index]
        {
            get => new ServiceWrapper(_items[index]);
            set => _items[index] = value.UnwrapTo<ServiceWrapper>().Item;
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

        public ServiceListWrapper(ServiceList items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
        }

        /// <inheritdoc />
        public IEnumerator<IService> GetEnumerator()
        {
            foreach (var item in _items)
            {
                yield return new ServiceWrapper(item);
            }
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc />
        public void Add(IService item)
        {
            _items.Add(item.UnwrapTo<ServiceWrapper>().Item);
        }

        /// <inheritdoc />
        public void Clear()
        {
            _items.Clear();
        }

        /// <inheritdoc />
        public bool Contains(IService item)
        {
            return _items.Contains(item.UnwrapTo<ServiceWrapper>().Item);
        }

        /// <inheritdoc />
        public void CopyTo(IService[] array, int arrayIndex)
        {
            _items.CopyTo(array.Select(item => item.UnwrapTo<ServiceWrapper>()
                    .Item).ToArray(),
                arrayIndex);
        }

        /// <inheritdoc />
        public bool Remove(IService item)
        {
            return _items.Remove(item.UnwrapTo<ServiceWrapper>().Item);
        }

        /// <inheritdoc />
        public int IndexOf(IService item)
        {
            return _items.IndexOf(item.UnwrapTo<ServiceWrapper>().Item);
        }

        /// <inheritdoc />
        public void Insert(int index, IService item)
        {
            _items.Insert(index, item.UnwrapTo<ServiceWrapper>().Item);
        }

        /// <inheritdoc />
        public void RemoveAt(int index)
        {
            _items.RemoveAt(index);
        }
    }
}