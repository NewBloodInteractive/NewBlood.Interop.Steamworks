using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct ControllerAnalogActionHandle_t : IComparable, IComparable<ControllerAnalogActionHandle_t>, IEquatable<ControllerAnalogActionHandle_t>, IFormattable
{
    public readonly ulong Value;

    public ControllerAnalogActionHandle_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(ControllerAnalogActionHandle_t left, ControllerAnalogActionHandle_t right) => left.Value == right.Value;

    public static bool operator !=(ControllerAnalogActionHandle_t left, ControllerAnalogActionHandle_t right) => left.Value != right.Value;

    public static bool operator <(ControllerAnalogActionHandle_t left, ControllerAnalogActionHandle_t right) => left.Value < right.Value;

    public static bool operator <=(ControllerAnalogActionHandle_t left, ControllerAnalogActionHandle_t right) => left.Value <= right.Value;

    public static bool operator >(ControllerAnalogActionHandle_t left, ControllerAnalogActionHandle_t right) => left.Value > right.Value;

    public static bool operator >=(ControllerAnalogActionHandle_t left, ControllerAnalogActionHandle_t right) => left.Value >= right.Value;

    public static implicit operator ControllerAnalogActionHandle_t(byte value) => new ControllerAnalogActionHandle_t(value);

    public static explicit operator byte(ControllerAnalogActionHandle_t value) => (byte)(value.Value);

    public static explicit operator ControllerAnalogActionHandle_t(short value) => new ControllerAnalogActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator short(ControllerAnalogActionHandle_t value) => (short)(value.Value);

    public static explicit operator ControllerAnalogActionHandle_t(int value) => new ControllerAnalogActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator int(ControllerAnalogActionHandle_t value) => (int)(value.Value);

    public static explicit operator ControllerAnalogActionHandle_t(long value) => new ControllerAnalogActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator long(ControllerAnalogActionHandle_t value) => (long)(value.Value);

    public static explicit operator ControllerAnalogActionHandle_t(nint value) => new ControllerAnalogActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator nint(ControllerAnalogActionHandle_t value) => (nint)(value.Value);

    public static explicit operator ControllerAnalogActionHandle_t(sbyte value) => new ControllerAnalogActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(ControllerAnalogActionHandle_t value) => (sbyte)(value.Value);

    public static implicit operator ControllerAnalogActionHandle_t(ushort value) => new ControllerAnalogActionHandle_t(value);

    public static explicit operator ushort(ControllerAnalogActionHandle_t value) => (ushort)(value.Value);

    public static implicit operator ControllerAnalogActionHandle_t(uint value) => new ControllerAnalogActionHandle_t(value);

    public static explicit operator uint(ControllerAnalogActionHandle_t value) => (uint)(value.Value);

    public static implicit operator ControllerAnalogActionHandle_t(ulong value) => new ControllerAnalogActionHandle_t(value);

    public static implicit operator ulong(ControllerAnalogActionHandle_t value) => value.Value;

    public static implicit operator ControllerAnalogActionHandle_t(nuint value) => new ControllerAnalogActionHandle_t(value);

    public static explicit operator nuint(ControllerAnalogActionHandle_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is ControllerAnalogActionHandle_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of ControllerAnalogActionHandle_t.");
    }

    public int CompareTo(ControllerAnalogActionHandle_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is ControllerAnalogActionHandle_t other) && Equals(other);

    public bool Equals(ControllerAnalogActionHandle_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
