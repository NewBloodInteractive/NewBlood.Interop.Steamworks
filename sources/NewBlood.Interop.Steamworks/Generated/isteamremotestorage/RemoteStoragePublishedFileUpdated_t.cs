using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct RemoteStoragePublishedFileUpdated_t
{
    public PublishedFileId_t m_nPublishedFileId;

    public AppId_t m_nAppID;

    [NativeTypeName("uint64")]
    public ulong m_ulUnused;

    public const int k_iCallback = k_iSteamRemoteStorageCallbacks + 30;
}
