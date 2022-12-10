using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct GCMessageFailed_t
{

    public const int k_iCallback = k_iSteamGameCoordinatorCallbacks + 2;
}
