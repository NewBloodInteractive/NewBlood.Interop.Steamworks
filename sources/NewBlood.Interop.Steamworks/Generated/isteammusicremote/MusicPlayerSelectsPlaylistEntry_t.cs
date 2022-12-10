using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct MusicPlayerSelectsPlaylistEntry_t
{
    public int nID;

    public const int k_iCallback = k_iSteamMusicCallbacks + 13;
}
