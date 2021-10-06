// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Collections;
using System.Collections.Generic;
using System.Fabric.Query;
using System.Linq;

namespace MS.Extensions.Fabric.Query
{
    internal class ApplicationListWrapper : IApplicationList
    {
        private readonly ApplicationList _applications;

        public IApplication this[int index]
        {
            get => new ApplicationWrapper(_applications[index]);
            set => _applications[index] = value.Unwrap<IApplication, ApplicationWrapper>().Application;
        }

        public string ContinuationToken
        {
            get => _applications.ContinuationToken;
            set => _applications.ContinuationToken = value;
        }

        public int Count => _applications.Count;

        public bool IsReadOnly => _applications.IsReadOnly;

        public ApplicationListWrapper(ApplicationList applications)
        {
            _applications = applications ?? throw new ArgumentNullException(nameof(applications));
        }

        public IEnumerator<IApplication> GetEnumerator()
        {
            var list = new List<IApplication>();
            list.AddRange(_applications.Select(item => new ApplicationWrapper(item)).Cast<IApplication>());
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(IApplication item)
        {
            _applications.Add(item.Unwrap<IApplication, ApplicationWrapper>().Application);
        }

        public void Clear()
        {
            _applications.Clear();
        }

        public bool Contains(IApplication item)
        {
            return _applications.Contains(item.Unwrap<IApplication, ApplicationWrapper>().Application);
        }

        public void CopyTo(IApplication[] array, int arrayIndex)
        {
            _applications.CopyTo(
                array.Select(item => item.Unwrap<IApplication, ApplicationWrapper>().Application).ToArray(), 
                arrayIndex);
        }

        public bool Remove(IApplication item)
        {
            return _applications.Remove(item.Unwrap<IApplication, ApplicationWrapper>().Application);
        }

        public int IndexOf(IApplication item)
        {
            return _applications.IndexOf(item.Unwrap<IApplication, ApplicationWrapper>().Application);
        }

        public void Insert(int index, IApplication item)
        {
            _applications.Insert(index, item.Unwrap<IApplication, ApplicationWrapper>().Application);
        }

        public void RemoveAt(int index)
        {
            _applications.RemoveAt(index);
        }
    }
}
