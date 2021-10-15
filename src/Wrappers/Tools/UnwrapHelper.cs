// MIT License
// Copyright (c) 2021 Marco Stolze

using System;

namespace MS.Extensions.Tools
{
    internal static class UnwrapHelper
    {
        public static bool TryUnwrap<TWrapped, TUnwrapped>(this TWrapped wrapped, out TUnwrapped unwrapped)
        {
            unwrapped = default;
            var d = default(TWrapped);
            if (wrapped.Equals(d)) return true;
            if (!(wrapped is TUnwrapped value)) return false;
            unwrapped = value;
            return true;
        }

        public static TUnwrapped Unwrap<TWrapped, TUnwrapped>(this TWrapped wrapped)
        {
            if (!TryUnwrap<TWrapped, TUnwrapped>(wrapped, out var unwrapped))
            {
                throw new InvalidOperationException($"Cannot unwrap {nameof(TWrapped)} to {nameof(TUnwrapped)}!");
            }
            return unwrapped;
        }
    }
}