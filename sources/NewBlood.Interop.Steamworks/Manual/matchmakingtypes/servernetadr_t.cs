using System;

namespace NewBlood.Interop.Steamworks;

public partial struct servernetadr_t : IEquatable<servernetadr_t>, IComparable<servernetadr_t>
{
    public static bool operator <(in servernetadr_t left, in servernetadr_t right)
    {
        return left.m_unIP < right.m_unIP || (left.m_unIP == right.m_unIP && left.m_usQueryPort < right.m_usQueryPort);
    }

    public static bool operator ==(in servernetadr_t left, in servernetadr_t right)
    {
        return left.m_usConnectionPort == right.m_usConnectionPort
            && left.m_usQueryPort == right.m_usQueryPort
            && left.m_unIP == right.m_unIP;
    }

    public static bool operator <=(in servernetadr_t left, in servernetadr_t right)
    {
        return left == right || left < right;
    }

    public static bool operator >=(in servernetadr_t left, in servernetadr_t right)
    {
        return left == right || left > right;
    }

    public static bool operator >(in servernetadr_t left, in servernetadr_t right)
    {
        return !(left < right) && !(left == right);
    }

    public static bool operator !=(in servernetadr_t left, in servernetadr_t right)
    {
        return !(left == right);
    }

    public readonly override int GetHashCode()
    {
        return HashCode.Combine(m_usConnectionPort, m_usQueryPort, m_unIP);
    }

    public readonly override bool Equals(object? obj)
    {
        return obj is servernetadr_t other && this == other;
    }

    public readonly bool Equals(servernetadr_t other)
    {
        return this == other;
    }

    public readonly int CompareTo(servernetadr_t other)
    {
        if (this == other)
            return 0;

        if (this < other)
            return -1;

        return 1;
    }
}
