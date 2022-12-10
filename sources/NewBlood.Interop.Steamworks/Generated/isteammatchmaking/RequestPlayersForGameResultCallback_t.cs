using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct RequestPlayersForGameResultCallback_t
{
    public EResult m_eResult;

    [NativeTypeName("uint64")]
    public ulong m_ullSearchID;

    public CSteamID m_SteamIDPlayerFound;

    public CSteamID m_SteamIDLobby;

    [NativeTypeName("RequestPlayersForGameResultCallback_t::PlayerAcceptState_t")]
    public PlayerAcceptState_t m_ePlayerAcceptState;

    [NativeTypeName("int32")]
    public int m_nPlayerIndex;

    [NativeTypeName("int32")]
    public int m_nTotalPlayersFound;

    [NativeTypeName("int32")]
    public int m_nTotalPlayersAcceptedGame;

    [NativeTypeName("int32")]
    public int m_nSuggestedTeamIndex;

    [NativeTypeName("uint64")]
    public ulong m_ullUniqueGameID;

    public const int k_iCallback = k_iSteamGameSearchCallbacks + 12;

    public enum PlayerAcceptState_t
    {
        k_EStateUnknown = 0,
        k_EStatePlayerAccepted = 1,
        k_EStatePlayerDeclined = 2,
    }
}
