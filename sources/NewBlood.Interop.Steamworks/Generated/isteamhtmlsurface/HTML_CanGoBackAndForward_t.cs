using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct HTML_CanGoBackAndForward_t
{
    public HHTMLBrowser unBrowserHandle;

    [NativeTypeName("bool")]
    public byte bCanGoBack;

    [NativeTypeName("bool")]
    public byte bCanGoForward;

    public const int k_iCallback = k_iSteamHTMLSurfaceCallbacks + 10;
}
