using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct GSClientKick_t
{
    public CSteamID m_SteamID;

    public EDenyReason m_eDenyReason;

    public const int k_iCallback = k_iSteamGameServerCallbacks + 3;
}
