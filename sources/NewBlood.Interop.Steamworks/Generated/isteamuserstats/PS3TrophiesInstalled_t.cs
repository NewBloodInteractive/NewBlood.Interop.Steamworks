using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct PS3TrophiesInstalled_t
{
    [NativeTypeName("uint64")]
    public ulong m_nGameID;

    public EResult m_eResult;

    [NativeTypeName("uint64")]
    public ulong m_ulRequiredDiskSpace;

    public const int k_iCallback = k_iSteamUserStatsCallbacks + 12;
}
