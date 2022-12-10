using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct SteamItemInstanceID_t : IComparable, IComparable<SteamItemInstanceID_t>, IEquatable<SteamItemInstanceID_t>, IFormattable
{
    public readonly ulong Value;

    public SteamItemInstanceID_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(SteamItemInstanceID_t left, SteamItemInstanceID_t right) => left.Value == right.Value;

    public static bool operator !=(SteamItemInstanceID_t left, SteamItemInstanceID_t right) => left.Value != right.Value;

    public static bool operator <(SteamItemInstanceID_t left, SteamItemInstanceID_t right) => left.Value < right.Value;

    public static bool operator <=(SteamItemInstanceID_t left, SteamItemInstanceID_t right) => left.Value <= right.Value;

    public static bool operator >(SteamItemInstanceID_t left, SteamItemInstanceID_t right) => left.Value > right.Value;

    public static bool operator >=(SteamItemInstanceID_t left, SteamItemInstanceID_t right) => left.Value >= right.Value;

    public static implicit operator SteamItemInstanceID_t(byte value) => new SteamItemInstanceID_t(value);

    public static explicit operator byte(SteamItemInstanceID_t value) => (byte)(value.Value);

    public static explicit operator SteamItemInstanceID_t(short value) => new SteamItemInstanceID_t(unchecked((ulong)(value)));

    public static explicit operator short(SteamItemInstanceID_t value) => (short)(value.Value);

    public static explicit operator SteamItemInstanceID_t(int value) => new SteamItemInstanceID_t(unchecked((ulong)(value)));

    public static explicit operator int(SteamItemInstanceID_t value) => (int)(value.Value);

    public static explicit operator SteamItemInstanceID_t(long value) => new SteamItemInstanceID_t(unchecked((ulong)(value)));

    public static explicit operator long(SteamItemInstanceID_t value) => (long)(value.Value);

    public static explicit operator SteamItemInstanceID_t(nint value) => new SteamItemInstanceID_t(unchecked((ulong)(value)));

    public static explicit operator nint(SteamItemInstanceID_t value) => (nint)(value.Value);

    public static explicit operator SteamItemInstanceID_t(sbyte value) => new SteamItemInstanceID_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(SteamItemInstanceID_t value) => (sbyte)(value.Value);

    public static implicit operator SteamItemInstanceID_t(ushort value) => new SteamItemInstanceID_t(value);

    public static explicit operator ushort(SteamItemInstanceID_t value) => (ushort)(value.Value);

    public static implicit operator SteamItemInstanceID_t(uint value) => new SteamItemInstanceID_t(value);

    public static explicit operator uint(SteamItemInstanceID_t value) => (uint)(value.Value);

    public static implicit operator SteamItemInstanceID_t(ulong value) => new SteamItemInstanceID_t(value);

    public static implicit operator ulong(SteamItemInstanceID_t value) => value.Value;

    public static implicit operator SteamItemInstanceID_t(nuint value) => new SteamItemInstanceID_t(value);

    public static explicit operator nuint(SteamItemInstanceID_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is SteamItemInstanceID_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SteamItemInstanceID_t.");
    }

    public int CompareTo(SteamItemInstanceID_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is SteamItemInstanceID_t other) && Equals(other);

    public bool Equals(SteamItemInstanceID_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
