using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct UGCFileWriteStreamHandle_t : IComparable, IComparable<UGCFileWriteStreamHandle_t>, IEquatable<UGCFileWriteStreamHandle_t>, IFormattable
{
    public readonly ulong Value;

    public UGCFileWriteStreamHandle_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(UGCFileWriteStreamHandle_t left, UGCFileWriteStreamHandle_t right) => left.Value == right.Value;

    public static bool operator !=(UGCFileWriteStreamHandle_t left, UGCFileWriteStreamHandle_t right) => left.Value != right.Value;

    public static bool operator <(UGCFileWriteStreamHandle_t left, UGCFileWriteStreamHandle_t right) => left.Value < right.Value;

    public static bool operator <=(UGCFileWriteStreamHandle_t left, UGCFileWriteStreamHandle_t right) => left.Value <= right.Value;

    public static bool operator >(UGCFileWriteStreamHandle_t left, UGCFileWriteStreamHandle_t right) => left.Value > right.Value;

    public static bool operator >=(UGCFileWriteStreamHandle_t left, UGCFileWriteStreamHandle_t right) => left.Value >= right.Value;

    public static implicit operator UGCFileWriteStreamHandle_t(byte value) => new UGCFileWriteStreamHandle_t(value);

    public static explicit operator byte(UGCFileWriteStreamHandle_t value) => (byte)(value.Value);

    public static explicit operator UGCFileWriteStreamHandle_t(short value) => new UGCFileWriteStreamHandle_t(unchecked((ulong)(value)));

    public static explicit operator short(UGCFileWriteStreamHandle_t value) => (short)(value.Value);

    public static explicit operator UGCFileWriteStreamHandle_t(int value) => new UGCFileWriteStreamHandle_t(unchecked((ulong)(value)));

    public static explicit operator int(UGCFileWriteStreamHandle_t value) => (int)(value.Value);

    public static explicit operator UGCFileWriteStreamHandle_t(long value) => new UGCFileWriteStreamHandle_t(unchecked((ulong)(value)));

    public static explicit operator long(UGCFileWriteStreamHandle_t value) => (long)(value.Value);

    public static explicit operator UGCFileWriteStreamHandle_t(nint value) => new UGCFileWriteStreamHandle_t(unchecked((ulong)(value)));

    public static explicit operator nint(UGCFileWriteStreamHandle_t value) => (nint)(value.Value);

    public static explicit operator UGCFileWriteStreamHandle_t(sbyte value) => new UGCFileWriteStreamHandle_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(UGCFileWriteStreamHandle_t value) => (sbyte)(value.Value);

    public static implicit operator UGCFileWriteStreamHandle_t(ushort value) => new UGCFileWriteStreamHandle_t(value);

    public static explicit operator ushort(UGCFileWriteStreamHandle_t value) => (ushort)(value.Value);

    public static implicit operator UGCFileWriteStreamHandle_t(uint value) => new UGCFileWriteStreamHandle_t(value);

    public static explicit operator uint(UGCFileWriteStreamHandle_t value) => (uint)(value.Value);

    public static implicit operator UGCFileWriteStreamHandle_t(ulong value) => new UGCFileWriteStreamHandle_t(value);

    public static implicit operator ulong(UGCFileWriteStreamHandle_t value) => value.Value;

    public static implicit operator UGCFileWriteStreamHandle_t(nuint value) => new UGCFileWriteStreamHandle_t(value);

    public static explicit operator nuint(UGCFileWriteStreamHandle_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is UGCFileWriteStreamHandle_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of UGCFileWriteStreamHandle_t.");
    }

    public int CompareTo(UGCFileWriteStreamHandle_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is UGCFileWriteStreamHandle_t other) && Equals(other);

    public bool Equals(UGCFileWriteStreamHandle_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
