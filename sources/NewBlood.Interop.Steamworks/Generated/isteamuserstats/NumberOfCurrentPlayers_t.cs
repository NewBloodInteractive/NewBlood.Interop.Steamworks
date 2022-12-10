using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct NumberOfCurrentPlayers_t
{
    [NativeTypeName("uint8")]
    public byte m_bSuccess;

    [NativeTypeName("int32")]
    public int m_cPlayers;

    public const int k_iCallback = k_iSteamUserStatsCallbacks + 7;
}
