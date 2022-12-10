using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SearchForGameProgressCallback_t
{
    [NativeTypeName("uint64")]
    public ulong m_ullSearchID;

    public EResult m_eResult;

    public CSteamID m_lobbyID;

    public CSteamID m_steamIDEndedSearch;

    [NativeTypeName("int32")]
    public int m_nSecondsRemainingEstimate;

    [NativeTypeName("int32")]
    public int m_cPlayersSearching;

    public const int k_iCallback = k_iSteamGameSearchCallbacks + 1;
}
