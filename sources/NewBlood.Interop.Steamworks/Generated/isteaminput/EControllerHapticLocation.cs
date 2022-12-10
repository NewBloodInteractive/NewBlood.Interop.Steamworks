using static NewBlood.Interop.Steamworks.ESteamControllerPad;

namespace NewBlood.Interop.Steamworks;

public enum EControllerHapticLocation
{
    k_EControllerHapticLocation_Left = (1 << k_ESteamControllerPad_Left),
    k_EControllerHapticLocation_Right = (1 << k_ESteamControllerPad_Right),
    k_EControllerHapticLocation_Both = (1 << k_ESteamControllerPad_Left | 1 << k_ESteamControllerPad_Right),
}
