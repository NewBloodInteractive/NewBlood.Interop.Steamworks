using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct AppId_t : IComparable, IComparable<AppId_t>, IEquatable<AppId_t>, IFormattable
{
    public readonly uint Value;

    public AppId_t(uint value)
    {
        Value = value;
    }

    public static bool operator ==(AppId_t left, AppId_t right) => left.Value == right.Value;

    public static bool operator !=(AppId_t left, AppId_t right) => left.Value != right.Value;

    public static bool operator <(AppId_t left, AppId_t right) => left.Value < right.Value;

    public static bool operator <=(AppId_t left, AppId_t right) => left.Value <= right.Value;

    public static bool operator >(AppId_t left, AppId_t right) => left.Value > right.Value;

    public static bool operator >=(AppId_t left, AppId_t right) => left.Value >= right.Value;

    public static implicit operator AppId_t(byte value) => new AppId_t(value);

    public static explicit operator byte(AppId_t value) => (byte)(value.Value);

    public static explicit operator AppId_t(short value) => new AppId_t(unchecked((uint)(value)));

    public static explicit operator short(AppId_t value) => (short)(value.Value);

    public static explicit operator AppId_t(int value) => new AppId_t(unchecked((uint)(value)));

    public static explicit operator int(AppId_t value) => (int)(value.Value);

    public static explicit operator AppId_t(long value) => new AppId_t(unchecked((uint)(value)));

    public static implicit operator long(AppId_t value) => value.Value;

    public static explicit operator AppId_t(nint value) => new AppId_t(unchecked((uint)(value)));

    public static explicit operator nint(AppId_t value) => (nint)(value.Value);

    public static explicit operator AppId_t(sbyte value) => new AppId_t(unchecked((uint)(value)));

    public static explicit operator sbyte(AppId_t value) => (sbyte)(value.Value);

    public static implicit operator AppId_t(ushort value) => new AppId_t(value);

    public static explicit operator ushort(AppId_t value) => (ushort)(value.Value);

    public static implicit operator AppId_t(uint value) => new AppId_t(value);

    public static implicit operator uint(AppId_t value) => value.Value;

    public static explicit operator AppId_t(ulong value) => new AppId_t(unchecked((uint)(value)));

    public static implicit operator ulong(AppId_t value) => value.Value;

    public static explicit operator AppId_t(nuint value) => new AppId_t(unchecked((uint)(value)));

    public static implicit operator nuint(AppId_t value) => value.Value;

    public int CompareTo(object? obj)
    {
            if (obj is AppId_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of AppId_t.");
    }

    public int CompareTo(AppId_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is AppId_t other) && Equals(other);

    public bool Equals(AppId_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
