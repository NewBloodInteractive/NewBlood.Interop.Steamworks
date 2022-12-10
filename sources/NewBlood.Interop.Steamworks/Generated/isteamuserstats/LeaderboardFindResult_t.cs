using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct LeaderboardFindResult_t
{
    public SteamLeaderboard_t m_hSteamLeaderboard;

    [NativeTypeName("uint8")]
    public byte m_bLeaderboardFound;

    public const int k_iCallback = k_iSteamUserStatsCallbacks + 4;
}
