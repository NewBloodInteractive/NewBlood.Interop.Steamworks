using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SubmitItemUpdateResult_t
{
    public EResult m_eResult;

    [NativeTypeName("bool")]
    public byte m_bUserNeedsToAcceptWorkshopLegalAgreement;

    public PublishedFileId_t m_nPublishedFileId;

    public const int k_iCallback = k_iSteamUGCCallbacks + 4;
}
