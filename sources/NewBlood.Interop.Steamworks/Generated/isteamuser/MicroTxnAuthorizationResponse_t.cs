using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct MicroTxnAuthorizationResponse_t
{
    [NativeTypeName("uint32")]
    public uint m_unAppID;

    [NativeTypeName("uint64")]
    public ulong m_ulOrderID;

    [NativeTypeName("uint8")]
    public byte m_bAuthorized;

    public const int k_iCallback = k_iSteamUserCallbacks + 52;
}
