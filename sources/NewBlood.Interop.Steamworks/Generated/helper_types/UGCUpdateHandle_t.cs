using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct UGCUpdateHandle_t : IComparable, IComparable<UGCUpdateHandle_t>, IEquatable<UGCUpdateHandle_t>, IFormattable
{
    public readonly ulong Value;

    public UGCUpdateHandle_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(UGCUpdateHandle_t left, UGCUpdateHandle_t right) => left.Value == right.Value;

    public static bool operator !=(UGCUpdateHandle_t left, UGCUpdateHandle_t right) => left.Value != right.Value;

    public static bool operator <(UGCUpdateHandle_t left, UGCUpdateHandle_t right) => left.Value < right.Value;

    public static bool operator <=(UGCUpdateHandle_t left, UGCUpdateHandle_t right) => left.Value <= right.Value;

    public static bool operator >(UGCUpdateHandle_t left, UGCUpdateHandle_t right) => left.Value > right.Value;

    public static bool operator >=(UGCUpdateHandle_t left, UGCUpdateHandle_t right) => left.Value >= right.Value;

    public static implicit operator UGCUpdateHandle_t(byte value) => new UGCUpdateHandle_t(value);

    public static explicit operator byte(UGCUpdateHandle_t value) => (byte)(value.Value);

    public static explicit operator UGCUpdateHandle_t(short value) => new UGCUpdateHandle_t(unchecked((ulong)(value)));

    public static explicit operator short(UGCUpdateHandle_t value) => (short)(value.Value);

    public static explicit operator UGCUpdateHandle_t(int value) => new UGCUpdateHandle_t(unchecked((ulong)(value)));

    public static explicit operator int(UGCUpdateHandle_t value) => (int)(value.Value);

    public static explicit operator UGCUpdateHandle_t(long value) => new UGCUpdateHandle_t(unchecked((ulong)(value)));

    public static explicit operator long(UGCUpdateHandle_t value) => (long)(value.Value);

    public static explicit operator UGCUpdateHandle_t(nint value) => new UGCUpdateHandle_t(unchecked((ulong)(value)));

    public static explicit operator nint(UGCUpdateHandle_t value) => (nint)(value.Value);

    public static explicit operator UGCUpdateHandle_t(sbyte value) => new UGCUpdateHandle_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(UGCUpdateHandle_t value) => (sbyte)(value.Value);

    public static implicit operator UGCUpdateHandle_t(ushort value) => new UGCUpdateHandle_t(value);

    public static explicit operator ushort(UGCUpdateHandle_t value) => (ushort)(value.Value);

    public static implicit operator UGCUpdateHandle_t(uint value) => new UGCUpdateHandle_t(value);

    public static explicit operator uint(UGCUpdateHandle_t value) => (uint)(value.Value);

    public static implicit operator UGCUpdateHandle_t(ulong value) => new UGCUpdateHandle_t(value);

    public static implicit operator ulong(UGCUpdateHandle_t value) => value.Value;

    public static implicit operator UGCUpdateHandle_t(nuint value) => new UGCUpdateHandle_t(value);

    public static explicit operator nuint(UGCUpdateHandle_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is UGCUpdateHandle_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of UGCUpdateHandle_t.");
    }

    public int CompareTo(UGCUpdateHandle_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is UGCUpdateHandle_t other) && Equals(other);

    public bool Equals(UGCUpdateHandle_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
