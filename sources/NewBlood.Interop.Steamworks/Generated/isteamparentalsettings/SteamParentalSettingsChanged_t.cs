using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SteamParentalSettingsChanged_t
{

    public const int k_iCallback = k_ISteamParentalSettingsCallbacks + 1;
}
