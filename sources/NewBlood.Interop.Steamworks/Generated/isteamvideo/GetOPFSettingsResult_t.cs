using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct GetOPFSettingsResult_t
{
    public EResult m_eResult;

    public AppId_t m_unVideoAppID;

    public const int k_iCallback = k_iSteamVideoCallbacks + 24;
}
