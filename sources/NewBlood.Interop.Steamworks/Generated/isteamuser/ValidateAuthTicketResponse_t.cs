using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct ValidateAuthTicketResponse_t
{
    public CSteamID m_SteamID;

    public EAuthSessionResponse m_eAuthSessionResponse;

    public CSteamID m_OwnerSteamID;

    public const int k_iCallback = k_iSteamUserCallbacks + 43;
}
