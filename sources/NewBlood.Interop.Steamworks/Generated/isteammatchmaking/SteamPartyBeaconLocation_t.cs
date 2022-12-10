using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SteamPartyBeaconLocation_t
{
    public ESteamPartyBeaconLocationType m_eType;

    [NativeTypeName("uint64")]
    public ulong m_ulLocationID;
}
