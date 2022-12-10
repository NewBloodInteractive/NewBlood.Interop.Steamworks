using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct JoinClanChatRoomCompletionResult_t
{
    public CSteamID m_steamIDClanChat;

    public EChatRoomEnterResponse m_eChatRoomEnterResponse;

    public const int k_iCallback = k_iSteamFriendsCallbacks + 42;
}
