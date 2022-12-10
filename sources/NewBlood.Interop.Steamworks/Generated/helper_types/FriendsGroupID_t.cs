using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct FriendsGroupID_t : IComparable, IComparable<FriendsGroupID_t>, IEquatable<FriendsGroupID_t>, IFormattable
{
    public readonly short Value;

    public FriendsGroupID_t(short value)
    {
        Value = value;
    }

    public static bool operator ==(FriendsGroupID_t left, FriendsGroupID_t right) => left.Value == right.Value;

    public static bool operator !=(FriendsGroupID_t left, FriendsGroupID_t right) => left.Value != right.Value;

    public static bool operator <(FriendsGroupID_t left, FriendsGroupID_t right) => left.Value < right.Value;

    public static bool operator <=(FriendsGroupID_t left, FriendsGroupID_t right) => left.Value <= right.Value;

    public static bool operator >(FriendsGroupID_t left, FriendsGroupID_t right) => left.Value > right.Value;

    public static bool operator >=(FriendsGroupID_t left, FriendsGroupID_t right) => left.Value >= right.Value;

    public static implicit operator FriendsGroupID_t(byte value) => new FriendsGroupID_t(value);

    public static explicit operator byte(FriendsGroupID_t value) => (byte)(value.Value);

    public static implicit operator FriendsGroupID_t(short value) => new FriendsGroupID_t(value);

    public static implicit operator short(FriendsGroupID_t value) => value.Value;

    public static explicit operator FriendsGroupID_t(int value) => new FriendsGroupID_t(unchecked((short)(value)));

    public static implicit operator int(FriendsGroupID_t value) => value.Value;

    public static explicit operator FriendsGroupID_t(long value) => new FriendsGroupID_t(unchecked((short)(value)));

    public static implicit operator long(FriendsGroupID_t value) => value.Value;

    public static explicit operator FriendsGroupID_t(nint value) => new FriendsGroupID_t(unchecked((short)(value)));

    public static implicit operator nint(FriendsGroupID_t value) => value.Value;

    public static implicit operator FriendsGroupID_t(sbyte value) => new FriendsGroupID_t(value);

    public static explicit operator sbyte(FriendsGroupID_t value) => (sbyte)(value.Value);

    public static explicit operator FriendsGroupID_t(ushort value) => new FriendsGroupID_t(unchecked((short)(value)));

    public static explicit operator ushort(FriendsGroupID_t value) => (ushort)(value.Value);

    public static explicit operator FriendsGroupID_t(uint value) => new FriendsGroupID_t(unchecked((short)(value)));

    public static explicit operator uint(FriendsGroupID_t value) => (uint)(value.Value);

    public static explicit operator FriendsGroupID_t(ulong value) => new FriendsGroupID_t(unchecked((short)(value)));

    public static explicit operator ulong(FriendsGroupID_t value) => (ulong)(value.Value);

    public static explicit operator FriendsGroupID_t(nuint value) => new FriendsGroupID_t(unchecked((short)(value)));

    public static explicit operator nuint(FriendsGroupID_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is FriendsGroupID_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of FriendsGroupID_t.");
    }

    public int CompareTo(FriendsGroupID_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is FriendsGroupID_t other) && Equals(other);

    public bool Equals(FriendsGroupID_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
