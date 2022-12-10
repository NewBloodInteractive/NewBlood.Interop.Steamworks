using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct JoinPartyCallback_t
{
    public EResult m_eResult;

    public PartyBeaconID_t m_ulBeaconID;

    public CSteamID m_SteamIDBeaconOwner;

    [NativeTypeName("char[256]")]
    public fixed sbyte m_rgchConnectString[256];

    public const int k_iCallback = k_iSteamPartiesCallbacks + 1;
}
