using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct HTML_SearchResults_t
{
    public HHTMLBrowser unBrowserHandle;

    [NativeTypeName("uint32")]
    public uint unResults;

    [NativeTypeName("uint32")]
    public uint unCurrentMatch;

    public const int k_iCallback = k_iSteamHTMLSurfaceCallbacks + 9;
}
