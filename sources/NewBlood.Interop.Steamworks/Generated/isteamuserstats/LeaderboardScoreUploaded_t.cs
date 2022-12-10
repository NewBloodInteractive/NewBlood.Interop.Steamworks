using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct LeaderboardScoreUploaded_t
{
    [NativeTypeName("uint8")]
    public byte m_bSuccess;

    public SteamLeaderboard_t m_hSteamLeaderboard;

    [NativeTypeName("int32")]
    public int m_nScore;

    [NativeTypeName("uint8")]
    public byte m_bScoreChanged;

    public int m_nGlobalRankNew;

    public int m_nGlobalRankPrevious;

    public const int k_iCallback = k_iSteamUserStatsCallbacks + 6;
}
