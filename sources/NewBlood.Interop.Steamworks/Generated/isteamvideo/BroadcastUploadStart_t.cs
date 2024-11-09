using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct BroadcastUploadStart_t
{
    [NativeTypeName("bool")]
    public byte m_bIsRTMP;

    public const int k_iCallback = k_iSteamVideoCallbacks + 4;
}
