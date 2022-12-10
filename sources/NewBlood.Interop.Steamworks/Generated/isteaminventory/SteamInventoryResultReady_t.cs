using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SteamInventoryResultReady_t
{
    public SteamInventoryResult_t m_handle;

    public EResult m_result;

    public const int k_iCallback = k_iSteamInventoryCallbacks + 0;
}
