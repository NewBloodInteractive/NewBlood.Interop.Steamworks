using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct FriendGameInfo_t
{
    public CGameID m_gameID;

    [NativeTypeName("uint32")]
    public uint m_unGameIP;

    [NativeTypeName("uint16")]
    public ushort m_usGamePort;

    [NativeTypeName("uint16")]
    public ushort m_usQueryPort;

    public CSteamID m_steamIDLobby;
}
