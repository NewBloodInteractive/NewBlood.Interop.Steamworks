namespace NewBlood.Interop.Steamworks;

public unsafe partial struct SteamNetworkPingLocation_t
{
    [NativeTypeName("uint8[512]")]
    public fixed byte m_data[512];
}
