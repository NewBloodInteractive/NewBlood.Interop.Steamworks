using System;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct AccountID_t : IComparable, IComparable<AccountID_t>, IEquatable<AccountID_t>, IFormattable
{
    public readonly uint Value;

    public AccountID_t(uint value)
    {
        Value = value;
    }

    public static bool operator ==(AccountID_t left, AccountID_t right) => left.Value == right.Value;

    public static bool operator !=(AccountID_t left, AccountID_t right) => left.Value != right.Value;

    public static bool operator <(AccountID_t left, AccountID_t right) => left.Value < right.Value;

    public static bool operator <=(AccountID_t left, AccountID_t right) => left.Value <= right.Value;

    public static bool operator >(AccountID_t left, AccountID_t right) => left.Value > right.Value;

    public static bool operator >=(AccountID_t left, AccountID_t right) => left.Value >= right.Value;

    public static implicit operator AccountID_t(byte value) => new AccountID_t(value);

    public static explicit operator byte(AccountID_t value) => (byte)(value.Value);

    public static explicit operator AccountID_t(short value) => new AccountID_t(unchecked((uint)(value)));

    public static explicit operator short(AccountID_t value) => (short)(value.Value);

    public static explicit operator AccountID_t(int value) => new AccountID_t(unchecked((uint)(value)));

    public static explicit operator int(AccountID_t value) => (int)(value.Value);

    public static explicit operator AccountID_t(long value) => new AccountID_t(unchecked((uint)(value)));

    public static implicit operator long(AccountID_t value) => value.Value;

    public static explicit operator AccountID_t(nint value) => new AccountID_t(unchecked((uint)(value)));

    public static explicit operator nint(AccountID_t value) => (nint)(value.Value);

    public static explicit operator AccountID_t(sbyte value) => new AccountID_t(unchecked((uint)(value)));

    public static explicit operator sbyte(AccountID_t value) => (sbyte)(value.Value);

    public static implicit operator AccountID_t(ushort value) => new AccountID_t(value);

    public static explicit operator ushort(AccountID_t value) => (ushort)(value.Value);

    public static implicit operator AccountID_t(uint value) => new AccountID_t(value);

    public static implicit operator uint(AccountID_t value) => value.Value;

    public static explicit operator AccountID_t(ulong value) => new AccountID_t(unchecked((uint)(value)));

    public static implicit operator ulong(AccountID_t value) => value.Value;

    public static explicit operator AccountID_t(nuint value) => new AccountID_t(unchecked((uint)(value)));

    public static implicit operator nuint(AccountID_t value) => value.Value;

    public int CompareTo(object? obj)
    {
            if (obj is AccountID_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of AccountID_t.");
    }

    public int CompareTo(AccountID_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is AccountID_t other) && Equals(other);

    public bool Equals(AccountID_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
