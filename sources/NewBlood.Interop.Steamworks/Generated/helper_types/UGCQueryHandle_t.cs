using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct UGCQueryHandle_t : IComparable, IComparable<UGCQueryHandle_t>, IEquatable<UGCQueryHandle_t>, IFormattable
{
    public readonly ulong Value;

    public UGCQueryHandle_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(UGCQueryHandle_t left, UGCQueryHandle_t right) => left.Value == right.Value;

    public static bool operator !=(UGCQueryHandle_t left, UGCQueryHandle_t right) => left.Value != right.Value;

    public static bool operator <(UGCQueryHandle_t left, UGCQueryHandle_t right) => left.Value < right.Value;

    public static bool operator <=(UGCQueryHandle_t left, UGCQueryHandle_t right) => left.Value <= right.Value;

    public static bool operator >(UGCQueryHandle_t left, UGCQueryHandle_t right) => left.Value > right.Value;

    public static bool operator >=(UGCQueryHandle_t left, UGCQueryHandle_t right) => left.Value >= right.Value;

    public static implicit operator UGCQueryHandle_t(byte value) => new UGCQueryHandle_t(value);

    public static explicit operator byte(UGCQueryHandle_t value) => (byte)(value.Value);

    public static explicit operator UGCQueryHandle_t(short value) => new UGCQueryHandle_t(unchecked((ulong)(value)));

    public static explicit operator short(UGCQueryHandle_t value) => (short)(value.Value);

    public static explicit operator UGCQueryHandle_t(int value) => new UGCQueryHandle_t(unchecked((ulong)(value)));

    public static explicit operator int(UGCQueryHandle_t value) => (int)(value.Value);

    public static explicit operator UGCQueryHandle_t(long value) => new UGCQueryHandle_t(unchecked((ulong)(value)));

    public static explicit operator long(UGCQueryHandle_t value) => (long)(value.Value);

    public static explicit operator UGCQueryHandle_t(nint value) => new UGCQueryHandle_t(unchecked((ulong)(value)));

    public static explicit operator nint(UGCQueryHandle_t value) => (nint)(value.Value);

    public static explicit operator UGCQueryHandle_t(sbyte value) => new UGCQueryHandle_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(UGCQueryHandle_t value) => (sbyte)(value.Value);

    public static implicit operator UGCQueryHandle_t(ushort value) => new UGCQueryHandle_t(value);

    public static explicit operator ushort(UGCQueryHandle_t value) => (ushort)(value.Value);

    public static implicit operator UGCQueryHandle_t(uint value) => new UGCQueryHandle_t(value);

    public static explicit operator uint(UGCQueryHandle_t value) => (uint)(value.Value);

    public static implicit operator UGCQueryHandle_t(ulong value) => new UGCQueryHandle_t(value);

    public static implicit operator ulong(UGCQueryHandle_t value) => value.Value;

    public static implicit operator UGCQueryHandle_t(nuint value) => new UGCQueryHandle_t(value);

    public static explicit operator nuint(UGCQueryHandle_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is UGCQueryHandle_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of UGCQueryHandle_t.");
    }

    public int CompareTo(UGCQueryHandle_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is UGCQueryHandle_t other) && Equals(other);

    public bool Equals(UGCQueryHandle_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
