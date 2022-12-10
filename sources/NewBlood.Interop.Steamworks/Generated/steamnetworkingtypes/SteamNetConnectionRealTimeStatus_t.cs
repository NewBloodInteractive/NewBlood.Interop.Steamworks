using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct SteamNetConnectionRealTimeStatus_t
{
    public ESteamNetworkingConnectionState m_eState;

    public int m_nPing;

    public float m_flConnectionQualityLocal;

    public float m_flConnectionQualityRemote;

    public float m_flOutPacketsPerSec;

    public float m_flOutBytesPerSec;

    public float m_flInPacketsPerSec;

    public float m_flInBytesPerSec;

    public int m_nSendRateBytesPerSecond;

    public int m_cbPendingUnreliable;

    public int m_cbPendingReliable;

    public int m_cbSentUnackedReliable;

    [NativeTypeName("SteamNetworkingMicroseconds")]
    public long m_usecQueueTime;

    [NativeTypeName("uint32[16]")]
    public fixed uint reserved[16];
}
