using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct MusicPlayerWantsPlayingRepeatStatus_t
{
    public int m_nPlayingRepeatStatus;

    public const int k_iCallback = k_iSteamMusicRemoteCallbacks + 14;
}
