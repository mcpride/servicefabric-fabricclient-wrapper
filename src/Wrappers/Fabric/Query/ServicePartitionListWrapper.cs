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
    internal class ServicePartitionListWrapper : IServicePartitionList
    {
        private readonly ServicePartitionList _items;

        /// <inheritdoc />
        public IPartition this[int index]
        {
            get => new PartitionWrapper(_items[index]);
            set => _items[index] = value.Unwrap<IPartition, PartitionWrapper>().Item;
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

        public ServicePartitionListWrapper(ServicePartitionList items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
        }

        /// <inheritdoc />
        public IEnumerator<IPartition> GetEnumerator()
        {
            foreach (var item in _items)
            {
                yield return new PartitionWrapper(item);
            }
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc />
        public void Add(IPartition item)
        {
            _items.Add(item.Unwrap<IPartition, PartitionWrapper>().Item);
        }

        /// <inheritdoc />
        public void Clear()
        {
            _items.Clear();
        }

        /// <inheritdoc />
        public bool Contains(IPartition item)
        {
            return _items.Contains(item.Unwrap<IPartition, PartitionWrapper>().Item);
        }

        /// <inheritdoc />
        public void CopyTo(IPartition[] array, int arrayIndex)
        {
            _items.CopyTo(array.Select(item => item.Unwrap<IPartition, PartitionWrapper>()
                    .Item).ToArray(),
                arrayIndex);
        }

        /// <inheritdoc />
        public bool Remove(IPartition item)
        {
            return _items.Remove(item.Unwrap<IPartition, PartitionWrapper>().Item);
        }

        /// <inheritdoc />
        public int IndexOf(IPartition item)
        {
            return _items.IndexOf(item.Unwrap<IPartition, PartitionWrapper>().Item);
        }

        /// <inheritdoc />
        public void Insert(int index, IPartition item)
        {
            _items.Insert(index, item.Unwrap<IPartition, PartitionWrapper>().Item);
        }

        /// <inheritdoc />
        public void RemoveAt(int index)
        {
            _items.RemoveAt(index);
        }
    }
}