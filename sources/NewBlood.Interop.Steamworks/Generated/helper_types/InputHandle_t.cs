using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct InputHandle_t : IComparable, IComparable<InputHandle_t>, IEquatable<InputHandle_t>, IFormattable
{
    public readonly ulong Value;

    public InputHandle_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(InputHandle_t left, InputHandle_t right) => left.Value == right.Value;

    public static bool operator !=(InputHandle_t left, InputHandle_t right) => left.Value != right.Value;

    public static bool operator <(InputHandle_t left, InputHandle_t right) => left.Value < right.Value;

    public static bool operator <=(InputHandle_t left, InputHandle_t right) => left.Value <= right.Value;

    public static bool operator >(InputHandle_t left, InputHandle_t right) => left.Value > right.Value;

    public static bool operator >=(InputHandle_t left, InputHandle_t right) => left.Value >= right.Value;

    public static implicit operator InputHandle_t(byte value) => new InputHandle_t(value);

    public static explicit operator byte(InputHandle_t value) => (byte)(value.Value);

    public static explicit operator InputHandle_t(short value) => new InputHandle_t(unchecked((ulong)(value)));

    public static explicit operator short(InputHandle_t value) => (short)(value.Value);

    public static explicit operator InputHandle_t(int value) => new InputHandle_t(unchecked((ulong)(value)));

    public static explicit operator int(InputHandle_t value) => (int)(value.Value);

    public static explicit operator InputHandle_t(long value) => new InputHandle_t(unchecked((ulong)(value)));

    public static explicit operator long(InputHandle_t value) => (long)(value.Value);

    public static explicit operator InputHandle_t(nint value) => new InputHandle_t(unchecked((ulong)(value)));

    public static explicit operator nint(InputHandle_t value) => (nint)(value.Value);

    public static explicit operator InputHandle_t(sbyte value) => new InputHandle_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(InputHandle_t value) => (sbyte)(value.Value);

    public static implicit operator InputHandle_t(ushort value) => new InputHandle_t(value);

    public static explicit operator ushort(InputHandle_t value) => (ushort)(value.Value);

    public static implicit operator InputHandle_t(uint value) => new InputHandle_t(value);

    public static explicit operator uint(InputHandle_t value) => (uint)(value.Value);

    public static implicit operator InputHandle_t(ulong value) => new InputHandle_t(value);

    public static implicit operator ulong(InputHandle_t value) => value.Value;

    public static implicit operator InputHandle_t(nuint value) => new InputHandle_t(value);

    public static explicit operator nuint(InputHandle_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is InputHandle_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of InputHandle_t.");
    }

    public int CompareTo(InputHandle_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is InputHandle_t other) && Equals(other);

    public bool Equals(InputHandle_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
