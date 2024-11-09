using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct BroadcastUploadStop_t
{
    public EBroadcastUploadResult m_eResult;

    public const int k_iCallback = k_iSteamVideoCallbacks + 5;
}
