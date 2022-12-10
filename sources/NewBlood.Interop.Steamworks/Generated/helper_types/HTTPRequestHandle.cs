using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct HTTPRequestHandle : IComparable, IComparable<HTTPRequestHandle>, IEquatable<HTTPRequestHandle>, IFormattable
{
    public readonly uint Value;

    public HTTPRequestHandle(uint value)
    {
        Value = value;
    }

    public static bool operator ==(HTTPRequestHandle left, HTTPRequestHandle right) => left.Value == right.Value;

    public static bool operator !=(HTTPRequestHandle left, HTTPRequestHandle right) => left.Value != right.Value;

    public static bool operator <(HTTPRequestHandle left, HTTPRequestHandle right) => left.Value < right.Value;

    public static bool operator <=(HTTPRequestHandle left, HTTPRequestHandle right) => left.Value <= right.Value;

    public static bool operator >(HTTPRequestHandle left, HTTPRequestHandle right) => left.Value > right.Value;

    public static bool operator >=(HTTPRequestHandle left, HTTPRequestHandle right) => left.Value >= right.Value;

    public static implicit operator HTTPRequestHandle(byte value) => new HTTPRequestHandle(value);

    public static explicit operator byte(HTTPRequestHandle value) => (byte)(value.Value);

    public static explicit operator HTTPRequestHandle(short value) => new HTTPRequestHandle(unchecked((uint)(value)));

    public static explicit operator short(HTTPRequestHandle value) => (short)(value.Value);

    public static explicit operator HTTPRequestHandle(int value) => new HTTPRequestHandle(unchecked((uint)(value)));

    public static explicit operator int(HTTPRequestHandle value) => (int)(value.Value);

    public static explicit operator HTTPRequestHandle(long value) => new HTTPRequestHandle(unchecked((uint)(value)));

    public static implicit operator long(HTTPRequestHandle value) => value.Value;

    public static explicit operator HTTPRequestHandle(nint value) => new HTTPRequestHandle(unchecked((uint)(value)));

    public static explicit operator nint(HTTPRequestHandle value) => (nint)(value.Value);

    public static explicit operator HTTPRequestHandle(sbyte value) => new HTTPRequestHandle(unchecked((uint)(value)));

    public static explicit operator sbyte(HTTPRequestHandle value) => (sbyte)(value.Value);

    public static implicit operator HTTPRequestHandle(ushort value) => new HTTPRequestHandle(value);

    public static explicit operator ushort(HTTPRequestHandle value) => (ushort)(value.Value);

    public static implicit operator HTTPRequestHandle(uint value) => new HTTPRequestHandle(value);

    public static implicit operator uint(HTTPRequestHandle value) => value.Value;

    public static explicit operator HTTPRequestHandle(ulong value) => new HTTPRequestHandle(unchecked((uint)(value)));

    public static implicit operator ulong(HTTPRequestHandle value) => value.Value;

    public static explicit operator HTTPRequestHandle(nuint value) => new HTTPRequestHandle(unchecked((uint)(value)));

    public static implicit operator nuint(HTTPRequestHandle value) => value.Value;

    public int CompareTo(object? obj)
    {
            if (obj is HTTPRequestHandle other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HTTPRequestHandle.");
    }

    public int CompareTo(HTTPRequestHandle other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is HTTPRequestHandle other) && Equals(other);

    public bool Equals(HTTPRequestHandle other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
