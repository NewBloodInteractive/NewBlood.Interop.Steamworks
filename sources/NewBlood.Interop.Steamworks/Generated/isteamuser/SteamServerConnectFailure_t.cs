using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SteamServerConnectFailure_t
{
    public EResult m_eResult;

    [NativeTypeName("bool")]
    public byte m_bStillRetrying;

    public const int k_iCallback = k_iSteamUserCallbacks + 2;
}
