using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct LobbyMatchList_t
{
    [NativeTypeName("uint32")]
    public uint m_nLobbiesMatching;

    public const int k_iCallback = k_iSteamMatchmakingCallbacks + 10;
}
