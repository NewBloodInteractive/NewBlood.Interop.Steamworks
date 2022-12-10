using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct PersonaStateChange_t
{
    [NativeTypeName("uint64")]
    public ulong m_ulSteamID;

    public int m_nChangeFlags;

    public const int k_iCallback = k_iSteamFriendsCallbacks + 4;
}
