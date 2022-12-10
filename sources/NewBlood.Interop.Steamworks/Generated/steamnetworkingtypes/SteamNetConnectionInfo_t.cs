using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct SteamNetConnectionInfo_t
{
    public SteamNetworkingIdentity m_identityRemote;

    [NativeTypeName("int64")]
    public long m_nUserData;

    public HSteamListenSocket m_hListenSocket;

    public SteamNetworkingIPAddr m_addrRemote;

    [NativeTypeName("uint16")]
    public ushort m__pad1;

    [NativeTypeName("SteamNetworkingPOPID")]
    public uint m_idPOPRemote;

    [NativeTypeName("SteamNetworkingPOPID")]
    public uint m_idPOPRelay;

    public ESteamNetworkingConnectionState m_eState;

    public int m_eEndReason;

    [NativeTypeName("char[128]")]
    public fixed sbyte m_szEndDebug[128];

    [NativeTypeName("char[128]")]
    public fixed sbyte m_szConnectionDescription[128];

    public int m_nFlags;

    [NativeTypeName("uint32[63]")]
    public fixed uint reserved[63];
}
