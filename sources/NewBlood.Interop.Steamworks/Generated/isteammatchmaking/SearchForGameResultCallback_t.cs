using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SearchForGameResultCallback_t
{
    [NativeTypeName("uint64")]
    public ulong m_ullSearchID;

    public EResult m_eResult;

    [NativeTypeName("int32")]
    public int m_nCountPlayersInGame;

    [NativeTypeName("int32")]
    public int m_nCountAcceptedGame;

    public CSteamID m_steamIDHost;

    [NativeTypeName("bool")]
    public byte m_bFinalCallback;

    public const int k_iCallback = k_iSteamGameSearchCallbacks + 2;
}
