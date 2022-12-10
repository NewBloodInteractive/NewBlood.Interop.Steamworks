using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct LeaderboardUGCSet_t
{
    public EResult m_eResult;

    public SteamLeaderboard_t m_hSteamLeaderboard;

    public const int k_iCallback = k_iSteamUserStatsCallbacks + 11;
}
