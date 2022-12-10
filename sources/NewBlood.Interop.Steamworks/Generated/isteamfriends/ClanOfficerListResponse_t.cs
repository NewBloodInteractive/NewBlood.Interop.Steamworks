using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct ClanOfficerListResponse_t
{
    public CSteamID m_steamIDClan;

    public int m_cOfficers;

    [NativeTypeName("uint8")]
    public byte m_bSuccess;

    public const int k_iCallback = k_iSteamFriendsCallbacks + 35;
}
