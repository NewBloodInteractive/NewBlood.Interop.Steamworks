using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct UserAchievementStored_t
{
    [NativeTypeName("uint64")]
    public ulong m_nGameID;

    [NativeTypeName("bool")]
    public byte m_bGroupAchievement;

    [NativeTypeName("char[128]")]
    public fixed sbyte m_rgchAchievementName[128];

    [NativeTypeName("uint32")]
    public uint m_nCurProgress;

    [NativeTypeName("uint32")]
    public uint m_nMaxProgress;

    public const int k_iCallback = k_iSteamUserStatsCallbacks + 3;
}
