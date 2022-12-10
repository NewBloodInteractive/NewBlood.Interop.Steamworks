using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct MusicPlayerWantsVolume_t
{
    public float m_flNewVolume;

    public const int k_iCallback = k_iSteamMusicCallbacks + 11;
}
