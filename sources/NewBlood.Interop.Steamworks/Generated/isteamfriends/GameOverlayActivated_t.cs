using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct GameOverlayActivated_t
{
    [NativeTypeName("uint8")]
    public byte m_bActive;

    public const int k_iCallback = k_iSteamFriendsCallbacks + 31;
}
