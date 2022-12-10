using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SteamInputDeviceDisconnected_t
{
    public InputHandle_t m_ulDisconnectedDeviceHandle;

    public const int k_iCallback = k_iSteamControllerCallbacks + 2;
}
