using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct LobbyDataUpdate_t
{
    [NativeTypeName("uint64")]
    public ulong m_ulSteamIDLobby;

    [NativeTypeName("uint64")]
    public ulong m_ulSteamIDMember;

    [NativeTypeName("uint8")]
    public byte m_bSuccess;

    public const int k_iCallback = k_iSteamMatchmakingCallbacks + 5;
}
