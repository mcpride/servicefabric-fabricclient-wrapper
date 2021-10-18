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
    /// <inheritdoc />
    internal class ServiceGroupMemberTypeListWrapper : IServiceGroupMemberTypeList
    {
        private readonly ServiceGroupMemberTypeList _items;

        /// <inheritdoc />
        public int Count => _items.Count;

        /// <inheritdoc />
        public bool IsReadOnly => _items.IsReadOnly;

        /// <inheritdoc />
        public IServiceGroupMemberType this[int index]
        {
            get => new ServiceGroupMemberTypeWrapper(_items[index]);
            set => _items[index] = value.Unwrap<IServiceGroupMemberType, ServiceGroupMemberTypeWrapper>().Item;
        }

        public ServiceGroupMemberTypeListWrapper(ServiceGroupMemberTypeList items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
        }

        /// <inheritdoc />
        public IEnumerator<IServiceGroupMemberType> GetEnumerator()
        {
            foreach (var item in _items)
            {
                yield return new ServiceGroupMemberTypeWrapper(item);
            }
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc />
        public void Add(IServiceGroupMemberType item)
        {
            _items.Add(item.Unwrap<IServiceGroupMemberType, ServiceGroupMemberTypeWrapper>().Item);
        }

        /// <inheritdoc />
        public void Clear()
        {
            _items.Clear();
        }

        /// <inheritdoc />
        public bool Contains(IServiceGroupMemberType item)
        {
            return _items.Contains(item.Unwrap<IServiceGroupMemberType, ServiceGroupMemberTypeWrapper>().Item);
        }

        /// <inheritdoc />
        public void CopyTo(IServiceGroupMemberType[] array, int arrayIndex)
        {
            _items.CopyTo(array.Select(item => item.Unwrap<IServiceGroupMemberType, ServiceGroupMemberTypeWrapper>()
                    .Item).ToArray(),
                arrayIndex);
        }

        /// <inheritdoc />
        public bool Remove(IServiceGroupMemberType item)
        {
            return _items.Remove(item.Unwrap<IServiceGroupMemberType, ServiceGroupMemberTypeWrapper>().Item);
        }

        /// <inheritdoc />
        public int IndexOf(IServiceGroupMemberType item)
        {
            return _items.IndexOf(item.Unwrap<IServiceGroupMemberType, ServiceGroupMemberTypeWrapper>().Item);
        }

        /// <inheritdoc />
        public void Insert(int index, IServiceGroupMemberType item)
        {
            _items.Insert(index, item.Unwrap<IServiceGroupMemberType, ServiceGroupMemberTypeWrapper>().Item);
        }

        /// <inheritdoc />
        public void RemoveAt(int index)
        {
            _items.RemoveAt(index);
        }
    }
}