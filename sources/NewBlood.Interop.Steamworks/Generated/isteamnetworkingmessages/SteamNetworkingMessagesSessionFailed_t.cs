using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SteamNetworkingMessagesSessionFailed_t
{
    public SteamNetConnectionInfo_t m_info;

    public const int k_iCallback = k_iSteamNetworkingMessagesCallbacks + 2;
}
