using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SteamAPICallCompleted_t
{
    public SteamAPICall_t m_hAsyncCall;

    public int m_iCallback;

    [NativeTypeName("uint32")]
    public uint m_cubParam;

    public const int k_iCallback = k_iSteamUtilsCallbacks + 3;
}
