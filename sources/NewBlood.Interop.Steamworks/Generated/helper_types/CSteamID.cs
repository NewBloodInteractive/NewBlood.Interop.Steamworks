using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct CSteamID : IComparable, IComparable<CSteamID>, IEquatable<CSteamID>, IFormattable
{
    public readonly ulong Value;

    public CSteamID(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(CSteamID left, CSteamID right) => left.Value == right.Value;

    public static bool operator !=(CSteamID left, CSteamID right) => left.Value != right.Value;

    public static bool operator <(CSteamID left, CSteamID right) => left.Value < right.Value;

    public static bool operator <=(CSteamID left, CSteamID right) => left.Value <= right.Value;

    public static bool operator >(CSteamID left, CSteamID right) => left.Value > right.Value;

    public static bool operator >=(CSteamID left, CSteamID right) => left.Value >= right.Value;

    public static implicit operator CSteamID(byte value) => new CSteamID(value);

    public static explicit operator byte(CSteamID value) => (byte)(value.Value);

    public static explicit operator CSteamID(short value) => new CSteamID(unchecked((ulong)(value)));

    public static explicit operator short(CSteamID value) => (short)(value.Value);

    public static explicit operator CSteamID(int value) => new CSteamID(unchecked((ulong)(value)));

    public static explicit operator int(CSteamID value) => (int)(value.Value);

    public static explicit operator CSteamID(long value) => new CSteamID(unchecked((ulong)(value)));

    public static explicit operator long(CSteamID value) => (long)(value.Value);

    public static explicit operator CSteamID(nint value) => new CSteamID(unchecked((ulong)(value)));

    public static explicit operator nint(CSteamID value) => (nint)(value.Value);

    public static explicit operator CSteamID(sbyte value) => new CSteamID(unchecked((ulong)(value)));

    public static explicit operator sbyte(CSteamID value) => (sbyte)(value.Value);

    public static implicit operator CSteamID(ushort value) => new CSteamID(value);

    public static explicit operator ushort(CSteamID value) => (ushort)(value.Value);

    public static implicit operator CSteamID(uint value) => new CSteamID(value);

    public static explicit operator uint(CSteamID value) => (uint)(value.Value);

    public static implicit operator CSteamID(ulong value) => new CSteamID(value);

    public static implicit operator ulong(CSteamID value) => value.Value;

    public static implicit operator CSteamID(nuint value) => new CSteamID(value);

    public static explicit operator nuint(CSteamID value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is CSteamID other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of CSteamID.");
    }

    public int CompareTo(CSteamID other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is CSteamID other) && Equals(other);

    public bool Equals(CSteamID other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
