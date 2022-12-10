using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct SNetSocket_t : IComparable, IComparable<SNetSocket_t>, IEquatable<SNetSocket_t>, IFormattable
{
    public readonly uint Value;

    public SNetSocket_t(uint value)
    {
        Value = value;
    }

    public static bool operator ==(SNetSocket_t left, SNetSocket_t right) => left.Value == right.Value;

    public static bool operator !=(SNetSocket_t left, SNetSocket_t right) => left.Value != right.Value;

    public static bool operator <(SNetSocket_t left, SNetSocket_t right) => left.Value < right.Value;

    public static bool operator <=(SNetSocket_t left, SNetSocket_t right) => left.Value <= right.Value;

    public static bool operator >(SNetSocket_t left, SNetSocket_t right) => left.Value > right.Value;

    public static bool operator >=(SNetSocket_t left, SNetSocket_t right) => left.Value >= right.Value;

    public static implicit operator SNetSocket_t(byte value) => new SNetSocket_t(value);

    public static explicit operator byte(SNetSocket_t value) => (byte)(value.Value);

    public static explicit operator SNetSocket_t(short value) => new SNetSocket_t(unchecked((uint)(value)));

    public static explicit operator short(SNetSocket_t value) => (short)(value.Value);

    public static explicit operator SNetSocket_t(int value) => new SNetSocket_t(unchecked((uint)(value)));

    public static explicit operator int(SNetSocket_t value) => (int)(value.Value);

    public static explicit operator SNetSocket_t(long value) => new SNetSocket_t(unchecked((uint)(value)));

    public static implicit operator long(SNetSocket_t value) => value.Value;

    public static explicit operator SNetSocket_t(nint value) => new SNetSocket_t(unchecked((uint)(value)));

    public static explicit operator nint(SNetSocket_t value) => (nint)(value.Value);

    public static explicit operator SNetSocket_t(sbyte value) => new SNetSocket_t(unchecked((uint)(value)));

    public static explicit operator sbyte(SNetSocket_t value) => (sbyte)(value.Value);

    public static implicit operator SNetSocket_t(ushort value) => new SNetSocket_t(value);

    public static explicit operator ushort(SNetSocket_t value) => (ushort)(value.Value);

    public static implicit operator SNetSocket_t(uint value) => new SNetSocket_t(value);

    public static implicit operator uint(SNetSocket_t value) => value.Value;

    public static explicit operator SNetSocket_t(ulong value) => new SNetSocket_t(unchecked((uint)(value)));

    public static implicit operator ulong(SNetSocket_t value) => value.Value;

    public static explicit operator SNetSocket_t(nuint value) => new SNetSocket_t(unchecked((uint)(value)));

    public static implicit operator nuint(SNetSocket_t value) => value.Value;

    public int CompareTo(object? obj)
    {
            if (obj is SNetSocket_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SNetSocket_t.");
    }

    public int CompareTo(SNetSocket_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is SNetSocket_t other) && Equals(other);

    public bool Equals(SNetSocket_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
