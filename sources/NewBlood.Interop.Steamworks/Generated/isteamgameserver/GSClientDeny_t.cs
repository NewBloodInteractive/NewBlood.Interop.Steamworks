using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct GSClientDeny_t
{
    public CSteamID m_SteamID;

    public EDenyReason m_eDenyReason;

    [NativeTypeName("char[128]")]
    public fixed sbyte m_rgchOptionalText[128];

    public const int k_iCallback = k_iSteamGameServerCallbacks + 2;
}
