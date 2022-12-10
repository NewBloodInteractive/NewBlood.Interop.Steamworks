using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct GSClientAchievementStatus_t
{
    [NativeTypeName("uint64")]
    public ulong m_SteamID;

    [NativeTypeName("char[128]")]
    public fixed sbyte m_pchAchievement[128];

    [NativeTypeName("bool")]
    public byte m_bUnlocked;

    public const int k_iCallback = k_iSteamGameServerCallbacks + 6;
}
