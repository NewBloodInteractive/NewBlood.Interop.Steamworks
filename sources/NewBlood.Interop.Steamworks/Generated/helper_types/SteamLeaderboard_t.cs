using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct SteamLeaderboard_t : IComparable, IComparable<SteamLeaderboard_t>, IEquatable<SteamLeaderboard_t>, IFormattable
{
    public readonly ulong Value;

    public SteamLeaderboard_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(SteamLeaderboard_t left, SteamLeaderboard_t right) => left.Value == right.Value;

    public static bool operator !=(SteamLeaderboard_t left, SteamLeaderboard_t right) => left.Value != right.Value;

    public static bool operator <(SteamLeaderboard_t left, SteamLeaderboard_t right) => left.Value < right.Value;

    public static bool operator <=(SteamLeaderboard_t left, SteamLeaderboard_t right) => left.Value <= right.Value;

    public static bool operator >(SteamLeaderboard_t left, SteamLeaderboard_t right) => left.Value > right.Value;

    public static bool operator >=(SteamLeaderboard_t left, SteamLeaderboard_t right) => left.Value >= right.Value;

    public static implicit operator SteamLeaderboard_t(byte value) => new SteamLeaderboard_t(value);

    public static explicit operator byte(SteamLeaderboard_t value) => (byte)(value.Value);

    public static explicit operator SteamLeaderboard_t(short value) => new SteamLeaderboard_t(unchecked((ulong)(value)));

    public static explicit operator short(SteamLeaderboard_t value) => (short)(value.Value);

    public static explicit operator SteamLeaderboard_t(int value) => new SteamLeaderboard_t(unchecked((ulong)(value)));

    public static explicit operator int(SteamLeaderboard_t value) => (int)(value.Value);

    public static explicit operator SteamLeaderboard_t(long value) => new SteamLeaderboard_t(unchecked((ulong)(value)));

    public static explicit operator long(SteamLeaderboard_t value) => (long)(value.Value);

    public static explicit operator SteamLeaderboard_t(nint value) => new SteamLeaderboard_t(unchecked((ulong)(value)));

    public static explicit operator nint(SteamLeaderboard_t value) => (nint)(value.Value);

    public static explicit operator SteamLeaderboard_t(sbyte value) => new SteamLeaderboard_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(SteamLeaderboard_t value) => (sbyte)(value.Value);

    public static implicit operator SteamLeaderboard_t(ushort value) => new SteamLeaderboard_t(value);

    public static explicit operator ushort(SteamLeaderboard_t value) => (ushort)(value.Value);

    public static implicit operator SteamLeaderboard_t(uint value) => new SteamLeaderboard_t(value);

    public static explicit operator uint(SteamLeaderboard_t value) => (uint)(value.Value);

    public static implicit operator SteamLeaderboard_t(ulong value) => new SteamLeaderboard_t(value);

    public static implicit operator ulong(SteamLeaderboard_t value) => value.Value;

    public static implicit operator SteamLeaderboard_t(nuint value) => new SteamLeaderboard_t(value);

    public static explicit operator nuint(SteamLeaderboard_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is SteamLeaderboard_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SteamLeaderboard_t.");
    }

    public int CompareTo(SteamLeaderboard_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is SteamLeaderboard_t other) && Equals(other);

    public bool Equals(SteamLeaderboard_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
