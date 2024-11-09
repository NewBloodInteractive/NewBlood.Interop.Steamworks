using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SteamTimelineEventRecordingExists_t
{
    [NativeTypeName("uint64")]
    public ulong m_ulEventID;

    [NativeTypeName("bool")]
    public byte m_bRecordingExists;

    public const int k_iCallback = k_iSteamTimelineCallbacks + 2;
}
