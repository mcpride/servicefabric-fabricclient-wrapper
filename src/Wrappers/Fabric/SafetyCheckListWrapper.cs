// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Collections;
using System.Collections.Generic;
using System.Fabric;
using System.Linq;
using MS.Extensions.Tools;

namespace MS.Extensions.Fabric
{
    internal class SafetyCheckListWrapper : IList<ISafetyCheck>
    {
        private readonly IList<SafetyCheck> _items;

        /// <inheritdoc />
        public int Count => _items.Count;

        /// <inheritdoc />
        public bool IsReadOnly => _items.IsReadOnly;

        /// <inheritdoc />
        public ISafetyCheck this[int index]
        {
            get => new SafetyCheckWrapper(_items[index]);
            set => _items[index] = value.UnwrapTo<SafetyCheckWrapper>().Item;
        }

        public SafetyCheckListWrapper(IList<SafetyCheck> items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
        }

        /// <inheritdoc />
        public IEnumerator<ISafetyCheck> GetEnumerator()
        {
            foreach (var item in _items)
            {
                yield return new SafetyCheckWrapper(item);
            }
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc />
        public void Add(ISafetyCheck item)
        {
            _items.Add(item.UnwrapTo<SafetyCheckWrapper>().Item);
        }

        /// <inheritdoc />
        public void Clear()
        {
            _items.Clear();
        }

        /// <inheritdoc />
        public bool Contains(ISafetyCheck item)
        {
            return _items.Contains(item.UnwrapTo<SafetyCheckWrapper>().Item);
        }

        /// <inheritdoc />
        public void CopyTo(ISafetyCheck[] array, int arrayIndex)
        {
            _items.CopyTo(array.Select(item => item.UnwrapTo<SafetyCheckWrapper>()
                    .Item).ToArray(),
                arrayIndex);
        }

        /// <inheritdoc />
        public bool Remove(ISafetyCheck item)
        {
            return _items.Remove(item.UnwrapTo<SafetyCheckWrapper>().Item);
        }

        /// <inheritdoc />
        public int IndexOf(ISafetyCheck item)
        {
            return _items.IndexOf(item.UnwrapTo<SafetyCheckWrapper>().Item);
        }

        /// <inheritdoc />
        public void Insert(int index, ISafetyCheck item)
        {
            _items.Insert(index, item.UnwrapTo<SafetyCheckWrapper>().Item);
        }

        /// <inheritdoc />
        public void RemoveAt(int index)
        {
            _items.RemoveAt(index);
        }
    }
}