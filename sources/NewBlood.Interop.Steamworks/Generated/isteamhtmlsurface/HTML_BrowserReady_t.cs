using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct HTML_BrowserReady_t
{
    public HHTMLBrowser unBrowserHandle;

    public const int k_iCallback = k_iSteamHTMLSurfaceCallbacks + 1;
}
