using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct SteamRelayNetworkStatus_t
{
    public ESteamNetworkingAvailability m_eAvail;

    public int m_bPingMeasurementInProgress;

    public ESteamNetworkingAvailability m_eAvailNetworkConfig;

    public ESteamNetworkingAvailability m_eAvailAnyRelay;

    [NativeTypeName("char[256]")]
    public fixed sbyte m_debugMsg[256];

    public const int k_iCallback = k_iSteamNetworkingUtilsCallbacks + 1;
}
