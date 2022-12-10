using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SteamRemotePlaySessionConnected_t
{
    public RemotePlaySessionID_t m_unSessionID;

    public const int k_iCallback = k_iSteamRemotePlayCallbacks + 1;
}
