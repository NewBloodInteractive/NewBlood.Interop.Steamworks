using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct GamepadTextInputDismissed_t
{
    [NativeTypeName("bool")]
    public byte m_bSubmitted;

    [NativeTypeName("uint32")]
    public uint m_unSubmittedText;

    public AppId_t m_unAppID;

    public const int k_iCallback = k_iSteamUtilsCallbacks + 14;
}
