using System;

namespace NewBlood.Interop.Steamworks;

public unsafe partial struct SteamNetworkingIdentity : IEquatable<SteamNetworkingIdentity>
{
    public static bool operator ==(in SteamNetworkingIdentity left, in SteamNetworkingIdentity right)
    {
        fixed (SteamNetworkingIdentity* pRight = &right)
        {
            return left.IsEqualTo(pRight) != 0;
        }
    }

    public static bool operator !=(in SteamNetworkingIdentity left, in SteamNetworkingIdentity right)
    {
        fixed (SteamNetworkingIdentity* pRight = &right)
        {
            return left.IsEqualTo(pRight) == 0;
        }
    }

    public readonly override bool Equals(object? obj)
    {
        return obj is SteamNetworkingIdentity other && this == other;
    }

    public readonly bool Equals(SteamNetworkingIdentity other)
    {
        return this == other;
    }

    public readonly override int GetHashCode()
    {
        int hash = HashCode.Combine((int)m_eType, m_cbSize);

        for (int i = 0; i < 32; i++)
            hash = HashCode.Combine(hash, Anonymous.m_reserved[i]);

        return hash;
    }
}
