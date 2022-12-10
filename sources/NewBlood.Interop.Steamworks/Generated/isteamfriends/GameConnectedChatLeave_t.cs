using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct GameConnectedChatLeave_t
{
    public CSteamID m_steamIDClanChat;

    public CSteamID m_steamIDUser;

    [NativeTypeName("bool")]
    public byte m_bKicked;

    [NativeTypeName("bool")]
    public byte m_bDropped;

    public const int k_iCallback = k_iSteamFriendsCallbacks + 40;
}
