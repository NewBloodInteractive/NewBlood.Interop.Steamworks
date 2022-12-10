using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct HTML_URLChanged_t
{
    public HHTMLBrowser unBrowserHandle;

    [NativeTypeName("const char *")]
    public sbyte* pchURL;

    [NativeTypeName("const char *")]
    public sbyte* pchPostData;

    [NativeTypeName("bool")]
    public byte bIsRedirect;

    [NativeTypeName("const char *")]
    public sbyte* pchPageTitle;

    [NativeTypeName("bool")]
    public byte bNewNavigation;

    public const int k_iCallback = k_iSteamHTMLSurfaceCallbacks + 5;
}
