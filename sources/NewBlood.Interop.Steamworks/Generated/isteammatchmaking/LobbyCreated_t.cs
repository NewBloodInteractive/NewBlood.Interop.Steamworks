using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct LobbyCreated_t
{
    public EResult m_eResult;

    [NativeTypeName("uint64")]
    public ulong m_ulSteamIDLobby;

    public const int k_iCallback = k_iSteamMatchmakingCallbacks + 13;
}
