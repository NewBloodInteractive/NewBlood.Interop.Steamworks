using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct SteamInventoryRequestPricesResult_t
{
    public EResult m_result;

    [NativeTypeName("char[4]")]
    public fixed sbyte m_rgchCurrency[4];

    public const int k_iCallback = k_iSteamInventoryCallbacks + 5;
}
