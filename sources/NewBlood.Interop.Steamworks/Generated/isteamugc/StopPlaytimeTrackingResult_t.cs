using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct StopPlaytimeTrackingResult_t
{
    public EResult m_eResult;

    public const int k_iCallback = k_iSteamUGCCallbacks + 11;
}
