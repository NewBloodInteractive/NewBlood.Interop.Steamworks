using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct SteamInventoryResult_t : IComparable, IComparable<SteamInventoryResult_t>, IEquatable<SteamInventoryResult_t>, IFormattable
{
    public readonly int Value;

    public SteamInventoryResult_t(int value)
    {
        Value = value;
    }

    public static bool operator ==(SteamInventoryResult_t left, SteamInventoryResult_t right) => left.Value == right.Value;

    public static bool operator !=(SteamInventoryResult_t left, SteamInventoryResult_t right) => left.Value != right.Value;

    public static bool operator <(SteamInventoryResult_t left, SteamInventoryResult_t right) => left.Value < right.Value;

    public static bool operator <=(SteamInventoryResult_t left, SteamInventoryResult_t right) => left.Value <= right.Value;

    public static bool operator >(SteamInventoryResult_t left, SteamInventoryResult_t right) => left.Value > right.Value;

    public static bool operator >=(SteamInventoryResult_t left, SteamInventoryResult_t right) => left.Value >= right.Value;

    public static implicit operator SteamInventoryResult_t(byte value) => new SteamInventoryResult_t(value);

    public static explicit operator byte(SteamInventoryResult_t value) => (byte)(value.Value);

    public static implicit operator SteamInventoryResult_t(short value) => new SteamInventoryResult_t(value);

    public static explicit operator short(SteamInventoryResult_t value) => (short)(value.Value);

    public static implicit operator SteamInventoryResult_t(int value) => new SteamInventoryResult_t(value);

    public static implicit operator int(SteamInventoryResult_t value) => value.Value;

    public static explicit operator SteamInventoryResult_t(long value) => new SteamInventoryResult_t(unchecked((int)(value)));

    public static implicit operator long(SteamInventoryResult_t value) => value.Value;

    public static explicit operator SteamInventoryResult_t(nint value) => new SteamInventoryResult_t(unchecked((int)(value)));

    public static implicit operator nint(SteamInventoryResult_t value) => value.Value;

    public static implicit operator SteamInventoryResult_t(sbyte value) => new SteamInventoryResult_t(value);

    public static explicit operator sbyte(SteamInventoryResult_t value) => (sbyte)(value.Value);

    public static implicit operator SteamInventoryResult_t(ushort value) => new SteamInventoryResult_t(value);

    public static explicit operator ushort(SteamInventoryResult_t value) => (ushort)(value.Value);

    public static explicit operator SteamInventoryResult_t(uint value) => new SteamInventoryResult_t(unchecked((int)(value)));

    public static explicit operator uint(SteamInventoryResult_t value) => (uint)(value.Value);

    public static explicit operator SteamInventoryResult_t(ulong value) => new SteamInventoryResult_t(unchecked((int)(value)));

    public static explicit operator ulong(SteamInventoryResult_t value) => (ulong)(value.Value);

    public static explicit operator SteamInventoryResult_t(nuint value) => new SteamInventoryResult_t(unchecked((int)(value)));

    public static explicit operator nuint(SteamInventoryResult_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is SteamInventoryResult_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SteamInventoryResult_t.");
    }

    public int CompareTo(SteamInventoryResult_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is SteamInventoryResult_t other) && Equals(other);

    public bool Equals(SteamInventoryResult_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
