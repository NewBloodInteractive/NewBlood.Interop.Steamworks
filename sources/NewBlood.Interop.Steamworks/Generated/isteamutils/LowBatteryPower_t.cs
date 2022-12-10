using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct LowBatteryPower_t
{
    [NativeTypeName("uint8")]
    public byte m_nMinutesBatteryLeft;

    public const int k_iCallback = k_iSteamUtilsCallbacks + 2;
}
