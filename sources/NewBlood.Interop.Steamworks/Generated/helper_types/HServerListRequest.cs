using System;

namespace NewBlood.Interop.Steamworks;

public readonly unsafe partial struct HServerListRequest : IComparable, IComparable<HServerListRequest>, IEquatable<HServerListRequest>, IFormattable
{
    public readonly void* Value;

    public HServerListRequest(void* value)
    {
        Value = value;
    }

    public static HServerListRequest NULL => new HServerListRequest(null);

    public static bool operator ==(HServerListRequest left, HServerListRequest right) => left.Value == right.Value;

    public static bool operator !=(HServerListRequest left, HServerListRequest right) => left.Value != right.Value;

    public static bool operator <(HServerListRequest left, HServerListRequest right) => left.Value < right.Value;

    public static bool operator <=(HServerListRequest left, HServerListRequest right) => left.Value <= right.Value;

    public static bool operator >(HServerListRequest left, HServerListRequest right) => left.Value > right.Value;

    public static bool operator >=(HServerListRequest left, HServerListRequest right) => left.Value >= right.Value;

    public static explicit operator HServerListRequest(void* value) => new HServerListRequest(value);

    public static implicit operator void*(HServerListRequest value) => value.Value;

    public static explicit operator HServerListRequest(byte value) => new HServerListRequest(unchecked((void*)(value)));

    public static explicit operator byte(HServerListRequest value) => (byte)(value.Value);

    public static explicit operator HServerListRequest(short value) => new HServerListRequest(unchecked((void*)(value)));

    public static explicit operator short(HServerListRequest value) => (short)(value.Value);

    public static explicit operator HServerListRequest(int value) => new HServerListRequest(unchecked((void*)(value)));

    public static explicit operator int(HServerListRequest value) => (int)(value.Value);

    public static explicit operator HServerListRequest(long value) => new HServerListRequest(unchecked((void*)(value)));

    public static explicit operator long(HServerListRequest value) => (long)(value.Value);

    public static explicit operator HServerListRequest(nint value) => new HServerListRequest(unchecked((void*)(value)));

    public static implicit operator nint(HServerListRequest value) => (nint)(value.Value);

    public static explicit operator HServerListRequest(sbyte value) => new HServerListRequest(unchecked((void*)(value)));

    public static explicit operator sbyte(HServerListRequest value) => (sbyte)(value.Value);

    public static explicit operator HServerListRequest(ushort value) => new HServerListRequest(unchecked((void*)(value)));

    public static explicit operator ushort(HServerListRequest value) => (ushort)(value.Value);

    public static explicit operator HServerListRequest(uint value) => new HServerListRequest(unchecked((void*)(value)));

    public static explicit operator uint(HServerListRequest value) => (uint)(value.Value);

    public static explicit operator HServerListRequest(ulong value) => new HServerListRequest(unchecked((void*)(value)));

    public static explicit operator ulong(HServerListRequest value) => (ulong)(value.Value);

    public static explicit operator HServerListRequest(nuint value) => new HServerListRequest(unchecked((void*)(value)));

    public static implicit operator nuint(HServerListRequest value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is HServerListRequest other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HServerListRequest.");
    }

    public int CompareTo(HServerListRequest other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HServerListRequest other) && Equals(other);

    public bool Equals(HServerListRequest other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
