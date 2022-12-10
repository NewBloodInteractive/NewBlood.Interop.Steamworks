using System;
using System.ComponentModel;

namespace NewBlood.Interop.Steamworks;

// Obsolete member 'memberA' overrides non-obsolete member 'memberB'.
#pragma warning disable 0809

public unsafe partial struct SteamNetworkingIPAddr
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

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Equals() on SteamNetworkingIPAddr will always throw an exception.")]
    public override bool Equals(object? obj)
    {
        throw new NotSupportedException();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("GetHashCode() on SteamNetworkingIPAddr will always throw an exception.")]
    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }
}
