using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct GetTicketForWebApiResponse_t
{
    public HAuthTicket m_hAuthTicket;

    public EResult m_eResult;

    public int m_cubTicket;

    [NativeTypeName("uint8[2560]")]
    public fixed byte m_rgubTicket[2560];

    public const int k_iCallback = k_iSteamUserCallbacks + 68;
    [NativeTypeName("const int")]
    public const int k_nCubTicketMaxLength = 2560;
}
