using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SetPersonaNameResponse_t
{
    [NativeTypeName("bool")]
    public byte m_bSuccess;

    [NativeTypeName("bool")]
    public byte m_bLocalSuccess;

    public EResult m_result;

    public const int k_iCallback = k_iSteamFriendsCallbacks + 47;
}
