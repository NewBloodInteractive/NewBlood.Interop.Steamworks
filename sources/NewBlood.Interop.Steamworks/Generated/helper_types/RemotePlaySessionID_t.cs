using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct RemotePlaySessionID_t : IComparable, IComparable<RemotePlaySessionID_t>, IEquatable<RemotePlaySessionID_t>, IFormattable
{
    public readonly uint Value;

    public RemotePlaySessionID_t(uint value)
    {
        Value = value;
    }

    public static bool operator ==(RemotePlaySessionID_t left, RemotePlaySessionID_t right) => left.Value == right.Value;

    public static bool operator !=(RemotePlaySessionID_t left, RemotePlaySessionID_t right) => left.Value != right.Value;

    public static bool operator <(RemotePlaySessionID_t left, RemotePlaySessionID_t right) => left.Value < right.Value;

    public static bool operator <=(RemotePlaySessionID_t left, RemotePlaySessionID_t right) => left.Value <= right.Value;

    public static bool operator >(RemotePlaySessionID_t left, RemotePlaySessionID_t right) => left.Value > right.Value;

    public static bool operator >=(RemotePlaySessionID_t left, RemotePlaySessionID_t right) => left.Value >= right.Value;

    public static implicit operator RemotePlaySessionID_t(byte value) => new RemotePlaySessionID_t(value);

    public static explicit operator byte(RemotePlaySessionID_t value) => (byte)(value.Value);

    public static explicit operator RemotePlaySessionID_t(short value) => new RemotePlaySessionID_t(unchecked((uint)(value)));

    public static explicit operator short(RemotePlaySessionID_t value) => (short)(value.Value);

    public static explicit operator RemotePlaySessionID_t(int value) => new RemotePlaySessionID_t(unchecked((uint)(value)));

    public static explicit operator int(RemotePlaySessionID_t value) => (int)(value.Value);

    public static explicit operator RemotePlaySessionID_t(long value) => new RemotePlaySessionID_t(unchecked((uint)(value)));

    public static implicit operator long(RemotePlaySessionID_t value) => value.Value;

    public static explicit operator RemotePlaySessionID_t(nint value) => new RemotePlaySessionID_t(unchecked((uint)(value)));

    public static explicit operator nint(RemotePlaySessionID_t value) => (nint)(value.Value);

    public static explicit operator RemotePlaySessionID_t(sbyte value) => new RemotePlaySessionID_t(unchecked((uint)(value)));

    public static explicit operator sbyte(RemotePlaySessionID_t value) => (sbyte)(value.Value);

    public static implicit operator RemotePlaySessionID_t(ushort value) => new RemotePlaySessionID_t(value);

    public static explicit operator ushort(RemotePlaySessionID_t value) => (ushort)(value.Value);

    public static implicit operator RemotePlaySessionID_t(uint value) => new RemotePlaySessionID_t(value);

    public static implicit operator uint(RemotePlaySessionID_t value) => value.Value;

    public static explicit operator RemotePlaySessionID_t(ulong value) => new RemotePlaySessionID_t(unchecked((uint)(value)));

    public static implicit operator ulong(RemotePlaySessionID_t value) => value.Value;

    public static explicit operator RemotePlaySessionID_t(nuint value) => new RemotePlaySessionID_t(unchecked((uint)(value)));

    public static implicit operator nuint(RemotePlaySessionID_t value) => value.Value;

    public int CompareTo(object? obj)
    {
            if (obj is RemotePlaySessionID_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of RemotePlaySessionID_t.");
    }

    public int CompareTo(RemotePlaySessionID_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is RemotePlaySessionID_t other) && Equals(other);

    public bool Equals(RemotePlaySessionID_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
