using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct HTTPRequestDataReceived_t
{
    public HTTPRequestHandle m_hRequest;

    [NativeTypeName("uint64")]
    public ulong m_ulContextValue;

    [NativeTypeName("uint32")]
    public uint m_cOffset;

    [NativeTypeName("uint32")]
    public uint m_cBytesReceived;

    public const int k_iCallback = k_iSteamHTTPCallbacks + 3;
}
