using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct RemoteStoragePublishedFileSubscribed_t
{
    public PublishedFileId_t m_nPublishedFileId;

    public AppId_t m_nAppID;

    public const int k_iCallback = k_iSteamRemoteStorageCallbacks + 21;
}
