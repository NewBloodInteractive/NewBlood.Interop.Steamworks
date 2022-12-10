using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct GSClientGroupStatus_t
{
    public CSteamID m_SteamIDUser;

    public CSteamID m_SteamIDGroup;

    [NativeTypeName("bool")]
    public byte m_bMember;

    [NativeTypeName("bool")]
    public byte m_bOfficer;

    public const int k_iCallback = k_iSteamGameServerCallbacks + 8;
}
