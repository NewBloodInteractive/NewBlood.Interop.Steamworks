using System;

namespace NewBlood.Interop.Steamworks;

public unsafe partial struct SteamNetworkingIPAddr : IEquatable<SteamNetworkingIPAddr>
{
    public static bool operator ==(in SteamNetworkingIPAddr left, in SteamNetworkingIPAddr right)
    {
        fixed (SteamNetworkingIPAddr* pRight = &right)
        {
            return left.IsEqualTo(pRight) != 0;
        }
    }

    public static bool operator !=(in SteamNetworkingIPAddr left, in SteamNetworkingIPAddr right)
    {
        fixed (SteamNetworkingIPAddr* pRight = &right)
        {
            return left.IsEqualTo(pRight) == 0;
        }
    }

    public readonly override bool Equals(object? obj)
    {
        return obj is SteamNetworkingIPAddr other && this == other;
    }

    public readonly bool Equals(SteamNetworkingIPAddr other)
    {
        return this == other;
    }

    public readonly override int GetHashCode()
    {
        int hash;

        fixed (SteamNetworkingIPAddr* pThis = &this)
        {
            if (Steamworks.SteamAPI_SteamNetworkingIPAddr_IsIPv4(pThis) != 0)
                hash = *(int*)pThis->Anonymous.m_ipv4.m_ip;
            else
            {
                hash = HashCode.Combine(
                    *(int*)pThis->Anonymous.m_ipv6,
                    *(int*)(pThis->Anonymous.m_ipv6 + 4),
                    *(int*)(pThis->Anonymous.m_ipv6 + 8),
                    *(int*)(pThis->Anonymous.m_ipv6 + 12)
                );
            }
        }

        return HashCode.Combine(hash, (int)m_port);
    }
}
