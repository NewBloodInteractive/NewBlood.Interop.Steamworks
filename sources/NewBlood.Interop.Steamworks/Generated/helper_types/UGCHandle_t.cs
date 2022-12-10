using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct UGCHandle_t : IComparable, IComparable<UGCHandle_t>, IEquatable<UGCHandle_t>, IFormattable
{
    public readonly ulong Value;

    public UGCHandle_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(UGCHandle_t left, UGCHandle_t right) => left.Value == right.Value;

    public static bool operator !=(UGCHandle_t left, UGCHandle_t right) => left.Value != right.Value;

    public static bool operator <(UGCHandle_t left, UGCHandle_t right) => left.Value < right.Value;

    public static bool operator <=(UGCHandle_t left, UGCHandle_t right) => left.Value <= right.Value;

    public static bool operator >(UGCHandle_t left, UGCHandle_t right) => left.Value > right.Value;

    public static bool operator >=(UGCHandle_t left, UGCHandle_t right) => left.Value >= right.Value;

    public static implicit operator UGCHandle_t(byte value) => new UGCHandle_t(value);

    public static explicit operator byte(UGCHandle_t value) => (byte)(value.Value);

    public static explicit operator UGCHandle_t(short value) => new UGCHandle_t(unchecked((ulong)(value)));

    public static explicit operator short(UGCHandle_t value) => (short)(value.Value);

    public static explicit operator UGCHandle_t(int value) => new UGCHandle_t(unchecked((ulong)(value)));

    public static explicit operator int(UGCHandle_t value) => (int)(value.Value);

    public static explicit operator UGCHandle_t(long value) => new UGCHandle_t(unchecked((ulong)(value)));

    public static explicit operator long(UGCHandle_t value) => (long)(value.Value);

    public static explicit operator UGCHandle_t(nint value) => new UGCHandle_t(unchecked((ulong)(value)));

    public static explicit operator nint(UGCHandle_t value) => (nint)(value.Value);

    public static explicit operator UGCHandle_t(sbyte value) => new UGCHandle_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(UGCHandle_t value) => (sbyte)(value.Value);

    public static implicit operator UGCHandle_t(ushort value) => new UGCHandle_t(value);

    public static explicit operator ushort(UGCHandle_t value) => (ushort)(value.Value);

    public static implicit operator UGCHandle_t(uint value) => new UGCHandle_t(value);

    public static explicit operator uint(UGCHandle_t value) => (uint)(value.Value);

    public static implicit operator UGCHandle_t(ulong value) => new UGCHandle_t(value);

    public static implicit operator ulong(UGCHandle_t value) => value.Value;

    public static implicit operator UGCHandle_t(nuint value) => new UGCHandle_t(value);

    public static explicit operator nuint(UGCHandle_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is UGCHandle_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of UGCHandle_t.");
    }

    public int CompareTo(UGCHandle_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is UGCHandle_t other) && Equals(other);

    public bool Equals(UGCHandle_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
