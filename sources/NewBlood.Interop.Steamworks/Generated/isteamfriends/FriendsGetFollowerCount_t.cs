using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct FriendsGetFollowerCount_t
{
    public EResult m_eResult;

    public CSteamID m_steamID;

    public int m_nCount;

    public const int k_iCallback = k_iSteamFriendsCallbacks + 44;
}
