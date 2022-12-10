using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SteamInventoryStartPurchaseResult_t
{
    public EResult m_result;

    [NativeTypeName("uint64")]
    public ulong m_ulOrderID;

    [NativeTypeName("uint64")]
    public ulong m_ulTransID;

    public const int k_iCallback = k_iSteamInventoryCallbacks + 4;
}
