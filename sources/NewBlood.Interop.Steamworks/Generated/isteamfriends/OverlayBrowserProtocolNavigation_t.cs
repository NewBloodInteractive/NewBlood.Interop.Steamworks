using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct OverlayBrowserProtocolNavigation_t
{
    [NativeTypeName("char[1024]")]
    public fixed sbyte rgchURI[1024];

    public const int k_iCallback = k_iSteamFriendsCallbacks + 49;
}
