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
    internal class ServiceGroupMemberListWrapper : IServiceGroupMemberList
    {
        private readonly ServiceGroupMemberList _items;

        /// <inheritdoc />
        public int Count => _items.Count;

        /// <inheritdoc />
        public bool IsReadOnly => _items.IsReadOnly;

        /// <inheritdoc />
        public IServiceGroupMember this[int index]
        {
            get => new ServiceGroupMemberWrapper(_items[index]);
            set => _items[index] = value.UnwrapTo<ServiceGroupMemberWrapper>().Item;
        }

        public ServiceGroupMemberListWrapper(ServiceGroupMemberList items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
        }

        /// <inheritdoc />
        public IEnumerator<IServiceGroupMember> GetEnumerator()
        {
            foreach (var item in _items)
            {
                yield return new ServiceGroupMemberWrapper(item);
            }
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc />
        public void Add(IServiceGroupMember item)
        {
            _items.Add(item.UnwrapTo<ServiceGroupMemberWrapper>().Item);
        }

        /// <inheritdoc />
        public void Clear()
        {
            _items.Clear();
        }

        /// <inheritdoc />
        public bool Contains(IServiceGroupMember item)
        {
            return _items.Contains(item.UnwrapTo<ServiceGroupMemberWrapper>().Item);
        }

        /// <inheritdoc />
        public void CopyTo(IServiceGroupMember[] array, int arrayIndex)
        {
            _items.CopyTo(array.Select(item => item.UnwrapTo<ServiceGroupMemberWrapper>()
                    .Item).ToArray(),
                arrayIndex);
        }

        /// <inheritdoc />
        public bool Remove(IServiceGroupMember item)
        {
            return _items.Remove(item.UnwrapTo<ServiceGroupMemberWrapper>().Item);
        }

        /// <inheritdoc />
        public int IndexOf(IServiceGroupMember item)
        {
            return _items.IndexOf(item.UnwrapTo<ServiceGroupMemberWrapper>().Item);
        }

        /// <inheritdoc />
        public void Insert(int index, IServiceGroupMember item)
        {
            _items.Insert(index, item.UnwrapTo<ServiceGroupMemberWrapper>().Item);
        }

        /// <inheritdoc />
        public void RemoveAt(int index)
        {
            _items.RemoveAt(index);
        }
    }
}