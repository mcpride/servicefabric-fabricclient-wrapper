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
    internal class NodeListWrapper : INodeList
    {
        private readonly NodeList _items;

        /// <inheritdoc />
        public INode this[int index]
        {
            get => new NodeWrapper(_items[index]);
            set => _items[index] = value.UnwrapTo<NodeWrapper>().Item;
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

        public NodeListWrapper(NodeList items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
        }

        /// <inheritdoc />
        public IEnumerator<INode> GetEnumerator()
        {
            foreach (var item in _items)
            {
                yield return new NodeWrapper(item);
            }
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc />
        public void Add(INode item)
        {
            _items.Add(item.UnwrapTo<NodeWrapper>().Item);
        }

        /// <inheritdoc />
        public void Clear()
        {
            _items.Clear();
        }

        /// <inheritdoc />
        public bool Contains(INode item)
        {
            return _items.Contains(item.UnwrapTo<NodeWrapper>().Item);
        }

        /// <inheritdoc />
        public void CopyTo(INode[] array, int arrayIndex)
        {
            _items.CopyTo(array.Select(item => UnwrapHelper.UnwrapTo<NodeWrapper>(item)
                    .Item).ToArray(),
                arrayIndex);
        }

        /// <inheritdoc />
        public bool Remove(INode item)
        {
            return _items.Remove(item.UnwrapTo<NodeWrapper>().Item);
        }

        /// <inheritdoc />
        public int IndexOf(INode item)
        {
            return _items.IndexOf(item.UnwrapTo<NodeWrapper>().Item);
        }

        /// <inheritdoc />
        public void Insert(int index, INode item)
        {
            _items.Insert(index, item.UnwrapTo<NodeWrapper>().Item);
        }

        /// <inheritdoc />
        public void RemoveAt(int index)
        {
            _items.RemoveAt(index);
        }
    }
}