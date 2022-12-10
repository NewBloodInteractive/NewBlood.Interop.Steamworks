using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct RemoteStorageDeletePublishedFileResult_t
{
    public EResult m_eResult;

    public PublishedFileId_t m_nPublishedFileId;

    public const int k_iCallback = k_iSteamRemoteStorageCallbacks + 11;
}
