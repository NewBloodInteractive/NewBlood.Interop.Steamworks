using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct SteamLeaderboardEntries_t : IComparable, IComparable<SteamLeaderboardEntries_t>, IEquatable<SteamLeaderboardEntries_t>, IFormattable
{
    public readonly ulong Value;

    public SteamLeaderboardEntries_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(SteamLeaderboardEntries_t left, SteamLeaderboardEntries_t right) => left.Value == right.Value;

    public static bool operator !=(SteamLeaderboardEntries_t left, SteamLeaderboardEntries_t right) => left.Value != right.Value;

    public static bool operator <(SteamLeaderboardEntries_t left, SteamLeaderboardEntries_t right) => left.Value < right.Value;

    public static bool operator <=(SteamLeaderboardEntries_t left, SteamLeaderboardEntries_t right) => left.Value <= right.Value;

    public static bool operator >(SteamLeaderboardEntries_t left, SteamLeaderboardEntries_t right) => left.Value > right.Value;

    public static bool operator >=(SteamLeaderboardEntries_t left, SteamLeaderboardEntries_t right) => left.Value >= right.Value;

    public static implicit operator SteamLeaderboardEntries_t(byte value) => new SteamLeaderboardEntries_t(value);

    public static explicit operator byte(SteamLeaderboardEntries_t value) => (byte)(value.Value);

    public static explicit operator SteamLeaderboardEntries_t(short value) => new SteamLeaderboardEntries_t(unchecked((ulong)(value)));

    public static explicit operator short(SteamLeaderboardEntries_t value) => (short)(value.Value);

    public static explicit operator SteamLeaderboardEntries_t(int value) => new SteamLeaderboardEntries_t(unchecked((ulong)(value)));

    public static explicit operator int(SteamLeaderboardEntries_t value) => (int)(value.Value);

    public static explicit operator SteamLeaderboardEntries_t(long value) => new SteamLeaderboardEntries_t(unchecked((ulong)(value)));

    public static explicit operator long(SteamLeaderboardEntries_t value) => (long)(value.Value);

    public static explicit operator SteamLeaderboardEntries_t(nint value) => new SteamLeaderboardEntries_t(unchecked((ulong)(value)));

    public static explicit operator nint(SteamLeaderboardEntries_t value) => (nint)(value.Value);

    public static explicit operator SteamLeaderboardEntries_t(sbyte value) => new SteamLeaderboardEntries_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(SteamLeaderboardEntries_t value) => (sbyte)(value.Value);

    public static implicit operator SteamLeaderboardEntries_t(ushort value) => new SteamLeaderboardEntries_t(value);

    public static explicit operator ushort(SteamLeaderboardEntries_t value) => (ushort)(value.Value);

    public static implicit operator SteamLeaderboardEntries_t(uint value) => new SteamLeaderboardEntries_t(value);

    public static explicit operator uint(SteamLeaderboardEntries_t value) => (uint)(value.Value);

    public static implicit operator SteamLeaderboardEntries_t(ulong value) => new SteamLeaderboardEntries_t(value);

    public static implicit operator ulong(SteamLeaderboardEntries_t value) => value.Value;

    public static implicit operator SteamLeaderboardEntries_t(nuint value) => new SteamLeaderboardEntries_t(value);

    public static explicit operator nuint(SteamLeaderboardEntries_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is SteamLeaderboardEntries_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SteamLeaderboardEntries_t.");
    }

    public int CompareTo(SteamLeaderboardEntries_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is SteamLeaderboardEntries_t other) && Equals(other);

    public bool Equals(SteamLeaderboardEntries_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
