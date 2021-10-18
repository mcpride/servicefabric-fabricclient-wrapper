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
    internal class ServiceGroupMemberMemberListWrapper : IServiceGroupMemberMemberList
    {
        private readonly ServiceGroupMemberMemberList _items;

        /// <inheritdoc />
        public int Count => _items.Count;

        /// <inheritdoc />
        public bool IsReadOnly => _items.IsReadOnly;

        /// <inheritdoc />
        public IServiceGroupMemberMember this[int index]
        {
            get => new ServiceGroupMemberMemberWrapper(_items[index]);
            set => _items[index] = value.Unwrap<IServiceGroupMemberMember, ServiceGroupMemberMemberWrapper>().Item;
        }

        public ServiceGroupMemberMemberListWrapper(ServiceGroupMemberMemberList items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
        }

        /// <inheritdoc />
        public IEnumerator<IServiceGroupMemberMember> GetEnumerator()
        {
            foreach (var item in _items)
            {
                yield return new ServiceGroupMemberMemberWrapper(item);
            }
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc />
        public void Add(IServiceGroupMemberMember item)
        {
            _items.Add(item.Unwrap<IServiceGroupMemberMember, ServiceGroupMemberMemberWrapper>().Item);
        }

        /// <inheritdoc />
        public void Clear()
        {
            _items.Clear();
        }

        /// <inheritdoc />
        public bool Contains(IServiceGroupMemberMember item)
        {
            return _items.Contains(item.Unwrap<IServiceGroupMemberMember, ServiceGroupMemberMemberWrapper>().Item);
        }

        /// <inheritdoc />
        public void CopyTo(IServiceGroupMemberMember[] array, int arrayIndex)
        {
            _items.CopyTo(array.Select(item => item.Unwrap<IServiceGroupMemberMember, ServiceGroupMemberMemberWrapper>()
                    .Item).ToArray(),
                arrayIndex);
        }

        /// <inheritdoc />
        public bool Remove(IServiceGroupMemberMember item)
        {
            return _items.Remove(item.Unwrap<IServiceGroupMemberMember, ServiceGroupMemberMemberWrapper>().Item);
        }

        /// <inheritdoc />
        public int IndexOf(IServiceGroupMemberMember item)
        {
            return _items.IndexOf(item.Unwrap<IServiceGroupMemberMember, ServiceGroupMemberMemberWrapper>().Item);
        }

        /// <inheritdoc />
        public void Insert(int index, IServiceGroupMemberMember item)
        {
            _items.Insert(index, item.Unwrap<IServiceGroupMemberMember, ServiceGroupMemberMemberWrapper>().Item);
        }

        /// <inheritdoc />
        public void RemoveAt(int index)
        {
            _items.RemoveAt(index);
        }
    }
}
