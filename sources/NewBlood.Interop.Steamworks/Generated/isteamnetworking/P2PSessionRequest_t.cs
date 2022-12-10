using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct P2PSessionRequest_t
{
    public CSteamID m_steamIDRemote;

    public const int k_iCallback = k_iSteamNetworkingCallbacks + 2;
}
