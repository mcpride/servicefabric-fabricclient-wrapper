// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Collections.Generic;
using System.Fabric;
using System.Threading;
using System.Threading.Tasks;

namespace MS.Extensions.Fabric
{
    internal class PropertyManagementClientWrapper : IPropertyManagementClient
    {
        private readonly FabricClient _fabricClient;

        public PropertyManagementClientWrapper(FabricClient fabricClient)
        {
            _fabricClient = fabricClient ?? throw new ArgumentNullException(nameof(fabricClient));
        }

        ///<inheritdoc/>
        public async Task CreateNameAsync(Uri name)
        {
            await _fabricClient.PropertyManager.CreateNameAsync(name);
        }

        ///<inheritdoc/>
        public async Task CreateNameAsync(Uri name, TimeSpan timeout, CancellationToken cancellationToken)
        {
            await _fabricClient.PropertyManager.CreateNameAsync(name, timeout, cancellationToken);
        }

        ///<inheritdoc/>
        public async Task DeleteNameAsync(Uri name)
        {
            await _fabricClient.PropertyManager.DeleteNameAsync(name);
        }

        ///<inheritdoc/>
        public async Task DeleteNameAsync(Uri name, TimeSpan timeout, CancellationToken cancellationToken)
        {
            await _fabricClient.PropertyManager.DeleteNameAsync(name, timeout, cancellationToken);
        }

        ///<inheritdoc/>
        public async Task<INameEnumerationResult> EnumerateSubNamesAsync(Uri name, INameEnumerationResult previousResult, bool recursive)
        {
            return !previousResult.TryUnwrap<INameEnumerationResult, NameEnumerationResultWrapper>(out var previousResultInt) 
                ? new NameEnumerationResultWrapper(null) 
                : new NameEnumerationResultWrapper(
                    await _fabricClient.PropertyManager.EnumerateSubNamesAsync(name, previousResultInt?.Result, recursive));
        }

        ///<inheritdoc/>
        public async Task<INameEnumerationResult> EnumerateSubNamesAsync(Uri name, INameEnumerationResult previousResult, bool recursive,
            TimeSpan timeout, CancellationToken cancellationToken)
        {
            return !previousResult.TryUnwrap<INameEnumerationResult, NameEnumerationResultWrapper>(out var previousResultInt)
                ? new NameEnumerationResultWrapper(null)
                : new NameEnumerationResultWrapper(
                    await _fabricClient.PropertyManager
                        .EnumerateSubNamesAsync(name, previousResultInt?.Result, recursive, timeout, cancellationToken));
        }

        ///<inheritdoc/>
        public async Task<bool> NameExistsAsync(Uri name)
        {
            return await _fabricClient.PropertyManager.NameExistsAsync(name);
        }

        ///<inheritdoc/>
        public async Task<bool> NameExistsAsync(Uri name, TimeSpan timeout, CancellationToken cancellationToken)
        {
            return await _fabricClient.PropertyManager.NameExistsAsync(name, timeout, cancellationToken);
        }

        ///<inheritdoc/>
        public async Task PutPropertyAsync(Uri parentName, string propertyName, double value)
        {
            await _fabricClient.PropertyManager.PutPropertyAsync(parentName, propertyName, value);
        }

        ///<inheritdoc/>
        public async Task PutPropertyAsync(Uri parentName, string propertyName, double value, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            await _fabricClient.PropertyManager.PutPropertyAsync(parentName, propertyName, value, timeout,
                cancellationToken);
        }

        ///<inheritdoc/>
        public async Task PutPropertyAsync(Uri parentName, string propertyName, long value)
        {
            await _fabricClient.PropertyManager.PutPropertyAsync(parentName, propertyName, value);
        }

        ///<inheritdoc/>
        public async Task PutPropertyAsync(Uri parentName, string propertyName, long value, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            await _fabricClient.PropertyManager.PutPropertyAsync(parentName, propertyName, value, timeout,
                cancellationToken);
        }

        ///<inheritdoc/>
        public async Task PutPropertyAsync(Uri parentName, string propertyName, string value)
        {
            await _fabricClient.PropertyManager.PutPropertyAsync(parentName, propertyName, value);
        }

        ///<inheritdoc/>
        public async Task PutPropertyAsync(Uri parentName, string propertyName, string value, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            await _fabricClient.PropertyManager.PutPropertyAsync(parentName, propertyName, value, timeout,
                cancellationToken);
        }

        ///<inheritdoc/>
        public async Task PutPropertyAsync(Uri parentName, string propertyName, Guid value)
        {
            await _fabricClient.PropertyManager.PutPropertyAsync(parentName, propertyName, value);
        }

