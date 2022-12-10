using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SteamUGCRequestUGCDetailsResult_t
{
    public SteamUGCDetails_t m_details;

    [NativeTypeName("bool")]
    public byte m_bCachedData;

    public const int k_iCallback = k_iSteamUGCCallbacks + 2;
}
