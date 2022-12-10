using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct GetVideoURLResult_t
{
    public EResult m_eResult;

    public AppId_t m_unVideoAppID;

    [NativeTypeName("char[256]")]
    public fixed sbyte m_rgchURL[256];

    public const int k_iCallback = k_iSteamVideoCallbacks + 11;
}
