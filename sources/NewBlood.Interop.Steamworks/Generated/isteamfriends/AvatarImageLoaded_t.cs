using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct AvatarImageLoaded_t
{
    public CSteamID m_steamID;

    public int m_iImage;

    public int m_iWide;

    public int m_iTall;

    public const int k_iCallback = k_iSteamFriendsCallbacks + 34;
}
