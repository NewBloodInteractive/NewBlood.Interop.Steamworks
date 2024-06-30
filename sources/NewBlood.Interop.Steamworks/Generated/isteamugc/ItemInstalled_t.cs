using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct ItemInstalled_t
{
    public AppId_t m_unAppID;

    public PublishedFileId_t m_nPublishedFileId;

    public UGCHandle_t m_hLegacyContent;

    [NativeTypeName("uint64")]
    public ulong m_unManifestID;

    public const int k_iCallback = k_iSteamUGCCallbacks + 5;
}
