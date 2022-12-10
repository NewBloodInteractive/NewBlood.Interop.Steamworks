using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct HSteamUser : IComparable, IComparable<HSteamUser>, IEquatable<HSteamUser>, IFormattable
{
    public readonly int Value;

    public HSteamUser(int value)
    {
        Value = value;
    }

    public static bool operator ==(HSteamUser left, HSteamUser right) => left.Value == right.Value;

    public static bool operator !=(HSteamUser left, HSteamUser right) => left.Value != right.Value;

    public static bool operator <(HSteamUser left, HSteamUser right) => left.Value < right.Value;

    public static bool operator <=(HSteamUser left, HSteamUser right) => left.Value <= right.Value;

    public static bool operator >(HSteamUser left, HSteamUser right) => left.Value > right.Value;

    public static bool operator >=(HSteamUser left, HSteamUser right) => left.Value >= right.Value;

    public static implicit operator HSteamUser(byte value) => new HSteamUser(value);

    public static explicit operator byte(HSteamUser value) => (byte)(value.Value);

    public static implicit operator HSteamUser(short value) => new HSteamUser(value);

    public static explicit operator short(HSteamUser value) => (short)(value.Value);

    public static implicit operator HSteamUser(int value) => new HSteamUser(value);

    public static implicit operator int(HSteamUser value) => value.Value;

    public static explicit operator HSteamUser(long value) => new HSteamUser(unchecked((int)(value)));

    public static implicit operator long(HSteamUser value) => value.Value;

    public static explicit operator HSteamUser(nint value) => new HSteamUser(unchecked((int)(value)));

    public static implicit operator nint(HSteamUser value) => value.Value;

    public static implicit operator HSteamUser(sbyte value) => new HSteamUser(value);

    public static explicit operator sbyte(HSteamUser value) => (sbyte)(value.Value);

    public static implicit operator HSteamUser(ushort value) => new HSteamUser(value);

    public static explicit operator ushort(HSteamUser value) => (ushort)(value.Value);

    public static explicit operator HSteamUser(uint value) => new HSteamUser(unchecked((int)(value)));

    public static explicit operator uint(HSteamUser value) => (uint)(value.Value);

    public static explicit operator HSteamUser(ulong value) => new HSteamUser(unchecked((int)(value)));

    public static explicit operator ulong(HSteamUser value) => (ulong)(value.Value);

    public static explicit operator HSteamUser(nuint value) => new HSteamUser(unchecked((int)(value)));

    public static explicit operator nuint(HSteamUser value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is HSteamUser other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HSteamUser.");
    }

    public int CompareTo(HSteamUser other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is HSteamUser other) && Equals(other);

    public bool Equals(HSteamUser other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
