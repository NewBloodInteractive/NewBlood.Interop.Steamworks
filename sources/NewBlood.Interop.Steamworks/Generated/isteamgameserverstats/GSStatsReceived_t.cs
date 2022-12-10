using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct GSStatsReceived_t
{
    public EResult m_eResult;

    public CSteamID m_steamIDUser;

    public const int k_iCallback = k_iSteamGameServerStatsCallbacks;
}
