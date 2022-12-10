using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct HTML_NeedsPaint_t
{
    public HHTMLBrowser unBrowserHandle;

    [NativeTypeName("const char *")]
    public sbyte* pBGRA;

    [NativeTypeName("uint32")]
    public uint unWide;

    [NativeTypeName("uint32")]
    public uint unTall;

    [NativeTypeName("uint32")]
    public uint unUpdateX;

    [NativeTypeName("uint32")]
    public uint unUpdateY;

    [NativeTypeName("uint32")]
    public uint unUpdateWide;

    [NativeTypeName("uint32")]
    public uint unUpdateTall;

    [NativeTypeName("uint32")]
    public uint unScrollX;

    [NativeTypeName("uint32")]
    public uint unScrollY;

    public float flPageScale;

    [NativeTypeName("uint32")]
    public uint unPageSerial;

    public const int k_iCallback = k_iSteamHTMLSurfaceCallbacks + 2;
}
