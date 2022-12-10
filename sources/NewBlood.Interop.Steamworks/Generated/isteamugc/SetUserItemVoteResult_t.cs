using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SetUserItemVoteResult_t
{
    public PublishedFileId_t m_nPublishedFileId;

    public EResult m_eResult;

    [NativeTypeName("bool")]
    public byte m_bVoteUp;

    public const int k_iCallback = k_iSteamUGCCallbacks + 8;
}
