using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct UserAchievementIconFetched_t
{
    public CGameID m_nGameID;

    [NativeTypeName("char[128]")]
    public fixed sbyte m_rgchAchievementName[128];

    [NativeTypeName("bool")]
    public byte m_bAchieved;

    public int m_nIconHandle;

    public const int k_iCallback = k_iSteamUserStatsCallbacks + 9;
}
