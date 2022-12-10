using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct SteamNetAuthenticationStatus_t
{
    public ESteamNetworkingAvailability m_eAvail;

    [NativeTypeName("char[256]")]
    public fixed sbyte m_debugMsg[256];

    public const int k_iCallback = k_iSteamNetworkingSocketsCallbacks + 2;
}