        ///<inheritdoc/>
        public async Task PutPropertyAsync(Uri parentName, string propertyName, Guid value, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            await _fabricClient.PropertyManager.PutPropertyAsync(parentName, propertyName, value, timeout, cancellationToken);
        }

        ///<inheritdoc/>
        public async Task PutPropertyAsync(Uri parentName, string propertyName, byte[] value)
        {
            await _fabricClient.PropertyManager.PutPropertyAsync(parentName, propertyName, value);
        }

        ///<inheritdoc/>
        public async Task PutPropertyAsync(Uri parentName, string propertyName, byte[] value, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            await _fabricClient.PropertyManager.PutPropertyAsync(parentName, propertyName, value, timeout, cancellationToken);
        }

        ///<inheritdoc/>
        public async Task DeletePropertyAsync(Uri parentName, string propertyName)
        {
            await _fabricClient.PropertyManager.DeletePropertyAsync(parentName, propertyName);
        }

        ///<inheritdoc/>
        public async Task DeletePropertyAsync(Uri parentName, string propertyName, TimeSpan timeout, CancellationToken cancellationToken)
        {
            await _fabricClient.PropertyManager.DeletePropertyAsync(parentName, propertyName, timeout, cancellationToken);
        }

        ///<inheritdoc/>
        public async Task<INamedProperty> GetPropertyAsync(Uri parentName, string propertyName)
        {
            var result =  await _fabricClient.PropertyManager.GetPropertyAsync(parentName, propertyName);
            return result == null ? null : new NamedPropertyWrapper(result);
        }

        ///<inheritdoc/>
        public async Task<INamedProperty> GetPropertyAsync(Uri parentName, string propertyName, TimeSpan timeout, CancellationToken cancellationToken)
        {
            var result = await _fabricClient.PropertyManager.GetPropertyAsync(parentName, propertyName, timeout, cancellationToken);
            return result == null ? null : new NamedPropertyWrapper(result);
        }

        ///<inheritdoc/>
        public async Task<IPropertyBatchResult> SubmitPropertyBatchAsync(Uri parentName, ICollection<PropertyBatchOperation> operations)
        {
            var result = await _fabricClient.PropertyManager.SubmitPropertyBatchAsync(parentName, operations);
            return result == null ? null : new PropertyBatchResultWrapper(result);
        }

        ///<inheritdoc/>
        public async Task<IPropertyBatchResult> SubmitPropertyBatchAsync(Uri parentName, ICollection<PropertyBatchOperation> operations, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            var result = await _fabricClient.PropertyManager.SubmitPropertyBatchAsync(parentName, operations, timeout, cancellationToken);
            return result == null ? null : new PropertyBatchResultWrapper(result);
        }

        ///<inheritdoc/>
        public async Task<INamedPropertyMetadata> GetPropertyMetadataAsync(Uri parentName, string propertyName)
        {
            var result = await _fabricClient.PropertyManager.GetPropertyMetadataAsync(parentName, propertyName);
            return result == null ? null : new NamedPropertyMetadataWrapper(result);
        }

        ///<inheritdoc/>
        public async Task<INamedPropertyMetadata> GetPropertyMetadataAsync(Uri parentName, string propertyName, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            var result = await _fabricClient.PropertyManager.GetPropertyMetadataAsync(parentName, propertyName, timeout, cancellationToken);
            return result == null ? null : new NamedPropertyMetadataWrapper(result);
        }

        ///<inheritdoc/>
        public async Task<IPropertyEnumerationResult> EnumeratePropertiesAsync(Uri name, bool includeValues, PropertyEnumerationResult previousResult)
        {
            var result = await _fabricClient.PropertyManager.EnumeratePropertiesAsync(name, includeValues, previousResult);
            return result == null ? null : new PropertyEnumerationResultWrapper(result);
        }

        ///<inheritdoc/>
        public async Task<IPropertyEnumerationResult> EnumeratePropertiesAsync(Uri name, bool includeValues, PropertyEnumerationResult previousResult, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            var result = await _fabricClient.PropertyManager.EnumeratePropertiesAsync(name, includeValues, previousResult, timeout, cancellationToken);
            return result == null ? null : new PropertyEnumerationResultWrapper(result);
        }

        ///<inheritdoc/>
        public async Task PutCustomPropertyOperationAsync(Uri name, PutCustomPropertyOperation operation)
        {
            await _fabricClient.PropertyManager.PutCustomPropertyOperationAsync(name, operation);
        }

        ///<inheritdoc/>
        public async Task PutCustomPropertyOperationAsync(Uri name, PutCustomPropertyOperation operation, TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            await _fabricClient.PropertyManager.PutCustomPropertyOperationAsync(name, operation, timeout, cancellationToken);
        }
    }
}