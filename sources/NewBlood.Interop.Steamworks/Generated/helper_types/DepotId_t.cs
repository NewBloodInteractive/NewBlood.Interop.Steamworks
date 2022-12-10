using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct DepotId_t : IComparable, IComparable<DepotId_t>, IEquatable<DepotId_t>, IFormattable
{
    public readonly uint Value;

    public DepotId_t(uint value)
    {
        Value = value;
    }

    public static bool operator ==(DepotId_t left, DepotId_t right) => left.Value == right.Value;

    public static bool operator !=(DepotId_t left, DepotId_t right) => left.Value != right.Value;

    public static bool operator <(DepotId_t left, DepotId_t right) => left.Value < right.Value;

    public static bool operator <=(DepotId_t left, DepotId_t right) => left.Value <= right.Value;

    public static bool operator >(DepotId_t left, DepotId_t right) => left.Value > right.Value;

    public static bool operator >=(DepotId_t left, DepotId_t right) => left.Value >= right.Value;

    public static implicit operator DepotId_t(byte value) => new DepotId_t(value);

    public static explicit operator byte(DepotId_t value) => (byte)(value.Value);

    public static explicit operator DepotId_t(short value) => new DepotId_t(unchecked((uint)(value)));

    public static explicit operator short(DepotId_t value) => (short)(value.Value);

    public static explicit operator DepotId_t(int value) => new DepotId_t(unchecked((uint)(value)));

    public static explicit operator int(DepotId_t value) => (int)(value.Value);

    public static explicit operator DepotId_t(long value) => new DepotId_t(unchecked((uint)(value)));

    public static implicit operator long(DepotId_t value) => value.Value;

    public static explicit operator DepotId_t(nint value) => new DepotId_t(unchecked((uint)(value)));

    public static explicit operator nint(DepotId_t value) => (nint)(value.Value);

    public static explicit operator DepotId_t(sbyte value) => new DepotId_t(unchecked((uint)(value)));

    public static explicit operator sbyte(DepotId_t value) => (sbyte)(value.Value);

    public static implicit operator DepotId_t(ushort value) => new DepotId_t(value);

    public static explicit operator ushort(DepotId_t value) => (ushort)(value.Value);

    public static implicit operator DepotId_t(uint value) => new DepotId_t(value);

    public static implicit operator uint(DepotId_t value) => value.Value;

    public static explicit operator DepotId_t(ulong value) => new DepotId_t(unchecked((uint)(value)));

    public static implicit operator ulong(DepotId_t value) => value.Value;

    public static explicit operator DepotId_t(nuint value) => new DepotId_t(unchecked((uint)(value)));

    public static implicit operator nuint(DepotId_t value) => value.Value;

    public int CompareTo(object? obj)
    {
            if (obj is DepotId_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of DepotId_t.");
    }

    public int CompareTo(DepotId_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is DepotId_t other) && Equals(other);

    public bool Equals(DepotId_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
