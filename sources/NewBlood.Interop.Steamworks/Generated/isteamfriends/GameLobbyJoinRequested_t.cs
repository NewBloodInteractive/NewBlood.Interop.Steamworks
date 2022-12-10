using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct GameLobbyJoinRequested_t
{
    public CSteamID m_steamIDLobby;

    public CSteamID m_steamIDFriend;

    public const int k_iCallback = k_iSteamFriendsCallbacks + 33;
}
