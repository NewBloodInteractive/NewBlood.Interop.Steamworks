using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct SNetListenSocket_t : IComparable, IComparable<SNetListenSocket_t>, IEquatable<SNetListenSocket_t>, IFormattable
{
    public readonly uint Value;

    public SNetListenSocket_t(uint value)
    {
        Value = value;
    }

    public static bool operator ==(SNetListenSocket_t left, SNetListenSocket_t right) => left.Value == right.Value;

    public static bool operator !=(SNetListenSocket_t left, SNetListenSocket_t right) => left.Value != right.Value;

    public static bool operator <(SNetListenSocket_t left, SNetListenSocket_t right) => left.Value < right.Value;

    public static bool operator <=(SNetListenSocket_t left, SNetListenSocket_t right) => left.Value <= right.Value;

    public static bool operator >(SNetListenSocket_t left, SNetListenSocket_t right) => left.Value > right.Value;

    public static bool operator >=(SNetListenSocket_t left, SNetListenSocket_t right) => left.Value >= right.Value;

    public static implicit operator SNetListenSocket_t(byte value) => new SNetListenSocket_t(value);

    public static explicit operator byte(SNetListenSocket_t value) => (byte)(value.Value);

    public static explicit operator SNetListenSocket_t(short value) => new SNetListenSocket_t(unchecked((uint)(value)));

    public static explicit operator short(SNetListenSocket_t value) => (short)(value.Value);

    public static explicit operator SNetListenSocket_t(int value) => new SNetListenSocket_t(unchecked((uint)(value)));

    public static explicit operator int(SNetListenSocket_t value) => (int)(value.Value);

    public static explicit operator SNetListenSocket_t(long value) => new SNetListenSocket_t(unchecked((uint)(value)));

    public static implicit operator long(SNetListenSocket_t value) => value.Value;

    public static explicit operator SNetListenSocket_t(nint value) => new SNetListenSocket_t(unchecked((uint)(value)));

    public static explicit operator nint(SNetListenSocket_t value) => (nint)(value.Value);

    public static explicit operator SNetListenSocket_t(sbyte value) => new SNetListenSocket_t(unchecked((uint)(value)));

    public static explicit operator sbyte(SNetListenSocket_t value) => (sbyte)(value.Value);

    public static implicit operator SNetListenSocket_t(ushort value) => new SNetListenSocket_t(value);

    public static explicit operator ushort(SNetListenSocket_t value) => (ushort)(value.Value);

    public static implicit operator SNetListenSocket_t(uint value) => new SNetListenSocket_t(value);

    public static implicit operator uint(SNetListenSocket_t value) => value.Value;

    public static explicit operator SNetListenSocket_t(ulong value) => new SNetListenSocket_t(unchecked((uint)(value)));

    public static implicit operator ulong(SNetListenSocket_t value) => value.Value;

    public static explicit operator SNetListenSocket_t(nuint value) => new SNetListenSocket_t(unchecked((uint)(value)));

    public static implicit operator nuint(SNetListenSocket_t value) => value.Value;

    public int CompareTo(object? obj)
    {
            if (obj is SNetListenSocket_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SNetListenSocket_t.");
    }

    public int CompareTo(SNetListenSocket_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is SNetListenSocket_t other) && Equals(other);

    public bool Equals(SNetListenSocket_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
