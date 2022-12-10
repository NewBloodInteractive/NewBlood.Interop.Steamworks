using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct SteamNetConnectionRealTimeLaneStatus_t
{
    public int m_cbPendingUnreliable;

    public int m_cbPendingReliable;

    public int m_cbSentUnackedReliable;

    public int _reservePad1;

    [NativeTypeName("SteamNetworkingMicroseconds")]
    public long m_usecQueueTime;

    [NativeTypeName("uint32[10]")]
    public fixed uint reserved[10];
}
