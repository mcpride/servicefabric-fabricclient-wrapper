// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric;
using System.Threading;
using System.Threading.Tasks;

namespace MS.Extensions.Fabric
{
    internal static class ExceptionsHelper
    {
        /// <summary>
        /// Translates Service Fabric's <see cref="FabricTransientException"/>
        /// into the appropriate <see cref="OperationCanceledException"/> when it represents a deliberate cancellation.
        /// </summary>
        public static Task TranslateCancellations(Func<Task> func, CancellationToken cancellation)
        {
            return TranslateCancellations(
                async () =>
                {
                    await func();
                    return 0;
                },
                cancellation);
        }

        /// <summary>
        /// Translates Service Fabric's <see cref="FabricTransientException"/>
        /// into the appropriate <see cref="OperationCanceledException"/> when it represents a deliberate cancellation.
        /// </summary>
        public static async Task<TResult> TranslateCancellations<TResult>(Func<Task<TResult>> func, CancellationToken cancellation)
        {
            try
            {
                return await func();
            }
            catch (FabricTransientException ex)
            {
                if (ex.ErrorCode == FabricErrorCode.OperationCanceled && cancellation.IsCancellationRequested)
                {
                    cancellation.ThrowIfCancellationRequested();
                    throw new InvalidOperationException("Execution should never get here...");
                }

                throw;
            }
        }
    }
}
