// MIT License
// Copyright (c) 2021 Marco Stolze

using System;

namespace MS.Extensions.Tools
{
    internal static class UnwrapHelper
    {
        public static bool TryUnwrapTo<TUnwrapped>(this object wrapped, out TUnwrapped unwrapped)
        {
            if (wrapped == null)
            {
                unwrapped = default;
                return true;
            }
            if (!(wrapped is TUnwrapped value))
            {
                unwrapped = default;
                return false;
            }
            unwrapped = value;
            return true;
        }

        public static TUnwrapped UnwrapTo<TUnwrapped>(this object wrapped)
        {
            if (!TryUnwrapTo<TUnwrapped>(wrapped, out var unwrapped))
            {
                throw new InvalidOperationException($"Cannot unwrap to {nameof(TUnwrapped)}!");
            }
            return unwrapped;
        }
    }
}