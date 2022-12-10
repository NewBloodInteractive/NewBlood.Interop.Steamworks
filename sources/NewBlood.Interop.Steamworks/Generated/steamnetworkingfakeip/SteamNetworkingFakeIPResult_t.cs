using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct SteamNetworkingFakeIPResult_t
{
    public EResult m_eResult;

    public SteamNetworkingIdentity m_identity;

    [NativeTypeName("uint32")]
    public uint m_unIP;

    [NativeTypeName("uint16[8]")]
    public fixed ushort m_unPorts[8];

    public const int k_iCallback = k_iSteamNetworkingSocketsCallbacks + 3;

    public const int k_nMaxReturnPorts = 8;
}
