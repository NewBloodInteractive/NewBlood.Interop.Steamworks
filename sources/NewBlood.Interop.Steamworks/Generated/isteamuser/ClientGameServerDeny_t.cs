using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct ClientGameServerDeny_t
{
    [NativeTypeName("uint32")]
    public uint m_uAppID;

    [NativeTypeName("uint32")]
    public uint m_unGameServerIP;

    [NativeTypeName("uint16")]
    public ushort m_usGameServerPort;

    [NativeTypeName("uint16")]
    public ushort m_bSecure;

    [NativeTypeName("uint32")]
    public uint m_uReason;

    public const int k_iCallback = k_iSteamUserCallbacks + 13;
}
