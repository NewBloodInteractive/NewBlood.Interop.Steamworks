using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct SteamInventoryUpdateHandle_t : IComparable, IComparable<SteamInventoryUpdateHandle_t>, IEquatable<SteamInventoryUpdateHandle_t>, IFormattable
{
    public readonly ulong Value;

    public SteamInventoryUpdateHandle_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(SteamInventoryUpdateHandle_t left, SteamInventoryUpdateHandle_t right) => left.Value == right.Value;

    public static bool operator !=(SteamInventoryUpdateHandle_t left, SteamInventoryUpdateHandle_t right) => left.Value != right.Value;

    public static bool operator <(SteamInventoryUpdateHandle_t left, SteamInventoryUpdateHandle_t right) => left.Value < right.Value;

    public static bool operator <=(SteamInventoryUpdateHandle_t left, SteamInventoryUpdateHandle_t right) => left.Value <= right.Value;

    public static bool operator >(SteamInventoryUpdateHandle_t left, SteamInventoryUpdateHandle_t right) => left.Value > right.Value;

    public static bool operator >=(SteamInventoryUpdateHandle_t left, SteamInventoryUpdateHandle_t right) => left.Value >= right.Value;

    public static implicit operator SteamInventoryUpdateHandle_t(byte value) => new SteamInventoryUpdateHandle_t(value);

    public static explicit operator byte(SteamInventoryUpdateHandle_t value) => (byte)(value.Value);

    public static explicit operator SteamInventoryUpdateHandle_t(short value) => new SteamInventoryUpdateHandle_t(unchecked((ulong)(value)));

    public static explicit operator short(SteamInventoryUpdateHandle_t value) => (short)(value.Value);

    public static explicit operator SteamInventoryUpdateHandle_t(int value) => new SteamInventoryUpdateHandle_t(unchecked((ulong)(value)));

    public static explicit operator int(SteamInventoryUpdateHandle_t value) => (int)(value.Value);

    public static explicit operator SteamInventoryUpdateHandle_t(long value) => new SteamInventoryUpdateHandle_t(unchecked((ulong)(value)));

    public static explicit operator long(SteamInventoryUpdateHandle_t value) => (long)(value.Value);

    public static explicit operator SteamInventoryUpdateHandle_t(nint value) => new SteamInventoryUpdateHandle_t(unchecked((ulong)(value)));

    public static explicit operator nint(SteamInventoryUpdateHandle_t value) => (nint)(value.Value);

    public static explicit operator SteamInventoryUpdateHandle_t(sbyte value) => new SteamInventoryUpdateHandle_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(SteamInventoryUpdateHandle_t value) => (sbyte)(value.Value);

    public static implicit operator SteamInventoryUpdateHandle_t(ushort value) => new SteamInventoryUpdateHandle_t(value);

    public static explicit operator ushort(SteamInventoryUpdateHandle_t value) => (ushort)(value.Value);

    public static implicit operator SteamInventoryUpdateHandle_t(uint value) => new SteamInventoryUpdateHandle_t(value);

    public static explicit operator uint(SteamInventoryUpdateHandle_t value) => (uint)(value.Value);

    public static implicit operator SteamInventoryUpdateHandle_t(ulong value) => new SteamInventoryUpdateHandle_t(value);

    public static implicit operator ulong(SteamInventoryUpdateHandle_t value) => value.Value;

    public static implicit operator SteamInventoryUpdateHandle_t(nuint value) => new SteamInventoryUpdateHandle_t(value);

    public static explicit operator nuint(SteamInventoryUpdateHandle_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is SteamInventoryUpdateHandle_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SteamInventoryUpdateHandle_t.");
    }

    public int CompareTo(SteamInventoryUpdateHandle_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is SteamInventoryUpdateHandle_t other) && Equals(other);

    public bool Equals(SteamInventoryUpdateHandle_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
