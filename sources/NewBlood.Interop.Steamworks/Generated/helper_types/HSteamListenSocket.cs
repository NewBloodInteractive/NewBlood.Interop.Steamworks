using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct HSteamListenSocket : IComparable, IComparable<HSteamListenSocket>, IEquatable<HSteamListenSocket>, IFormattable
{
    public readonly uint Value;

    public HSteamListenSocket(uint value)
    {
        Value = value;
    }

    public static bool operator ==(HSteamListenSocket left, HSteamListenSocket right) => left.Value == right.Value;

    public static bool operator !=(HSteamListenSocket left, HSteamListenSocket right) => left.Value != right.Value;

    public static bool operator <(HSteamListenSocket left, HSteamListenSocket right) => left.Value < right.Value;

    public static bool operator <=(HSteamListenSocket left, HSteamListenSocket right) => left.Value <= right.Value;

    public static bool operator >(HSteamListenSocket left, HSteamListenSocket right) => left.Value > right.Value;

    public static bool operator >=(HSteamListenSocket left, HSteamListenSocket right) => left.Value >= right.Value;

    public static implicit operator HSteamListenSocket(byte value) => new HSteamListenSocket(value);

    public static explicit operator byte(HSteamListenSocket value) => (byte)(value.Value);

    public static explicit operator HSteamListenSocket(short value) => new HSteamListenSocket(unchecked((uint)(value)));

    public static explicit operator short(HSteamListenSocket value) => (short)(value.Value);

    public static explicit operator HSteamListenSocket(int value) => new HSteamListenSocket(unchecked((uint)(value)));

    public static explicit operator int(HSteamListenSocket value) => (int)(value.Value);

    public static explicit operator HSteamListenSocket(long value) => new HSteamListenSocket(unchecked((uint)(value)));

    public static implicit operator long(HSteamListenSocket value) => value.Value;

    public static explicit operator HSteamListenSocket(nint value) => new HSteamListenSocket(unchecked((uint)(value)));

    public static explicit operator nint(HSteamListenSocket value) => (nint)(value.Value);

    public static explicit operator HSteamListenSocket(sbyte value) => new HSteamListenSocket(unchecked((uint)(value)));

    public static explicit operator sbyte(HSteamListenSocket value) => (sbyte)(value.Value);

    public static implicit operator HSteamListenSocket(ushort value) => new HSteamListenSocket(value);

    public static explicit operator ushort(HSteamListenSocket value) => (ushort)(value.Value);

    public static implicit operator HSteamListenSocket(uint value) => new HSteamListenSocket(value);

    public static implicit operator uint(HSteamListenSocket value) => value.Value;

    public static explicit operator HSteamListenSocket(ulong value) => new HSteamListenSocket(unchecked((uint)(value)));

    public static implicit operator ulong(HSteamListenSocket value) => value.Value;

    public static explicit operator HSteamListenSocket(nuint value) => new HSteamListenSocket(unchecked((uint)(value)));

    public static implicit operator nuint(HSteamListenSocket value) => value.Value;

    public int CompareTo(object? obj)
    {
            if (obj is HSteamListenSocket other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HSteamListenSocket.");
    }

    public int CompareTo(HSteamListenSocket other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is HSteamListenSocket other) && Equals(other);

    public bool Equals(HSteamListenSocket other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
