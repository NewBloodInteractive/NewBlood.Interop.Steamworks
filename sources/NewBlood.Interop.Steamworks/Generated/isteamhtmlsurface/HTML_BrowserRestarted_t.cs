using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct HTML_BrowserRestarted_t
{
    public HHTMLBrowser unBrowserHandle;

    public HHTMLBrowser unOldBrowserHandle;

    public const int k_iCallback = k_iSteamHTMLSurfaceCallbacks + 27;
}
