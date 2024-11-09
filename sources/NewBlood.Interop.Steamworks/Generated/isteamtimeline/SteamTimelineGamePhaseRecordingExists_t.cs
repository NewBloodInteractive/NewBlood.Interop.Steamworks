using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct SteamTimelineGamePhaseRecordingExists_t
{
    [NativeTypeName("char[64]")]
    public fixed sbyte m_rgchPhaseID[64];

    [NativeTypeName("uint64")]
    public ulong m_ulRecordingMS;

    [NativeTypeName("uint64")]
    public ulong m_ulLongestClipMS;

    [NativeTypeName("uint32")]
    public uint m_unClipCount;

    [NativeTypeName("uint32")]
    public uint m_unScreenshotCount;

    public const int k_iCallback = k_iSteamTimelineCallbacks + 1;
}
