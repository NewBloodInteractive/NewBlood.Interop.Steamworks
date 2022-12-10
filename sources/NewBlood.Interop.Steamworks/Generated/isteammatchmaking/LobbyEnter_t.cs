using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct LobbyEnter_t
{
    [NativeTypeName("uint64")]
    public ulong m_ulSteamIDLobby;

    [NativeTypeName("uint32")]
    public uint m_rgfChatPermissions;

    [NativeTypeName("bool")]
    public byte m_bLocked;

    [NativeTypeName("uint32")]
    public uint m_EChatRoomEnterResponse;

    public const int k_iCallback = k_iSteamMatchmakingCallbacks + 4;
}
