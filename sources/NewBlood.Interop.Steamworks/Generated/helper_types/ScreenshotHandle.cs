using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct ScreenshotHandle : IComparable, IComparable<ScreenshotHandle>, IEquatable<ScreenshotHandle>, IFormattable
{
    public readonly uint Value;

    public ScreenshotHandle(uint value)
    {
        Value = value;
    }

    public static bool operator ==(ScreenshotHandle left, ScreenshotHandle right) => left.Value == right.Value;

    public static bool operator !=(ScreenshotHandle left, ScreenshotHandle right) => left.Value != right.Value;

    public static bool operator <(ScreenshotHandle left, ScreenshotHandle right) => left.Value < right.Value;

    public static bool operator <=(ScreenshotHandle left, ScreenshotHandle right) => left.Value <= right.Value;

    public static bool operator >(ScreenshotHandle left, ScreenshotHandle right) => left.Value > right.Value;

    public static bool operator >=(ScreenshotHandle left, ScreenshotHandle right) => left.Value >= right.Value;

    public static implicit operator ScreenshotHandle(byte value) => new ScreenshotHandle(value);

    public static explicit operator byte(ScreenshotHandle value) => (byte)(value.Value);

    public static explicit operator ScreenshotHandle(short value) => new ScreenshotHandle(unchecked((uint)(value)));

    public static explicit operator short(ScreenshotHandle value) => (short)(value.Value);

    public static explicit operator ScreenshotHandle(int value) => new ScreenshotHandle(unchecked((uint)(value)));

    public static explicit operator int(ScreenshotHandle value) => (int)(value.Value);

    public static explicit operator ScreenshotHandle(long value) => new ScreenshotHandle(unchecked((uint)(value)));

    public static implicit operator long(ScreenshotHandle value) => value.Value;

    public static explicit operator ScreenshotHandle(nint value) => new ScreenshotHandle(unchecked((uint)(value)));

    public static explicit operator nint(ScreenshotHandle value) => (nint)(value.Value);

    public static explicit operator ScreenshotHandle(sbyte value) => new ScreenshotHandle(unchecked((uint)(value)));

    public static explicit operator sbyte(ScreenshotHandle value) => (sbyte)(value.Value);

    public static implicit operator ScreenshotHandle(ushort value) => new ScreenshotHandle(value);

    public static explicit operator ushort(ScreenshotHandle value) => (ushort)(value.Value);

    public static implicit operator ScreenshotHandle(uint value) => new ScreenshotHandle(value);

    public static implicit operator uint(ScreenshotHandle value) => value.Value;

    public static explicit operator ScreenshotHandle(ulong value) => new ScreenshotHandle(unchecked((uint)(value)));

    public static implicit operator ulong(ScreenshotHandle value) => value.Value;

    public static explicit operator ScreenshotHandle(nuint value) => new ScreenshotHandle(unchecked((uint)(value)));

    public static implicit operator nuint(ScreenshotHandle value) => value.Value;

    public int CompareTo(object? obj)
    {
            if (obj is ScreenshotHandle other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of ScreenshotHandle.");
    }

    public int CompareTo(ScreenshotHandle other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is ScreenshotHandle other) && Equals(other);

    public bool Equals(ScreenshotHandle other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
