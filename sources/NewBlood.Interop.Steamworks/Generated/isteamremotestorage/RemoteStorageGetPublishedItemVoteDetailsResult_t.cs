using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct RemoteStorageGetPublishedItemVoteDetailsResult_t
{
    public EResult m_eResult;

    public PublishedFileId_t m_unPublishedFileId;

    [NativeTypeName("int32")]
    public int m_nVotesFor;

    [NativeTypeName("int32")]
    public int m_nVotesAgainst;

    [NativeTypeName("int32")]
    public int m_nReports;

    public float m_fScore;

    public const int k_iCallback = k_iSteamRemoteStorageCallbacks + 20;
}
