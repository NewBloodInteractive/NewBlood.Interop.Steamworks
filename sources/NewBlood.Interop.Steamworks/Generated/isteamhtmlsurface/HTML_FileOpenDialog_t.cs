using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct HTML_FileOpenDialog_t
{
    public HHTMLBrowser unBrowserHandle;

    [NativeTypeName("const char *")]
    public sbyte* pchTitle;

    [NativeTypeName("const char *")]
    public sbyte* pchInitialFile;

    public const int k_iCallback = k_iSteamHTMLSurfaceCallbacks + 16;
}
