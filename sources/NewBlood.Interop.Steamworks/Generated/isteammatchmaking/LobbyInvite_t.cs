using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct LobbyInvite_t
{
    [NativeTypeName("uint64")]
    public ulong m_ulSteamIDUser;

    [NativeTypeName("uint64")]
    public ulong m_ulSteamIDLobby;

    [NativeTypeName("uint64")]
    public ulong m_ulGameID;

    public const int k_iCallback = k_iSteamMatchmakingCallbacks + 3;
}
