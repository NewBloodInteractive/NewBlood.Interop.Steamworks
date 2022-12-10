using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct UserSubscribedItemsListChanged_t
{
    public AppId_t m_nAppID;

    public const int k_iCallback = k_iSteamUGCCallbacks + 18;
}
