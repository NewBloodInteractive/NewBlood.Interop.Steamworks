using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct P2PSessionState_t
{
    [NativeTypeName("uint8")]
    public byte m_bConnectionActive;

    [NativeTypeName("uint8")]
    public byte m_bConnecting;

    [NativeTypeName("uint8")]
    public byte m_eP2PSessionError;

    [NativeTypeName("uint8")]
    public byte m_bUsingRelay;

    [NativeTypeName("int32")]
    public int m_nBytesQueuedForSend;

    [NativeTypeName("int32")]
    public int m_nPacketsQueuedForSend;

    [NativeTypeName("uint32")]
    public uint m_nRemoteIP;

    [NativeTypeName("uint16")]
    public ushort m_nRemotePort;
}
