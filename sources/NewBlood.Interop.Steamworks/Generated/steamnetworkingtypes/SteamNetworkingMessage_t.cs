namespace NewBlood.Interop.Steamworks;

public unsafe partial struct SteamNetworkingMessage_t
{
    public void* m_pData;

    public int m_cbSize;

    public HSteamNetConnection m_conn;

    public SteamNetworkingIdentity m_identityPeer;

    [NativeTypeName("int64")]
    public long m_nConnUserData;

    [NativeTypeName("SteamNetworkingMicroseconds")]
    public long m_usecTimeReceived;

    [NativeTypeName("int64")]
    public long m_nMessageNumber;

    [NativeTypeName("void (*)(SteamNetworkingMessage_t *)")]
    public delegate* unmanaged[Cdecl]<SteamNetworkingMessage_t*, void> m_pfnFreeData;

    [NativeTypeName("void (*)(SteamNetworkingMessage_t *)")]
    public delegate* unmanaged[Cdecl]<SteamNetworkingMessage_t*, void> m_pfnRelease;

    public int m_nChannel;

    public int m_nFlags;

    [NativeTypeName("int64")]
    public long m_nUserData;

    [NativeTypeName("uint16")]
    public ushort m_idxLane;

    [NativeTypeName("uint16")]
    public ushort _pad1__;
}
