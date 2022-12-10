using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SocketStatusCallback_t
{
    public SNetSocket_t m_hSocket;

    public SNetListenSocket_t m_hListenSocket;

    public CSteamID m_steamIDRemote;

    public int m_eSNetSocketState;

    public const int k_iCallback = k_iSteamNetworkingCallbacks + 1;
}
