using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct LeaderboardEntry_t
{
    public CSteamID m_steamIDUser;

    [NativeTypeName("int32")]
    public int m_nGlobalRank;

    [NativeTypeName("int32")]
    public int m_nScore;

    [NativeTypeName("int32")]
    public int m_cDetails;

    public UGCHandle_t m_hUGC;
}
