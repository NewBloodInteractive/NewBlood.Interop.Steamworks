using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct DownloadItemResult_t
{
    public AppId_t m_unAppID;

    public PublishedFileId_t m_nPublishedFileId;

    public EResult m_eResult;

    public const int k_iCallback = k_iSteamUGCCallbacks + 6;
}
