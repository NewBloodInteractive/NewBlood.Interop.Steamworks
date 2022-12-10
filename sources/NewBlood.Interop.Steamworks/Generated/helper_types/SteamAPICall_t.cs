using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct SteamAPICall_t : IComparable, IComparable<SteamAPICall_t>, IEquatable<SteamAPICall_t>, IFormattable
{
    public readonly ulong Value;

    public SteamAPICall_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(SteamAPICall_t left, SteamAPICall_t right) => left.Value == right.Value;

    public static bool operator !=(SteamAPICall_t left, SteamAPICall_t right) => left.Value != right.Value;

    public static bool operator <(SteamAPICall_t left, SteamAPICall_t right) => left.Value < right.Value;

    public static bool operator <=(SteamAPICall_t left, SteamAPICall_t right) => left.Value <= right.Value;

    public static bool operator >(SteamAPICall_t left, SteamAPICall_t right) => left.Value > right.Value;

    public static bool operator >=(SteamAPICall_t left, SteamAPICall_t right) => left.Value >= right.Value;

    public static implicit operator SteamAPICall_t(byte value) => new SteamAPICall_t(value);

    public static explicit operator byte(SteamAPICall_t value) => (byte)(value.Value);

    public static explicit operator SteamAPICall_t(short value) => new SteamAPICall_t(unchecked((ulong)(value)));

    public static explicit operator short(SteamAPICall_t value) => (short)(value.Value);

    public static explicit operator SteamAPICall_t(int value) => new SteamAPICall_t(unchecked((ulong)(value)));

    public static explicit operator int(SteamAPICall_t value) => (int)(value.Value);

    public static explicit operator SteamAPICall_t(long value) => new SteamAPICall_t(unchecked((ulong)(value)));

    public static explicit operator long(SteamAPICall_t value) => (long)(value.Value);

    public static explicit operator SteamAPICall_t(nint value) => new SteamAPICall_t(unchecked((ulong)(value)));

    public static explicit operator nint(SteamAPICall_t value) => (nint)(value.Value);

    public static explicit operator SteamAPICall_t(sbyte value) => new SteamAPICall_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(SteamAPICall_t value) => (sbyte)(value.Value);

    public static implicit operator SteamAPICall_t(ushort value) => new SteamAPICall_t(value);

    public static explicit operator ushort(SteamAPICall_t value) => (ushort)(value.Value);

    public static implicit operator SteamAPICall_t(uint value) => new SteamAPICall_t(value);

    public static explicit operator uint(SteamAPICall_t value) => (uint)(value.Value);

    public static implicit operator SteamAPICall_t(ulong value) => new SteamAPICall_t(value);

    public static implicit operator ulong(SteamAPICall_t value) => value.Value;

    public static implicit operator SteamAPICall_t(nuint value) => new SteamAPICall_t(value);

    public static explicit operator nuint(SteamAPICall_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is SteamAPICall_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SteamAPICall_t.");
    }

    public int CompareTo(SteamAPICall_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is SteamAPICall_t other) && Equals(other);

    public bool Equals(SteamAPICall_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
