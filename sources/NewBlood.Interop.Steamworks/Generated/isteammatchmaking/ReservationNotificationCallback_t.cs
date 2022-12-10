using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct ReservationNotificationCallback_t
{
    public PartyBeaconID_t m_ulBeaconID;

    public CSteamID m_steamIDJoiner;

    public const int k_iCallback = k_iSteamPartiesCallbacks + 3;
}
