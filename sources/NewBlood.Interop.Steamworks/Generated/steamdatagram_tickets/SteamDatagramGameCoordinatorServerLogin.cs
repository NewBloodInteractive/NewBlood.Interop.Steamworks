namespace NewBlood.Interop.Steamworks;

public unsafe partial struct SteamDatagramGameCoordinatorServerLogin
{
    public SteamNetworkingIdentity m_identity;

    public SteamDatagramHostedAddress m_routing;

    public AppId_t m_nAppID;

    [NativeTypeName("RTime32")]
    public uint m_rtime;

    public int m_cbAppData;

    [NativeTypeName("char[2048]")]
    public fixed sbyte m_appData[2048];
}
