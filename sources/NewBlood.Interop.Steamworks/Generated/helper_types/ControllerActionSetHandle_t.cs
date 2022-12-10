using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct ControllerActionSetHandle_t : IComparable, IComparable<ControllerActionSetHandle_t>, IEquatable<ControllerActionSetHandle_t>, IFormattable
{
    public readonly ulong Value;

    public ControllerActionSetHandle_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(ControllerActionSetHandle_t left, ControllerActionSetHandle_t right) => left.Value == right.Value;

    public static bool operator !=(ControllerActionSetHandle_t left, ControllerActionSetHandle_t right) => left.Value != right.Value;

    public static bool operator <(ControllerActionSetHandle_t left, ControllerActionSetHandle_t right) => left.Value < right.Value;

    public static bool operator <=(ControllerActionSetHandle_t left, ControllerActionSetHandle_t right) => left.Value <= right.Value;

    public static bool operator >(ControllerActionSetHandle_t left, ControllerActionSetHandle_t right) => left.Value > right.Value;

    public static bool operator >=(ControllerActionSetHandle_t left, ControllerActionSetHandle_t right) => left.Value >= right.Value;

    public static implicit operator ControllerActionSetHandle_t(byte value) => new ControllerActionSetHandle_t(value);

    public static explicit operator byte(ControllerActionSetHandle_t value) => (byte)(value.Value);

    public static explicit operator ControllerActionSetHandle_t(short value) => new ControllerActionSetHandle_t(unchecked((ulong)(value)));

    public static explicit operator short(ControllerActionSetHandle_t value) => (short)(value.Value);

    public static explicit operator ControllerActionSetHandle_t(int value) => new ControllerActionSetHandle_t(unchecked((ulong)(value)));

    public static explicit operator int(ControllerActionSetHandle_t value) => (int)(value.Value);

    public static explicit operator ControllerActionSetHandle_t(long value) => new ControllerActionSetHandle_t(unchecked((ulong)(value)));

    public static explicit operator long(ControllerActionSetHandle_t value) => (long)(value.Value);

    public static explicit operator ControllerActionSetHandle_t(nint value) => new ControllerActionSetHandle_t(unchecked((ulong)(value)));

    public static explicit operator nint(ControllerActionSetHandle_t value) => (nint)(value.Value);

    public static explicit operator ControllerActionSetHandle_t(sbyte value) => new ControllerActionSetHandle_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(ControllerActionSetHandle_t value) => (sbyte)(value.Value);

    public static implicit operator ControllerActionSetHandle_t(ushort value) => new ControllerActionSetHandle_t(value);

    public static explicit operator ushort(ControllerActionSetHandle_t value) => (ushort)(value.Value);

    public static implicit operator ControllerActionSetHandle_t(uint value) => new ControllerActionSetHandle_t(value);

    public static explicit operator uint(ControllerActionSetHandle_t value) => (uint)(value.Value);

    public static implicit operator ControllerActionSetHandle_t(ulong value) => new ControllerActionSetHandle_t(value);

    public static implicit operator ulong(ControllerActionSetHandle_t value) => value.Value;

    public static implicit operator ControllerActionSetHandle_t(nuint value) => new ControllerActionSetHandle_t(value);

    public static explicit operator nuint(ControllerActionSetHandle_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is ControllerActionSetHandle_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of ControllerActionSetHandle_t.");
    }

    public int CompareTo(ControllerActionSetHandle_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is ControllerActionSetHandle_t other) && Equals(other);

    public bool Equals(ControllerActionSetHandle_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
