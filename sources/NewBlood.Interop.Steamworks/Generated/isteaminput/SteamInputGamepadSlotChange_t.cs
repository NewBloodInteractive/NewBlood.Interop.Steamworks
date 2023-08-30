using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SteamInputGamepadSlotChange_t
{
    public AppId_t m_unAppID;

    public InputHandle_t m_ulDeviceHandle;

    public ESteamInputType m_eDeviceType;

    public int m_nOldGamepadSlot;

    public int m_nNewGamepadSlot;

    public const int k_iCallback = k_iSteamControllerCallbacks + 4;
}
