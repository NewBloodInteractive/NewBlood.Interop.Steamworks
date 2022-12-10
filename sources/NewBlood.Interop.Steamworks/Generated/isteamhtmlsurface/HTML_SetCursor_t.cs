using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct HTML_SetCursor_t
{
    public HHTMLBrowser unBrowserHandle;

    [NativeTypeName("uint32")]
    public uint eMouseCursor;

    public const int k_iCallback = k_iSteamHTMLSurfaceCallbacks + 22;
}
