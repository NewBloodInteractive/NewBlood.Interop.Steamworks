using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct HTML_HorizontalScroll_t
{
    public HHTMLBrowser unBrowserHandle;

    [NativeTypeName("uint32")]
    public uint unScrollMax;

    [NativeTypeName("uint32")]
    public uint unScrollCurrent;

    public float flPageScale;

    [NativeTypeName("bool")]
    public byte bVisible;

    [NativeTypeName("uint32")]
    public uint unPageSize;

    public const int k_iCallback = k_iSteamHTMLSurfaceCallbacks + 11;
}
