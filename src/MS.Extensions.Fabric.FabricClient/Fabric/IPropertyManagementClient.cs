// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Collections.Generic;
using System.Fabric;
using System.Threading;
using System.Threading.Tasks;

namespace MS.Extensions.Fabric
{
    public interface IPropertyManagementClient
    {
        Task CreateNameAsync(Uri name);
        Task CreateNameAsync(Uri name, TimeSpan timeout, CancellationToken cancellationToken);
        Task DeleteNameAsync(Uri name);
        Task DeleteNameAsync(Uri name, TimeSpan timeout, CancellationToken cancellationToken);
        Task<INameEnumerationResult> EnumerateSubNamesAsync(Uri name, INameEnumerationResult previousResult, bool recursive);
        Task<INameEnumerationResult> EnumerateSubNamesAsync(Uri name, INameEnumerationResult previousResult, bool recursive, TimeSpan timeout, CancellationToken cancellationToken);
        Task<bool> NameExistsAsync(Uri name);
        Task<bool> NameExistsAsync(Uri name, TimeSpan timeout, CancellationToken cancellationToken);
        Task PutPropertyAsync(Uri parentName, string propertyName, double value);
        Task PutPropertyAsync(Uri parentName, string propertyName, double value, TimeSpan timeout, CancellationToken cancellationToken);
        Task PutPropertyAsync(Uri parentName, string propertyName, long value);
        Task PutPropertyAsync(Uri parentName, string propertyName, long value, TimeSpan timeout, CancellationToken cancellationToken);
        Task PutPropertyAsync(Uri parentName, string propertyName, string value);
        Task PutPropertyAsync(Uri parentName, string propertyName, string value, TimeSpan timeout, CancellationToken cancellationToken);
        Task PutPropertyAsync(Uri parentName, string propertyName, Guid value);
        Task PutPropertyAsync(Uri parentName, string propertyName, Guid value, TimeSpan timeout, CancellationToken cancellationToken);
        Task PutPropertyAsync(Uri parentName, string propertyName, byte[] value);
        Task PutPropertyAsync(Uri parentName, string propertyName, byte[] value, TimeSpan timeout, CancellationToken cancellationToken);
        Task DeletePropertyAsync(Uri parentName, string propertyName);
        Task DeletePropertyAsync(Uri parentName, string propertyName, TimeSpan timeout, CancellationToken cancellationToken);
        Task<INamedProperty> GetPropertyAsync(Uri parentName, string propertyName);
        Task<INamedProperty> GetPropertyAsync(Uri parentName, string propertyName, TimeSpan timeout, CancellationToken cancellationToken);
        Task<IPropertyBatchResult> SubmitPropertyBatchAsync(Uri parentName, ICollection<PropertyBatchOperation> operations);
        Task<IPropertyBatchResult> SubmitPropertyBatchAsync(Uri parentName, ICollection<PropertyBatchOperation> operations, TimeSpan timeout, CancellationToken cancellationToken);
        Task<INamedPropertyMetadata> GetPropertyMetadataAsync(Uri parentName, string propertyName);
        Task<INamedPropertyMetadata> GetPropertyMetadataAsync(Uri parentName, string propertyName, TimeSpan timeout, CancellationToken cancellationToken);
        Task<IPropertyEnumerationResult> EnumeratePropertiesAsync(Uri name, bool includeValues, PropertyEnumerationResult previousResult);
        Task<IPropertyEnumerationResult> EnumeratePropertiesAsync(Uri name, bool includeValues, PropertyEnumerationResult previousResult, TimeSpan timeout, CancellationToken cancellationToken);
        Task PutCustomPropertyOperationAsync(Uri name, PutCustomPropertyOperation operation);
        Task PutCustomPropertyOperationAsync(Uri name, PutCustomPropertyOperation operation, TimeSpan timeout, CancellationToken cancellationToken);
    }
}