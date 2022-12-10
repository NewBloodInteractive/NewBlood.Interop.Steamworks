using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct GameRichPresenceJoinRequested_t
{
    public CSteamID m_steamIDFriend;

    [NativeTypeName("char[256]")]
    public fixed sbyte m_rgchConnect[256];

    public const int k_iCallback = k_iSteamFriendsCallbacks + 37;
}
