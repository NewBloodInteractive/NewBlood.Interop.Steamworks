using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct DownloadClanActivityCountsResult_t
{
    [NativeTypeName("bool")]
    public byte m_bSuccess;

    public const int k_iCallback = k_iSteamFriendsCallbacks + 41;
}
