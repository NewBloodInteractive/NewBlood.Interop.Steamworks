using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct ControllerDigitalActionHandle_t : IComparable, IComparable<ControllerDigitalActionHandle_t>, IEquatable<ControllerDigitalActionHandle_t>, IFormattable
{
    public readonly ulong Value;

    public ControllerDigitalActionHandle_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(ControllerDigitalActionHandle_t left, ControllerDigitalActionHandle_t right) => left.Value == right.Value;

    public static bool operator !=(ControllerDigitalActionHandle_t left, ControllerDigitalActionHandle_t right) => left.Value != right.Value;

    public static bool operator <(ControllerDigitalActionHandle_t left, ControllerDigitalActionHandle_t right) => left.Value < right.Value;

    public static bool operator <=(ControllerDigitalActionHandle_t left, ControllerDigitalActionHandle_t right) => left.Value <= right.Value;

    public static bool operator >(ControllerDigitalActionHandle_t left, ControllerDigitalActionHandle_t right) => left.Value > right.Value;

    public static bool operator >=(ControllerDigitalActionHandle_t left, ControllerDigitalActionHandle_t right) => left.Value >= right.Value;

    public static implicit operator ControllerDigitalActionHandle_t(byte value) => new ControllerDigitalActionHandle_t(value);

    public static explicit operator byte(ControllerDigitalActionHandle_t value) => (byte)(value.Value);

    public static explicit operator ControllerDigitalActionHandle_t(short value) => new ControllerDigitalActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator short(ControllerDigitalActionHandle_t value) => (short)(value.Value);

    public static explicit operator ControllerDigitalActionHandle_t(int value) => new ControllerDigitalActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator int(ControllerDigitalActionHandle_t value) => (int)(value.Value);

    public static explicit operator ControllerDigitalActionHandle_t(long value) => new ControllerDigitalActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator long(ControllerDigitalActionHandle_t value) => (long)(value.Value);

    public static explicit operator ControllerDigitalActionHandle_t(nint value) => new ControllerDigitalActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator nint(ControllerDigitalActionHandle_t value) => (nint)(value.Value);

    public static explicit operator ControllerDigitalActionHandle_t(sbyte value) => new ControllerDigitalActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(ControllerDigitalActionHandle_t value) => (sbyte)(value.Value);

    public static implicit operator ControllerDigitalActionHandle_t(ushort value) => new ControllerDigitalActionHandle_t(value);

    public static explicit operator ushort(ControllerDigitalActionHandle_t value) => (ushort)(value.Value);

    public static implicit operator ControllerDigitalActionHandle_t(uint value) => new ControllerDigitalActionHandle_t(value);

    public static explicit operator uint(ControllerDigitalActionHandle_t value) => (uint)(value.Value);

    public static implicit operator ControllerDigitalActionHandle_t(ulong value) => new ControllerDigitalActionHandle_t(value);

    public static implicit operator ulong(ControllerDigitalActionHandle_t value) => value.Value;

    public static implicit operator ControllerDigitalActionHandle_t(nuint value) => new ControllerDigitalActionHandle_t(value);

    public static explicit operator nuint(ControllerDigitalActionHandle_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is ControllerDigitalActionHandle_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of ControllerDigitalActionHandle_t.");
    }

    public int CompareTo(ControllerDigitalActionHandle_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is ControllerDigitalActionHandle_t other) && Equals(other);

    public bool Equals(ControllerDigitalActionHandle_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
