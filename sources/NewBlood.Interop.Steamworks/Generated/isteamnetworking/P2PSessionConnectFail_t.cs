using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct P2PSessionConnectFail_t
{
    public CSteamID m_steamIDRemote;

    [NativeTypeName("uint8")]
    public byte m_eP2PSessionError;

    public const int k_iCallback = k_iSteamNetworkingCallbacks + 3;
}
