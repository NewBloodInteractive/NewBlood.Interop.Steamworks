using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct LobbyChatMsg_t
{
    [NativeTypeName("uint64")]
    public ulong m_ulSteamIDLobby;

    [NativeTypeName("uint64")]
    public ulong m_ulSteamIDUser;

    [NativeTypeName("uint8")]
    public byte m_eChatEntryType;

    [NativeTypeName("uint32")]
    public uint m_iChatID;

    public const int k_iCallback = k_iSteamMatchmakingCallbacks + 7;
}
