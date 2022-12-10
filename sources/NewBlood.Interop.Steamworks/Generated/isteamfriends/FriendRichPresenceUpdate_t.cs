using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct FriendRichPresenceUpdate_t
{
    public CSteamID m_steamIDFriend;

    public AppId_t m_nAppID;

    public const int k_iCallback = k_iSteamFriendsCallbacks + 36;
}
