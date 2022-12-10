using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct LeaderboardScoresDownloaded_t
{
    public SteamLeaderboard_t m_hSteamLeaderboard;

    public SteamLeaderboardEntries_t m_hSteamLeaderboardEntries;

    public int m_cEntryCount;

    public const int k_iCallback = k_iSteamUserStatsCallbacks + 5;
}
