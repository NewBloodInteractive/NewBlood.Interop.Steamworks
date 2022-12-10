using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct PublishedFileUpdateHandle_t : IComparable, IComparable<PublishedFileUpdateHandle_t>, IEquatable<PublishedFileUpdateHandle_t>, IFormattable
{
    public readonly ulong Value;

    public PublishedFileUpdateHandle_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(PublishedFileUpdateHandle_t left, PublishedFileUpdateHandle_t right) => left.Value == right.Value;

    public static bool operator !=(PublishedFileUpdateHandle_t left, PublishedFileUpdateHandle_t right) => left.Value != right.Value;

    public static bool operator <(PublishedFileUpdateHandle_t left, PublishedFileUpdateHandle_t right) => left.Value < right.Value;

    public static bool operator <=(PublishedFileUpdateHandle_t left, PublishedFileUpdateHandle_t right) => left.Value <= right.Value;

    public static bool operator >(PublishedFileUpdateHandle_t left, PublishedFileUpdateHandle_t right) => left.Value > right.Value;

    public static bool operator >=(PublishedFileUpdateHandle_t left, PublishedFileUpdateHandle_t right) => left.Value >= right.Value;

    public static implicit operator PublishedFileUpdateHandle_t(byte value) => new PublishedFileUpdateHandle_t(value);

    public static explicit operator byte(PublishedFileUpdateHandle_t value) => (byte)(value.Value);

    public static explicit operator PublishedFileUpdateHandle_t(short value) => new PublishedFileUpdateHandle_t(unchecked((ulong)(value)));

    public static explicit operator short(PublishedFileUpdateHandle_t value) => (short)(value.Value);

    public static explicit operator PublishedFileUpdateHandle_t(int value) => new PublishedFileUpdateHandle_t(unchecked((ulong)(value)));

    public static explicit operator int(PublishedFileUpdateHandle_t value) => (int)(value.Value);

    public static explicit operator PublishedFileUpdateHandle_t(long value) => new PublishedFileUpdateHandle_t(unchecked((ulong)(value)));

    public static explicit operator long(PublishedFileUpdateHandle_t value) => (long)(value.Value);

    public static explicit operator PublishedFileUpdateHandle_t(nint value) => new PublishedFileUpdateHandle_t(unchecked((ulong)(value)));

    public static explicit operator nint(PublishedFileUpdateHandle_t value) => (nint)(value.Value);

    public static explicit operator PublishedFileUpdateHandle_t(sbyte value) => new PublishedFileUpdateHandle_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(PublishedFileUpdateHandle_t value) => (sbyte)(value.Value);

    public static implicit operator PublishedFileUpdateHandle_t(ushort value) => new PublishedFileUpdateHandle_t(value);

    public static explicit operator ushort(PublishedFileUpdateHandle_t value) => (ushort)(value.Value);

    public static implicit operator PublishedFileUpdateHandle_t(uint value) => new PublishedFileUpdateHandle_t(value);

    public static explicit operator uint(PublishedFileUpdateHandle_t value) => (uint)(value.Value);

    public static implicit operator PublishedFileUpdateHandle_t(ulong value) => new PublishedFileUpdateHandle_t(value);

    public static implicit operator ulong(PublishedFileUpdateHandle_t value) => value.Value;

    public static implicit operator PublishedFileUpdateHandle_t(nuint value) => new PublishedFileUpdateHandle_t(value);

    public static explicit operator nuint(PublishedFileUpdateHandle_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is PublishedFileUpdateHandle_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of PublishedFileUpdateHandle_t.");
    }

    public int CompareTo(PublishedFileUpdateHandle_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is PublishedFileUpdateHandle_t other) && Equals(other);

    public bool Equals(PublishedFileUpdateHandle_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
