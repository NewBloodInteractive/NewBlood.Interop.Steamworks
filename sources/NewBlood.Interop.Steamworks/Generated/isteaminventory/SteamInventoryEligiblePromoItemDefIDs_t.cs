using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SteamInventoryEligiblePromoItemDefIDs_t
{
    public EResult m_result;

    public CSteamID m_steamID;

    public int m_numEligiblePromoItemDefs;

    [NativeTypeName("bool")]
    public byte m_bCachedData;

    public const int k_iCallback = k_iSteamInventoryCallbacks + 3;
}
