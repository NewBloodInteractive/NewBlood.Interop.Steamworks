using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct HServerQuery : IComparable, IComparable<HServerQuery>, IEquatable<HServerQuery>, IFormattable
{
    public readonly int Value;

    public HServerQuery(int value)
    {
        Value = value;
    }

    public static bool operator ==(HServerQuery left, HServerQuery right) => left.Value == right.Value;

    public static bool operator !=(HServerQuery left, HServerQuery right) => left.Value != right.Value;

    public static bool operator <(HServerQuery left, HServerQuery right) => left.Value < right.Value;

    public static bool operator <=(HServerQuery left, HServerQuery right) => left.Value <= right.Value;

    public static bool operator >(HServerQuery left, HServerQuery right) => left.Value > right.Value;

    public static bool operator >=(HServerQuery left, HServerQuery right) => left.Value >= right.Value;

    public static implicit operator HServerQuery(byte value) => new HServerQuery(value);

    public static explicit operator byte(HServerQuery value) => (byte)(value.Value);

    public static implicit operator HServerQuery(short value) => new HServerQuery(value);

    public static explicit operator short(HServerQuery value) => (short)(value.Value);

    public static implicit operator HServerQuery(int value) => new HServerQuery(value);

    public static implicit operator int(HServerQuery value) => value.Value;

    public static explicit operator HServerQuery(long value) => new HServerQuery(unchecked((int)(value)));

    public static implicit operator long(HServerQuery value) => value.Value;

    public static explicit operator HServerQuery(nint value) => new HServerQuery(unchecked((int)(value)));

    public static implicit operator nint(HServerQuery value) => value.Value;

    public static implicit operator HServerQuery(sbyte value) => new HServerQuery(value);

    public static explicit operator sbyte(HServerQuery value) => (sbyte)(value.Value);

    public static implicit operator HServerQuery(ushort value) => new HServerQuery(value);

    public static explicit operator ushort(HServerQuery value) => (ushort)(value.Value);

    public static explicit operator HServerQuery(uint value) => new HServerQuery(unchecked((int)(value)));

    public static explicit operator uint(HServerQuery value) => (uint)(value.Value);

    public static explicit operator HServerQuery(ulong value) => new HServerQuery(unchecked((int)(value)));

    public static explicit operator ulong(HServerQuery value) => (ulong)(value.Value);

    public static explicit operator HServerQuery(nuint value) => new HServerQuery(unchecked((int)(value)));

    public static explicit operator nuint(HServerQuery value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is HServerQuery other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HServerQuery.");
    }

    public int CompareTo(HServerQuery other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is HServerQuery other) && Equals(other);

    public bool Equals(HServerQuery other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
