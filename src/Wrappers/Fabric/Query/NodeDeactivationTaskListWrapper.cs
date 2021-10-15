// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Collections;
using System.Collections.Generic;
using System.Fabric.Query;
using System.Linq;

namespace MS.Extensions.Fabric.Query
{
    internal class NodeDeactivationTaskListWrapper : IList<INodeDeactivationTask>
    {
        private readonly IList<NodeDeactivationTask> _items;

        /// <inheritdoc />
        public int Count => _items.Count;

        /// <inheritdoc />
        public bool IsReadOnly => _items.IsReadOnly;

        /// <inheritdoc />
        public INodeDeactivationTask this[int index]
        {
            get => new NodeDeactivationTaskWrapper(_items[index]);
            set => _items[index] = value.Unwrap<INodeDeactivationTask, NodeDeactivationTaskWrapper>().Item;
        }

        public NodeDeactivationTaskListWrapper(IList<NodeDeactivationTask> items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
        }

        /// <inheritdoc />
        public IEnumerator<INodeDeactivationTask> GetEnumerator()
        {
            foreach (var item in _items)
            {
                yield return new NodeDeactivationTaskWrapper(item);
            }
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc />
        public void Add(INodeDeactivationTask item)
        {
            _items.Add(item.Unwrap<INodeDeactivationTask, NodeDeactivationTaskWrapper>()
                .Item);
        }

        /// <inheritdoc />
        public void Clear()
        {
            _items.Clear();
        }

        /// <inheritdoc />
        public bool Contains(INodeDeactivationTask item)
        {
            return _items.Contains(item.Unwrap<INodeDeactivationTask, NodeDeactivationTaskWrapper>()
                .Item);
        }

        /// <inheritdoc />
        public void CopyTo(INodeDeactivationTask[] array, int arrayIndex)
        {
            _items.CopyTo(
                array.Select(item => item.Unwrap<INodeDeactivationTask, NodeDeactivationTaskWrapper>()
                    .Item).ToArray(),
                arrayIndex);
        }

        /// <inheritdoc />
        public bool Remove(INodeDeactivationTask item)
        {
            return _items.Remove(item.Unwrap<INodeDeactivationTask, NodeDeactivationTaskWrapper>()
                .Item);
        }

        /// <inheritdoc />
        public int IndexOf(INodeDeactivationTask item)
        {
            return _items.IndexOf(item.Unwrap<INodeDeactivationTask, NodeDeactivationTaskWrapper>()
                .Item);
        }

        /// <inheritdoc />
        public void Insert(int index, INodeDeactivationTask item)
        {
            _items.Insert(index, item.Unwrap<INodeDeactivationTask, NodeDeactivationTaskWrapper>()
                .Item);
        }

        /// <inheritdoc />
        public void RemoveAt(int index)
        {
            _items.RemoveAt(index);
        }
    }
}