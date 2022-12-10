using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct HHTMLBrowser : IComparable, IComparable<HHTMLBrowser>, IEquatable<HHTMLBrowser>, IFormattable
{
    public readonly uint Value;

    public HHTMLBrowser(uint value)
    {
        Value = value;
    }

    public static bool operator ==(HHTMLBrowser left, HHTMLBrowser right) => left.Value == right.Value;

    public static bool operator !=(HHTMLBrowser left, HHTMLBrowser right) => left.Value != right.Value;

    public static bool operator <(HHTMLBrowser left, HHTMLBrowser right) => left.Value < right.Value;

    public static bool operator <=(HHTMLBrowser left, HHTMLBrowser right) => left.Value <= right.Value;

    public static bool operator >(HHTMLBrowser left, HHTMLBrowser right) => left.Value > right.Value;

    public static bool operator >=(HHTMLBrowser left, HHTMLBrowser right) => left.Value >= right.Value;

    public static implicit operator HHTMLBrowser(byte value) => new HHTMLBrowser(value);

    public static explicit operator byte(HHTMLBrowser value) => (byte)(value.Value);

    public static explicit operator HHTMLBrowser(short value) => new HHTMLBrowser(unchecked((uint)(value)));

    public static explicit operator short(HHTMLBrowser value) => (short)(value.Value);

    public static explicit operator HHTMLBrowser(int value) => new HHTMLBrowser(unchecked((uint)(value)));

    public static explicit operator int(HHTMLBrowser value) => (int)(value.Value);

    public static explicit operator HHTMLBrowser(long value) => new HHTMLBrowser(unchecked((uint)(value)));

    public static implicit operator long(HHTMLBrowser value) => value.Value;

    public static explicit operator HHTMLBrowser(nint value) => new HHTMLBrowser(unchecked((uint)(value)));

    public static explicit operator nint(HHTMLBrowser value) => (nint)(value.Value);

    public static explicit operator HHTMLBrowser(sbyte value) => new HHTMLBrowser(unchecked((uint)(value)));

    public static explicit operator sbyte(HHTMLBrowser value) => (sbyte)(value.Value);

    public static implicit operator HHTMLBrowser(ushort value) => new HHTMLBrowser(value);

    public static explicit operator ushort(HHTMLBrowser value) => (ushort)(value.Value);

    public static implicit operator HHTMLBrowser(uint value) => new HHTMLBrowser(value);

    public static implicit operator uint(HHTMLBrowser value) => value.Value;

    public static explicit operator HHTMLBrowser(ulong value) => new HHTMLBrowser(unchecked((uint)(value)));

    public static implicit operator ulong(HHTMLBrowser value) => value.Value;

    public static explicit operator HHTMLBrowser(nuint value) => new HHTMLBrowser(unchecked((uint)(value)));

    public static implicit operator nuint(HHTMLBrowser value) => value.Value;

    public int CompareTo(object? obj)
    {
            if (obj is HHTMLBrowser other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HHTMLBrowser.");
    }

    public int CompareTo(HHTMLBrowser other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is HHTMLBrowser other) && Equals(other);

    public bool Equals(HHTMLBrowser other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
