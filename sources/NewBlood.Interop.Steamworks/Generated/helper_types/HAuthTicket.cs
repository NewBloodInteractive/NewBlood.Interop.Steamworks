using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct HAuthTicket : IComparable, IComparable<HAuthTicket>, IEquatable<HAuthTicket>, IFormattable
{
    public readonly uint Value;

    public HAuthTicket(uint value)
    {
        Value = value;
    }

    public static bool operator ==(HAuthTicket left, HAuthTicket right) => left.Value == right.Value;

    public static bool operator !=(HAuthTicket left, HAuthTicket right) => left.Value != right.Value;

    public static bool operator <(HAuthTicket left, HAuthTicket right) => left.Value < right.Value;

    public static bool operator <=(HAuthTicket left, HAuthTicket right) => left.Value <= right.Value;

    public static bool operator >(HAuthTicket left, HAuthTicket right) => left.Value > right.Value;

    public static bool operator >=(HAuthTicket left, HAuthTicket right) => left.Value >= right.Value;

    public static implicit operator HAuthTicket(byte value) => new HAuthTicket(value);

    public static explicit operator byte(HAuthTicket value) => (byte)(value.Value);

    public static explicit operator HAuthTicket(short value) => new HAuthTicket(unchecked((uint)(value)));

    public static explicit operator short(HAuthTicket value) => (short)(value.Value);

    public static explicit operator HAuthTicket(int value) => new HAuthTicket(unchecked((uint)(value)));

    public static explicit operator int(HAuthTicket value) => (int)(value.Value);

    public static explicit operator HAuthTicket(long value) => new HAuthTicket(unchecked((uint)(value)));

    public static implicit operator long(HAuthTicket value) => value.Value;

    public static explicit operator HAuthTicket(nint value) => new HAuthTicket(unchecked((uint)(value)));

    public static explicit operator nint(HAuthTicket value) => (nint)(value.Value);

    public static explicit operator HAuthTicket(sbyte value) => new HAuthTicket(unchecked((uint)(value)));

    public static explicit operator sbyte(HAuthTicket value) => (sbyte)(value.Value);

    public static implicit operator HAuthTicket(ushort value) => new HAuthTicket(value);

    public static explicit operator ushort(HAuthTicket value) => (ushort)(value.Value);

    public static implicit operator HAuthTicket(uint value) => new HAuthTicket(value);

    public static implicit operator uint(HAuthTicket value) => value.Value;

    public static explicit operator HAuthTicket(ulong value) => new HAuthTicket(unchecked((uint)(value)));

    public static implicit operator ulong(HAuthTicket value) => value.Value;

    public static explicit operator HAuthTicket(nuint value) => new HAuthTicket(unchecked((uint)(value)));

    public static implicit operator nuint(HAuthTicket value) => value.Value;

    public int CompareTo(object? obj)
    {
            if (obj is HAuthTicket other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HAuthTicket.");
    }

    public int CompareTo(HAuthTicket other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is HAuthTicket other) && Equals(other);

    public bool Equals(HAuthTicket other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
