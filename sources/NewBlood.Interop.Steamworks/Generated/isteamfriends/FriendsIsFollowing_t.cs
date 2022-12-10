using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct FriendsIsFollowing_t
{
    public EResult m_eResult;

    public CSteamID m_steamID;

    [NativeTypeName("bool")]
    public byte m_bIsFollowing;

    public const int k_iCallback = k_iSteamFriendsCallbacks + 45;
}
