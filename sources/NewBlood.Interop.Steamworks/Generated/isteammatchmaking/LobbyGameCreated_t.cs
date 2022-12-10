using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct LobbyGameCreated_t
{
    [NativeTypeName("uint64")]
    public ulong m_ulSteamIDLobby;

    [NativeTypeName("uint64")]
    public ulong m_ulSteamIDGameServer;

    [NativeTypeName("uint32")]
    public uint m_unIP;

    [NativeTypeName("uint16")]
    public ushort m_usPort;

    public const int k_iCallback = k_iSteamMatchmakingCallbacks + 9;
}
