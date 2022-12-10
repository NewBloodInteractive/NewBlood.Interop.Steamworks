using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct GCMessageAvailable_t
{
    [NativeTypeName("uint32")]
    public uint m_nMessageSize;

    public const int k_iCallback = k_iSteamGameCoordinatorCallbacks + 1;
}
