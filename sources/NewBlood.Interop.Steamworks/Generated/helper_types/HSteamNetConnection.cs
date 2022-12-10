using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct HSteamNetConnection : IComparable, IComparable<HSteamNetConnection>, IEquatable<HSteamNetConnection>, IFormattable
{
    public readonly uint Value;

    public HSteamNetConnection(uint value)
    {
        Value = value;
    }

    public static bool operator ==(HSteamNetConnection left, HSteamNetConnection right) => left.Value == right.Value;

    public static bool operator !=(HSteamNetConnection left, HSteamNetConnection right) => left.Value != right.Value;

    public static bool operator <(HSteamNetConnection left, HSteamNetConnection right) => left.Value < right.Value;

    public static bool operator <=(HSteamNetConnection left, HSteamNetConnection right) => left.Value <= right.Value;

    public static bool operator >(HSteamNetConnection left, HSteamNetConnection right) => left.Value > right.Value;

    public static bool operator >=(HSteamNetConnection left, HSteamNetConnection right) => left.Value >= right.Value;

    public static implicit operator HSteamNetConnection(byte value) => new HSteamNetConnection(value);

    public static explicit operator byte(HSteamNetConnection value) => (byte)(value.Value);

    public static explicit operator HSteamNetConnection(short value) => new HSteamNetConnection(unchecked((uint)(value)));

    public static explicit operator short(HSteamNetConnection value) => (short)(value.Value);

    public static explicit operator HSteamNetConnection(int value) => new HSteamNetConnection(unchecked((uint)(value)));

    public static explicit operator int(HSteamNetConnection value) => (int)(value.Value);

    public static explicit operator HSteamNetConnection(long value) => new HSteamNetConnection(unchecked((uint)(value)));

    public static implicit operator long(HSteamNetConnection value) => value.Value;

    public static explicit operator HSteamNetConnection(nint value) => new HSteamNetConnection(unchecked((uint)(value)));

    public static explicit operator nint(HSteamNetConnection value) => (nint)(value.Value);

    public static explicit operator HSteamNetConnection(sbyte value) => new HSteamNetConnection(unchecked((uint)(value)));

    public static explicit operator sbyte(HSteamNetConnection value) => (sbyte)(value.Value);

    public static implicit operator HSteamNetConnection(ushort value) => new HSteamNetConnection(value);

    public static explicit operator ushort(HSteamNetConnection value) => (ushort)(value.Value);

    public static implicit operator HSteamNetConnection(uint value) => new HSteamNetConnection(value);

    public static implicit operator uint(HSteamNetConnection value) => value.Value;

    public static explicit operator HSteamNetConnection(ulong value) => new HSteamNetConnection(unchecked((uint)(value)));

    public static implicit operator ulong(HSteamNetConnection value) => value.Value;

    public static explicit operator HSteamNetConnection(nuint value) => new HSteamNetConnection(unchecked((uint)(value)));

    public static implicit operator nuint(HSteamNetConnection value) => value.Value;

    public int CompareTo(object? obj)
    {
            if (obj is HSteamNetConnection other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HSteamNetConnection.");
    }

    public int CompareTo(HSteamNetConnection other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is HSteamNetConnection other) && Equals(other);

    public bool Equals(HSteamNetConnection other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
