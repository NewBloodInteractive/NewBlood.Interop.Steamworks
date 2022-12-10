using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SteamNetConnectionStatusChangedCallback_t
{
    public HSteamNetConnection m_hConn;

    public SteamNetConnectionInfo_t m_info;

    public ESteamNetworkingConnectionState m_eOldState;

    public const int k_iCallback = k_iSteamNetworkingSocketsCallbacks + 1;
}
