#if !NET5_0_OR_GREATER
using System;

namespace NewBlood.Interop.Steamworks;

internal static unsafe class UIntPtrExtensions
{
    public static int CompareTo(this nuint value, nuint other)
    {
        if (sizeof(nuint) == sizeof(uint))
            return ((uint)value).CompareTo((uint)other);
        else
            return ((ulong)value).CompareTo(other);
    }

    public static string ToString(this nuint value, string? format)
    {
        if (sizeof(nuint) == sizeof(uint))
            return ((uint)value).ToString(format);
        else
            return ((ulong)value).ToString(format);
    }

    public static string ToString(this nuint value, string? format, IFormatProvider? formatProvider)
    {
        if (sizeof(nuint) == sizeof(uint))
            return ((uint)value).ToString(format, formatProvider);
        else
            return ((ulong)value).ToString(format, formatProvider);
    }
}
#endif
