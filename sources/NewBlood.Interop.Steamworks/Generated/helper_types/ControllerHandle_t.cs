using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct ControllerHandle_t : IComparable, IComparable<ControllerHandle_t>, IEquatable<ControllerHandle_t>, IFormattable
{
    public readonly ulong Value;

    public ControllerHandle_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(ControllerHandle_t left, ControllerHandle_t right) => left.Value == right.Value;

    public static bool operator !=(ControllerHandle_t left, ControllerHandle_t right) => left.Value != right.Value;

    public static bool operator <(ControllerHandle_t left, ControllerHandle_t right) => left.Value < right.Value;

    public static bool operator <=(ControllerHandle_t left, ControllerHandle_t right) => left.Value <= right.Value;

    public static bool operator >(ControllerHandle_t left, ControllerHandle_t right) => left.Value > right.Value;

    public static bool operator >=(ControllerHandle_t left, ControllerHandle_t right) => left.Value >= right.Value;

    public static implicit operator ControllerHandle_t(byte value) => new ControllerHandle_t(value);

    public static explicit operator byte(ControllerHandle_t value) => (byte)(value.Value);

    public static explicit operator ControllerHandle_t(short value) => new ControllerHandle_t(unchecked((ulong)(value)));

    public static explicit operator short(ControllerHandle_t value) => (short)(value.Value);

    public static explicit operator ControllerHandle_t(int value) => new ControllerHandle_t(unchecked((ulong)(value)));

    public static explicit operator int(ControllerHandle_t value) => (int)(value.Value);

    public static explicit operator ControllerHandle_t(long value) => new ControllerHandle_t(unchecked((ulong)(value)));

    public static explicit operator long(ControllerHandle_t value) => (long)(value.Value);

    public static explicit operator ControllerHandle_t(nint value) => new ControllerHandle_t(unchecked((ulong)(value)));

    public static explicit operator nint(ControllerHandle_t value) => (nint)(value.Value);

    public static explicit operator ControllerHandle_t(sbyte value) => new ControllerHandle_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(ControllerHandle_t value) => (sbyte)(value.Value);

    public static implicit operator ControllerHandle_t(ushort value) => new ControllerHandle_t(value);

    public static explicit operator ushort(ControllerHandle_t value) => (ushort)(value.Value);

    public static implicit operator ControllerHandle_t(uint value) => new ControllerHandle_t(value);

    public static explicit operator uint(ControllerHandle_t value) => (uint)(value.Value);

    public static implicit operator ControllerHandle_t(ulong value) => new ControllerHandle_t(value);

    public static implicit operator ulong(ControllerHandle_t value) => value.Value;

    public static implicit operator ControllerHandle_t(nuint value) => new ControllerHandle_t(value);

    public static explicit operator nuint(ControllerHandle_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is ControllerHandle_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of ControllerHandle_t.");
    }

    public int CompareTo(ControllerHandle_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is ControllerHandle_t other) && Equals(other);

    public bool Equals(ControllerHandle_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
