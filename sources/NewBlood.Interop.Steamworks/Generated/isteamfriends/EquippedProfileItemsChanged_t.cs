using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct EquippedProfileItemsChanged_t
{
    public CSteamID m_steamID;

    public const int k_iCallback = k_iSteamFriendsCallbacks + 50;
}
