// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;

namespace MS.Extensions.Fabric
{
    internal class PropertyBatchResultWrapper : IPropertyBatchResult
    {
        private readonly PropertyBatchResult _propertyBatchResult;

        public int FailedOperationIndex => _propertyBatchResult.FailedOperationIndex;
        public Exception FailedOperationException => _propertyBatchResult.FailedOperationException;

        public PropertyBatchResultWrapper(PropertyBatchResult propertyBatchResult)
        {
            _propertyBatchResult = propertyBatchResult ?? throw new ArgumentNullException(nameof(propertyBatchResult));
        }

        public INamedProperty GetProperty(int index)
        {
            var result = _propertyBatchResult.GetProperty(index);
            return result == null ? null : new NamedPropertyWrapper(result);
        }
    }
}