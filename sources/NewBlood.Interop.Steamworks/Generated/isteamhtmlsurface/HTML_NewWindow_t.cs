using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct HTML_NewWindow_t
{
    public HHTMLBrowser unBrowserHandle;

    [NativeTypeName("const char *")]
    public sbyte* pchURL;

    [NativeTypeName("uint32")]
    public uint unX;

    [NativeTypeName("uint32")]
    public uint unY;

    [NativeTypeName("uint32")]
    public uint unWide;

    [NativeTypeName("uint32")]
    public uint unTall;

    public HHTMLBrowser unNewWindow_BrowserHandle_IGNORE;

    public const int k_iCallback = k_iSteamHTMLSurfaceCallbacks + 21;
}
