using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct GameServerChangeRequested_t
{
    [NativeTypeName("char[64]")]
    public fixed sbyte m_rgchServer[64];

    [NativeTypeName("char[64]")]
    public fixed sbyte m_rgchPassword[64];

    public const int k_iCallback = k_iSteamFriendsCallbacks + 32;
}
