using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct HSteamPipe : IComparable, IComparable<HSteamPipe>, IEquatable<HSteamPipe>, IFormattable
{
    public readonly int Value;

    public HSteamPipe(int value)
    {
        Value = value;
    }

    public static bool operator ==(HSteamPipe left, HSteamPipe right) => left.Value == right.Value;

    public static bool operator !=(HSteamPipe left, HSteamPipe right) => left.Value != right.Value;

    public static bool operator <(HSteamPipe left, HSteamPipe right) => left.Value < right.Value;

    public static bool operator <=(HSteamPipe left, HSteamPipe right) => left.Value <= right.Value;

    public static bool operator >(HSteamPipe left, HSteamPipe right) => left.Value > right.Value;

    public static bool operator >=(HSteamPipe left, HSteamPipe right) => left.Value >= right.Value;

    public static implicit operator HSteamPipe(byte value) => new HSteamPipe(value);

    public static explicit operator byte(HSteamPipe value) => (byte)(value.Value);

    public static implicit operator HSteamPipe(short value) => new HSteamPipe(value);

    public static explicit operator short(HSteamPipe value) => (short)(value.Value);

    public static implicit operator HSteamPipe(int value) => new HSteamPipe(value);

    public static implicit operator int(HSteamPipe value) => value.Value;

    public static explicit operator HSteamPipe(long value) => new HSteamPipe(unchecked((int)(value)));

    public static implicit operator long(HSteamPipe value) => value.Value;

    public static explicit operator HSteamPipe(nint value) => new HSteamPipe(unchecked((int)(value)));

    public static implicit operator nint(HSteamPipe value) => value.Value;

    public static implicit operator HSteamPipe(sbyte value) => new HSteamPipe(value);

    public static explicit operator sbyte(HSteamPipe value) => (sbyte)(value.Value);

    public static implicit operator HSteamPipe(ushort value) => new HSteamPipe(value);

    public static explicit operator ushort(HSteamPipe value) => (ushort)(value.Value);

    public static explicit operator HSteamPipe(uint value) => new HSteamPipe(unchecked((int)(value)));

    public static explicit operator uint(HSteamPipe value) => (uint)(value.Value);

    public static explicit operator HSteamPipe(ulong value) => new HSteamPipe(unchecked((int)(value)));

    public static explicit operator ulong(HSteamPipe value) => (ulong)(value.Value);

    public static explicit operator HSteamPipe(nuint value) => new HSteamPipe(unchecked((int)(value)));

    public static explicit operator nuint(HSteamPipe value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is HSteamPipe other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HSteamPipe.");
    }

    public int CompareTo(HSteamPipe other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is HSteamPipe other) && Equals(other);

    public bool Equals(HSteamPipe other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
