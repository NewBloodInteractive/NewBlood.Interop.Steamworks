using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct SteamItemDef_t : IComparable, IComparable<SteamItemDef_t>, IEquatable<SteamItemDef_t>, IFormattable
{
    public readonly int Value;

    public SteamItemDef_t(int value)
    {
        Value = value;
    }

    public static bool operator ==(SteamItemDef_t left, SteamItemDef_t right) => left.Value == right.Value;

    public static bool operator !=(SteamItemDef_t left, SteamItemDef_t right) => left.Value != right.Value;

    public static bool operator <(SteamItemDef_t left, SteamItemDef_t right) => left.Value < right.Value;

    public static bool operator <=(SteamItemDef_t left, SteamItemDef_t right) => left.Value <= right.Value;

    public static bool operator >(SteamItemDef_t left, SteamItemDef_t right) => left.Value > right.Value;

    public static bool operator >=(SteamItemDef_t left, SteamItemDef_t right) => left.Value >= right.Value;

    public static implicit operator SteamItemDef_t(byte value) => new SteamItemDef_t(value);

    public static explicit operator byte(SteamItemDef_t value) => (byte)(value.Value);

    public static implicit operator SteamItemDef_t(short value) => new SteamItemDef_t(value);

    public static explicit operator short(SteamItemDef_t value) => (short)(value.Value);

    public static implicit operator SteamItemDef_t(int value) => new SteamItemDef_t(value);

    public static implicit operator int(SteamItemDef_t value) => value.Value;

    public static explicit operator SteamItemDef_t(long value) => new SteamItemDef_t(unchecked((int)(value)));

    public static implicit operator long(SteamItemDef_t value) => value.Value;

    public static explicit operator SteamItemDef_t(nint value) => new SteamItemDef_t(unchecked((int)(value)));

    public static implicit operator nint(SteamItemDef_t value) => value.Value;

    public static implicit operator SteamItemDef_t(sbyte value) => new SteamItemDef_t(value);

    public static explicit operator sbyte(SteamItemDef_t value) => (sbyte)(value.Value);

    public static implicit operator SteamItemDef_t(ushort value) => new SteamItemDef_t(value);

    public static explicit operator ushort(SteamItemDef_t value) => (ushort)(value.Value);

    public static explicit operator SteamItemDef_t(uint value) => new SteamItemDef_t(unchecked((int)(value)));

    public static explicit operator uint(SteamItemDef_t value) => (uint)(value.Value);

    public static explicit operator SteamItemDef_t(ulong value) => new SteamItemDef_t(unchecked((int)(value)));

    public static explicit operator ulong(SteamItemDef_t value) => (ulong)(value.Value);

    public static explicit operator SteamItemDef_t(nuint value) => new SteamItemDef_t(unchecked((int)(value)));

    public static explicit operator nuint(SteamItemDef_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is SteamItemDef_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SteamItemDef_t.");
    }

    public int CompareTo(SteamItemDef_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is SteamItemDef_t other) && Equals(other);

    public bool Equals(SteamItemDef_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
