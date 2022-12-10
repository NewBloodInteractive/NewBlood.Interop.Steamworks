using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct TimedTrialStatus_t
{
    public AppId_t m_unAppID;

    [NativeTypeName("bool")]
    public byte m_bIsOffline;

    [NativeTypeName("uint32")]
    public uint m_unSecondsAllowed;

    [NativeTypeName("uint32")]
    public uint m_unSecondsPlayed;

    public const int k_iCallback = k_iSteamAppsCallbacks + 30;
}
