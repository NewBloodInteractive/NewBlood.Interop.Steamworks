using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct LobbyChatUpdate_t
{
    [NativeTypeName("uint64")]
    public ulong m_ulSteamIDLobby;

    [NativeTypeName("uint64")]
    public ulong m_ulSteamIDUserChanged;

    [NativeTypeName("uint64")]
    public ulong m_ulSteamIDMakingChange;

    [NativeTypeName("uint32")]
    public uint m_rgfChatMemberStateChange;

    public const int k_iCallback = k_iSteamMatchmakingCallbacks + 6;
}
