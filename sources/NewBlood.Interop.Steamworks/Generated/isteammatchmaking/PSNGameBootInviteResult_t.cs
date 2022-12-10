using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct PSNGameBootInviteResult_t
{
    [NativeTypeName("bool")]
    public byte m_bGameBootInviteExists;

    public CSteamID m_steamIDLobby;

    public const int k_iCallback = k_iSteamMatchmakingCallbacks + 15;
}
