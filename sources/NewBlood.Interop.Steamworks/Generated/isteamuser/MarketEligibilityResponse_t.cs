using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct MarketEligibilityResponse_t
{
    [NativeTypeName("bool")]
    public byte m_bAllowed;

    public EMarketNotAllowedReasonFlags m_eNotAllowedReason;

    [NativeTypeName("RTime32")]
    public uint m_rtAllowedAtTime;

    public int m_cdaySteamGuardRequiredDays;

    public int m_cdayNewDeviceCooldown;

    public const int k_iCallback = k_iSteamUserCallbacks + 66;
}
