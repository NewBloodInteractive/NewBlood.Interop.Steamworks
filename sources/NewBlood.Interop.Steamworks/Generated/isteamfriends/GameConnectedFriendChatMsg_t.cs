using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct GameConnectedFriendChatMsg_t
{
    public CSteamID m_steamIDUser;

    public int m_iMessageID;

    public const int k_iCallback = k_iSteamFriendsCallbacks + 43;
}
