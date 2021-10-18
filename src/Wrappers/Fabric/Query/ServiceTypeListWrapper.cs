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

    internal class ServiceTypeListWrapper : IServiceTypeList
    {
        private readonly ServiceTypeList _items;

        /// <inheritdoc />
        public int Count => _items.Count;

        /// <inheritdoc />
        public bool IsReadOnly => _items.IsReadOnly;

        /// <inheritdoc />
        public IServiceType this[int index]
        {
            get => new ServiceTypeWrapper(_items[index]);
            set => _items[index] = value.Unwrap<IServiceType, ServiceTypeWrapper>().Item;
        }

        public ServiceTypeListWrapper(ServiceTypeList items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
        }

        /// <inheritdoc />
        public IEnumerator<IServiceType> GetEnumerator()
        {
            foreach (var item in _items)
            {
                yield return new ServiceTypeWrapper(item);
            }
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc />
        public void Add(IServiceType item)
        {
            _items.Add(item.Unwrap<IServiceType, ServiceTypeWrapper>().Item);
        }

        /// <inheritdoc />
        public void Clear()
        {
            _items.Clear();
        }

        /// <inheritdoc />
        public bool Contains(IServiceType item)
        {
            return _items.Contains(item.Unwrap<IServiceType, ServiceTypeWrapper>().Item);
        }

        /// <inheritdoc />
        public void CopyTo(IServiceType[] array, int arrayIndex)
        {
            _items.CopyTo(array.Select(item => item.Unwrap<IServiceType, ServiceTypeWrapper>()
                    .Item).ToArray(),
                arrayIndex);
        }

        /// <inheritdoc />
        public bool Remove(IServiceType item)
        {
            return _items.Remove(item.Unwrap<IServiceType, ServiceTypeWrapper>().Item);
        }

        /// <inheritdoc />
        public int IndexOf(IServiceType item)
        {
            return _items.IndexOf(item.Unwrap<IServiceType, ServiceTypeWrapper>().Item);
        }

        /// <inheritdoc />
        public void Insert(int index, IServiceType item)
        {
            _items.Insert(index, item.Unwrap<IServiceType, ServiceTypeWrapper>().Item);
        }

        /// <inheritdoc />
        public void RemoveAt(int index)
        {
            _items.RemoveAt(index);
        }
    }
}