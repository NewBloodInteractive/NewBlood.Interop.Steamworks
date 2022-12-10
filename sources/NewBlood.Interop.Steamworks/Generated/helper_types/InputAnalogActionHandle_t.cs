using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct InputAnalogActionHandle_t : IComparable, IComparable<InputAnalogActionHandle_t>, IEquatable<InputAnalogActionHandle_t>, IFormattable
{
    public readonly ulong Value;

    public InputAnalogActionHandle_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(InputAnalogActionHandle_t left, InputAnalogActionHandle_t right) => left.Value == right.Value;

    public static bool operator !=(InputAnalogActionHandle_t left, InputAnalogActionHandle_t right) => left.Value != right.Value;

    public static bool operator <(InputAnalogActionHandle_t left, InputAnalogActionHandle_t right) => left.Value < right.Value;

    public static bool operator <=(InputAnalogActionHandle_t left, InputAnalogActionHandle_t right) => left.Value <= right.Value;

    public static bool operator >(InputAnalogActionHandle_t left, InputAnalogActionHandle_t right) => left.Value > right.Value;

    public static bool operator >=(InputAnalogActionHandle_t left, InputAnalogActionHandle_t right) => left.Value >= right.Value;

    public static implicit operator InputAnalogActionHandle_t(byte value) => new InputAnalogActionHandle_t(value);

    public static explicit operator byte(InputAnalogActionHandle_t value) => (byte)(value.Value);

    public static explicit operator InputAnalogActionHandle_t(short value) => new InputAnalogActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator short(InputAnalogActionHandle_t value) => (short)(value.Value);

    public static explicit operator InputAnalogActionHandle_t(int value) => new InputAnalogActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator int(InputAnalogActionHandle_t value) => (int)(value.Value);

    public static explicit operator InputAnalogActionHandle_t(long value) => new InputAnalogActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator long(InputAnalogActionHandle_t value) => (long)(value.Value);

    public static explicit operator InputAnalogActionHandle_t(nint value) => new InputAnalogActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator nint(InputAnalogActionHandle_t value) => (nint)(value.Value);

    public static explicit operator InputAnalogActionHandle_t(sbyte value) => new InputAnalogActionHandle_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(InputAnalogActionHandle_t value) => (sbyte)(value.Value);

    public static implicit operator InputAnalogActionHandle_t(ushort value) => new InputAnalogActionHandle_t(value);

    public static explicit operator ushort(InputAnalogActionHandle_t value) => (ushort)(value.Value);

    public static implicit operator InputAnalogActionHandle_t(uint value) => new InputAnalogActionHandle_t(value);

    public static explicit operator uint(InputAnalogActionHandle_t value) => (uint)(value.Value);

    public static implicit operator InputAnalogActionHandle_t(ulong value) => new InputAnalogActionHandle_t(value);

    public static implicit operator ulong(InputAnalogActionHandle_t value) => value.Value;

    public static implicit operator InputAnalogActionHandle_t(nuint value) => new InputAnalogActionHandle_t(value);

    public static explicit operator nuint(InputAnalogActionHandle_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is InputAnalogActionHandle_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of InputAnalogActionHandle_t.");
    }

    public int CompareTo(InputAnalogActionHandle_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is InputAnalogActionHandle_t other) && Equals(other);

    public bool Equals(InputAnalogActionHandle_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
