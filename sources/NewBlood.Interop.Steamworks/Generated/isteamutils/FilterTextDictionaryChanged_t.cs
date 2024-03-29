using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct FilterTextDictionaryChanged_t
{
    public int m_eLanguage;

    public const int k_iCallback = k_iSteamUtilsCallbacks + 39;
}
