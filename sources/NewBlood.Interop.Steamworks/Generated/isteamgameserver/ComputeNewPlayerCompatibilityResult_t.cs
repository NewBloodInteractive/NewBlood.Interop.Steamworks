using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct ComputeNewPlayerCompatibilityResult_t
{
    public EResult m_eResult;

    public int m_cPlayersThatDontLikeCandidate;

    public int m_cPlayersThatCandidateDoesntLike;

    public int m_cClanPlayersThatDontLikeCandidate;

    public CSteamID m_SteamIDCandidate;

    public const int k_iCallback = k_iSteamGameServerCallbacks + 11;
}
