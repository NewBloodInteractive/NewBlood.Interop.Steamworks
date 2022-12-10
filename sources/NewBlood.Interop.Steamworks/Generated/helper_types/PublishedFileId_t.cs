using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct PublishedFileId_t : IComparable, IComparable<PublishedFileId_t>, IEquatable<PublishedFileId_t>, IFormattable
{
    public readonly ulong Value;

    public PublishedFileId_t(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(PublishedFileId_t left, PublishedFileId_t right) => left.Value == right.Value;

    public static bool operator !=(PublishedFileId_t left, PublishedFileId_t right) => left.Value != right.Value;

    public static bool operator <(PublishedFileId_t left, PublishedFileId_t right) => left.Value < right.Value;

    public static bool operator <=(PublishedFileId_t left, PublishedFileId_t right) => left.Value <= right.Value;

    public static bool operator >(PublishedFileId_t left, PublishedFileId_t right) => left.Value > right.Value;

    public static bool operator >=(PublishedFileId_t left, PublishedFileId_t right) => left.Value >= right.Value;

    public static implicit operator PublishedFileId_t(byte value) => new PublishedFileId_t(value);

    public static explicit operator byte(PublishedFileId_t value) => (byte)(value.Value);

    public static explicit operator PublishedFileId_t(short value) => new PublishedFileId_t(unchecked((ulong)(value)));

    public static explicit operator short(PublishedFileId_t value) => (short)(value.Value);

    public static explicit operator PublishedFileId_t(int value) => new PublishedFileId_t(unchecked((ulong)(value)));

    public static explicit operator int(PublishedFileId_t value) => (int)(value.Value);

    public static explicit operator PublishedFileId_t(long value) => new PublishedFileId_t(unchecked((ulong)(value)));

    public static explicit operator long(PublishedFileId_t value) => (long)(value.Value);

    public static explicit operator PublishedFileId_t(nint value) => new PublishedFileId_t(unchecked((ulong)(value)));

    public static explicit operator nint(PublishedFileId_t value) => (nint)(value.Value);

    public static explicit operator PublishedFileId_t(sbyte value) => new PublishedFileId_t(unchecked((ulong)(value)));

    public static explicit operator sbyte(PublishedFileId_t value) => (sbyte)(value.Value);

    public static implicit operator PublishedFileId_t(ushort value) => new PublishedFileId_t(value);

    public static explicit operator ushort(PublishedFileId_t value) => (ushort)(value.Value);

    public static implicit operator PublishedFileId_t(uint value) => new PublishedFileId_t(value);

    public static explicit operator uint(PublishedFileId_t value) => (uint)(value.Value);

    public static implicit operator PublishedFileId_t(ulong value) => new PublishedFileId_t(value);

    public static implicit operator ulong(PublishedFileId_t value) => value.Value;

    public static implicit operator PublishedFileId_t(nuint value) => new PublishedFileId_t(value);

    public static explicit operator nuint(PublishedFileId_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
            if (obj is PublishedFileId_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of PublishedFileId_t.");
    }

    public int CompareTo(PublishedFileId_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is PublishedFileId_t other) && Equals(other);

    public bool Equals(PublishedFileId_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
