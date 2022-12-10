using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct InputActionSetHandle_t : IComparable, IComparable<InputActionSetHandle_t>, IEquatable<InputActionSetHandle_t>, IFormattable
{
    public readonly ulong Value;

    public InputActionSetHandle_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(InputActionSetHandle_t left, InputActionSetHandle_t right) => left.Value == right.Value;

    public static bool operator !=(InputActionSetHandle_t left, InputActionSetHandle_t right) => left.Value != right.Value;

    public static bool operator <(InputActionSetHandle_t left, InputActionSetHandle_t right) => left.Value < right.Value;

    public static bool operator <=(InputActionSetHandle_t left, InputActionSetHandle_t right) => left.Value <= right.Value;

    public static bool operator >(InputActionSetHandle_t left, InputActionSetHandle_t right) => left.Value > right.Value;

    public static bool operator >=(InputActionSetHandle_t left, InputActionSetHandle_t right) => left.Value >= right.Value;

    public static implicit operator InputActionSetHandle_t(byte value) => new InputActionSetHandle_t(value);

    public static explicit operator byte(InputActionSetHandle_t value) => (byte)(value.Value);

    public static explicit operator InputActionSetHandle_t(short value) => new InputActionSetHandle_t(unchecked((ulong)(value)));

    public static explicit operator short(InputActionSetHandle_t value) => (short)(value.Value);

    public static explicit operator InputActionSetHandle_t(int value) => new InputActionSetHandle_t(unchecked((ulong)(value)));

    public static explicit operator int(InputActionSetHandle_t value) => (int)(value.Value);

    public static explicit operator InputActionSetHandle_t(long value) => new InputActionSetHandle_t(unchecked((ulong)(value)));

    public static explicit operator long(InputActionSetHandle_t value) => (long)(value.Value);

    public static explicit operator InputActionSetHandle_t(nint value) => new InputActionSetHandle_t(unchecked((ulong)(value)));

    public static explicit operator nint(InputActionSetHandle_t value) => (nint)(value.Value);

    public static explicit operator InputActionSetHandle_t(sbyte value) => new InputActionSetHandle_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(InputActionSetHandle_t value) => (sbyte)(value.Value);

    public static implicit operator InputActionSetHandle_t(ushort value) => new InputActionSetHandle_t(value);

    public static explicit operator ushort(InputActionSetHandle_t value) => (ushort)(value.Value);

    public static implicit operator InputActionSetHandle_t(uint value) => new InputActionSetHandle_t(value);

    public static explicit operator uint(InputActionSetHandle_t value) => (uint)(value.Value);

    public static implicit operator InputActionSetHandle_t(ulong value) => new InputActionSetHandle_t(value);

    public static implicit operator ulong(InputActionSetHandle_t value) => value.Value;

    public static implicit operator InputActionSetHandle_t(nuint value) => new InputActionSetHandle_t(value);

    public static explicit operator nuint(InputActionSetHandle_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is InputActionSetHandle_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of InputActionSetHandle_t.");
    }

    public int CompareTo(InputActionSetHandle_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is InputActionSetHandle_t other) && Equals(other);

    public bool Equals(InputActionSetHandle_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
