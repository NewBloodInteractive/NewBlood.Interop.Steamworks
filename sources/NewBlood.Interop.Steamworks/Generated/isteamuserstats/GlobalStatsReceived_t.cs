using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct GlobalStatsReceived_t
{
    [NativeTypeName("uint64")]
    public ulong m_nGameID;

    public EResult m_eResult;

    public const int k_iCallback = k_iSteamUserStatsCallbacks + 12;
}
