using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct CGameID : IComparable, IComparable<CGameID>, IEquatable<CGameID>, IFormattable
{
    public readonly ulong Value;

    public CGameID(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(CGameID left, CGameID right) => left.Value == right.Value;

    public static bool operator !=(CGameID left, CGameID right) => left.Value != right.Value;

    public static bool operator <(CGameID left, CGameID right) => left.Value < right.Value;

    public static bool operator <=(CGameID left, CGameID right) => left.Value <= right.Value;

    public static bool operator >(CGameID left, CGameID right) => left.Value > right.Value;

    public static bool operator >=(CGameID left, CGameID right) => left.Value >= right.Value;

    public static implicit operator CGameID(byte value) => new CGameID(value);

    public static explicit operator byte(CGameID value) => (byte)(value.Value);

    public static explicit operator CGameID(short value) => new CGameID(unchecked((ulong)(value)));

    public static explicit operator short(CGameID value) => (short)(value.Value);

    public static explicit operator CGameID(int value) => new CGameID(unchecked((ulong)(value)));

    public static explicit operator int(CGameID value) => (int)(value.Value);

    public static explicit operator CGameID(long value) => new CGameID(unchecked((ulong)(value)));

    public static explicit operator long(CGameID value) => (long)(value.Value);

    public static explicit operator CGameID(nint value) => new CGameID(unchecked((ulong)(value)));

    public static explicit operator nint(CGameID value) => (nint)(value.Value);

    public static explicit operator CGameID(sbyte value) => new CGameID(unchecked((ulong)(value)));

    public static explicit operator sbyte(CGameID value) => (sbyte)(value.Value);

    public static implicit operator CGameID(ushort value) => new CGameID(value);

    public static explicit operator ushort(CGameID value) => (ushort)(value.Value);

    public static implicit operator CGameID(uint value) => new CGameID(value);

    public static explicit operator uint(CGameID value) => (uint)(value.Value);

    public static implicit operator CGameID(ulong value) => new CGameID(value);

    public static implicit operator ulong(CGameID value) => value.Value;

    public static implicit operator CGameID(nuint value) => new CGameID(value);

    public static explicit operator nuint(CGameID value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is CGameID other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of CGameID.");
    }

    public int CompareTo(CGameID other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is CGameID other) && Equals(other);

    public bool Equals(CGameID other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
