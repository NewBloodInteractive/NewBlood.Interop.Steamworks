using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct PartyBeaconID_t : IComparable, IComparable<PartyBeaconID_t>, IEquatable<PartyBeaconID_t>, IFormattable
{
    public readonly ulong Value;

    public PartyBeaconID_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(PartyBeaconID_t left, PartyBeaconID_t right) => left.Value == right.Value;

    public static bool operator !=(PartyBeaconID_t left, PartyBeaconID_t right) => left.Value != right.Value;

    public static bool operator <(PartyBeaconID_t left, PartyBeaconID_t right) => left.Value < right.Value;

    public static bool operator <=(PartyBeaconID_t left, PartyBeaconID_t right) => left.Value <= right.Value;

    public static bool operator >(PartyBeaconID_t left, PartyBeaconID_t right) => left.Value > right.Value;

    public static bool operator >=(PartyBeaconID_t left, PartyBeaconID_t right) => left.Value >= right.Value;

    public static implicit operator PartyBeaconID_t(byte value) => new PartyBeaconID_t(value);

    public static explicit operator byte(PartyBeaconID_t value) => (byte)(value.Value);

    public static explicit operator PartyBeaconID_t(short value) => new PartyBeaconID_t(unchecked((ulong)(value)));

    public static explicit operator short(PartyBeaconID_t value) => (short)(value.Value);

    public static explicit operator PartyBeaconID_t(int value) => new PartyBeaconID_t(unchecked((ulong)(value)));

    public static explicit operator int(PartyBeaconID_t value) => (int)(value.Value);

    public static explicit operator PartyBeaconID_t(long value) => new PartyBeaconID_t(unchecked((ulong)(value)));

    public static explicit operator long(PartyBeaconID_t value) => (long)(value.Value);

    public static explicit operator PartyBeaconID_t(nint value) => new PartyBeaconID_t(unchecked((ulong)(value)));

    public static explicit operator nint(PartyBeaconID_t value) => (nint)(value.Value);

    public static explicit operator PartyBeaconID_t(sbyte value) => new PartyBeaconID_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(PartyBeaconID_t value) => (sbyte)(value.Value);

    public static implicit operator PartyBeaconID_t(ushort value) => new PartyBeaconID_t(value);

    public static explicit operator ushort(PartyBeaconID_t value) => (ushort)(value.Value);

    public static implicit operator PartyBeaconID_t(uint value) => new PartyBeaconID_t(value);

    public static explicit operator uint(PartyBeaconID_t value) => (uint)(value.Value);

    public static implicit operator PartyBeaconID_t(ulong value) => new PartyBeaconID_t(value);

    public static implicit operator ulong(PartyBeaconID_t value) => value.Value;

    public static implicit operator PartyBeaconID_t(nuint value) => new PartyBeaconID_t(value);

    public static explicit operator nuint(PartyBeaconID_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is PartyBeaconID_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of PartyBeaconID_t.");
    }

    public int CompareTo(PartyBeaconID_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is PartyBeaconID_t other) && Equals(other);

    public bool Equals(PartyBeaconID_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
