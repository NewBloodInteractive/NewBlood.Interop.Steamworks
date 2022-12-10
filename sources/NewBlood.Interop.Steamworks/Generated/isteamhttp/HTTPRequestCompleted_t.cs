using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct HTTPRequestCompleted_t
{
    public HTTPRequestHandle m_hRequest;

    [NativeTypeName("uint64")]
    public ulong m_ulContextValue;

    [NativeTypeName("bool")]
    public byte m_bRequestSuccessful;

    public EHTTPStatusCode m_eStatusCode;

    [NativeTypeName("uint32")]
    public uint m_unBodySize;

    public const int k_iCallback = k_iSteamHTTPCallbacks + 1;
}
