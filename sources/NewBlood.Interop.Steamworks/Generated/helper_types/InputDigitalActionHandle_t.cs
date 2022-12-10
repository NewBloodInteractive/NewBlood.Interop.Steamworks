using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct InputDigitalActionHandle_t : IComparable, IComparable<InputDigitalActionHandle_t>, IEquatable<InputDigitalActionHandle_t>, IFormattable
{
    public readonly ulong Value;

    public InputDigitalActionHandle_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(InputDigitalActionHandle_t left, InputDigitalActionHandle_t right) => left.Value == right.Value;

    public static bool operator !=(InputDigitalActionHandle_t left, InputDigitalActionHandle_t right) => left.Value != right.Value;

    public static bool operator <(InputDigitalActionHandle_t left, InputDigitalActionHandle_t right) => left.Value < right.Value;

    public static bool operator <=(InputDigitalActionHandle_t left, InputDigitalActionHandle_t right) => left.Value <= right.Value;

    public static bool operator >(InputDigitalActionHandle_t left, InputDigitalActionHandle_t right) => left.Value > right.Value;

    public static bool operator >=(InputDigitalActionHandle_t left, InputDigitalActionHandle_t right) => left.Value >= right.Value;

    public static implicit operator InputDigitalActionHandle_t(byte value) => new InputDigitalActionHandle_t(value);

    public static explicit operator byte(InputDigitalActionHandle_t value) => (byte)(value.Value);

    public static explicit operator InputDigitalActionHandle_t(short value) => new InputDigitalActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator short(InputDigitalActionHandle_t value) => (short)(value.Value);

    public static explicit operator InputDigitalActionHandle_t(int value) => new InputDigitalActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator int(InputDigitalActionHandle_t value) => (int)(value.Value);

    public static explicit operator InputDigitalActionHandle_t(long value) => new InputDigitalActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator long(InputDigitalActionHandle_t value) => (long)(value.Value);

    public static explicit operator InputDigitalActionHandle_t(nint value) => new InputDigitalActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator nint(InputDigitalActionHandle_t value) => (nint)(value.Value);

    public static explicit operator InputDigitalActionHandle_t(sbyte value) => new InputDigitalActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(InputDigitalActionHandle_t value) => (sbyte)(value.Value);

    public static implicit operator InputDigitalActionHandle_t(ushort value) => new InputDigitalActionHandle_t(value);

    public static explicit operator ushort(InputDigitalActionHandle_t value) => (ushort)(value.Value);

    public static implicit operator InputDigitalActionHandle_t(uint value) => new InputDigitalActionHandle_t(value);

    public static explicit operator uint(InputDigitalActionHandle_t value) => (uint)(value.Value);

    public static implicit operator InputDigitalActionHandle_t(ulong value) => new InputDigitalActionHandle_t(value);

    public static implicit operator ulong(InputDigitalActionHandle_t value) => value.Value;

    public static implicit operator InputDigitalActionHandle_t(nuint value) => new InputDigitalActionHandle_t(value);

    public static explicit operator nuint(InputDigitalActionHandle_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is InputDigitalActionHandle_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of InputDigitalActionHandle_t.");
    }

    public int CompareTo(InputDigitalActionHandle_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is InputDigitalActionHandle_t other) && Equals(other);

    public bool Equals(InputDigitalActionHandle_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
