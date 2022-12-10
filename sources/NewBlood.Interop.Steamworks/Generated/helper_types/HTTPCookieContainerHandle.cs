using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct HTTPCookieContainerHandle : IComparable, IComparable<HTTPCookieContainerHandle>, IEquatable<HTTPCookieContainerHandle>, IFormattable
{
    public readonly uint Value;

    public HTTPCookieContainerHandle(uint value)
    {
        Value = value;
    }

    public static bool operator ==(HTTPCookieContainerHandle left, HTTPCookieContainerHandle right) => left.Value == right.Value;

    public static bool operator !=(HTTPCookieContainerHandle left, HTTPCookieContainerHandle right) => left.Value != right.Value;

    public static bool operator <(HTTPCookieContainerHandle left, HTTPCookieContainerHandle right) => left.Value < right.Value;

    public static bool operator <=(HTTPCookieContainerHandle left, HTTPCookieContainerHandle right) => left.Value <= right.Value;

    public static bool operator >(HTTPCookieContainerHandle left, HTTPCookieContainerHandle right) => left.Value > right.Value;

    public static bool operator >=(HTTPCookieContainerHandle left, HTTPCookieContainerHandle right) => left.Value >= right.Value;

    public static implicit operator HTTPCookieContainerHandle(byte value) => new HTTPCookieContainerHandle(value);

    public static explicit operator byte(HTTPCookieContainerHandle value) => (byte)(value.Value);

    public static explicit operator HTTPCookieContainerHandle(short value) => new HTTPCookieContainerHandle(unchecked((uint)(value)));

    public static explicit operator short(HTTPCookieContainerHandle value) => (short)(value.Value);

    public static explicit operator HTTPCookieContainerHandle(int value) => new HTTPCookieContainerHandle(unchecked((uint)(value)));

    public static explicit operator int(HTTPCookieContainerHandle value) => (int)(value.Value);

    public static explicit operator HTTPCookieContainerHandle(long value) => new HTTPCookieContainerHandle(unchecked((uint)(value)));

    public static implicit operator long(HTTPCookieContainerHandle value) => value.Value;

    public static explicit operator HTTPCookieContainerHandle(nint value) => new HTTPCookieContainerHandle(unchecked((uint)(value)));

    public static explicit operator nint(HTTPCookieContainerHandle value) => (nint)(value.Value);

    public static explicit operator HTTPCookieContainerHandle(sbyte value) => new HTTPCookieContainerHandle(unchecked((uint)(value)));

    public static explicit operator sbyte(HTTPCookieContainerHandle value) => (sbyte)(value.Value);

    public static implicit operator HTTPCookieContainerHandle(ushort value) => new HTTPCookieContainerHandle(value);

    public static explicit operator ushort(HTTPCookieContainerHandle value) => (ushort)(value.Value);

    public static implicit operator HTTPCookieContainerHandle(uint value) => new HTTPCookieContainerHandle(value);

    public static implicit operator uint(HTTPCookieContainerHandle value) => value.Value;

    public static explicit operator HTTPCookieContainerHandle(ulong value) => new HTTPCookieContainerHandle(unchecked((uint)(value)));

    public static implicit operator ulong(HTTPCookieContainerHandle value) => value.Value;

    public static explicit operator HTTPCookieContainerHandle(nuint value) => new HTTPCookieContainerHandle(unchecked((uint)(value)));

    public static implicit operator nuint(HTTPCookieContainerHandle value) => value.Value;

    public int CompareTo(object? obj)
    {
            if (obj is HTTPCookieContainerHandle other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HTTPCookieContainerHandle.");
    }

    public int CompareTo(HTTPCookieContainerHandle other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is HTTPCookieContainerHandle other) && Equals(other);

    public bool Equals(HTTPCookieContainerHandle other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
