using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct GameWebCallback_t
{
    [NativeTypeName("char[256]")]
    public fixed sbyte m_szURL[256];

    public const int k_iCallback = k_iSteamUserCallbacks + 64;
}
