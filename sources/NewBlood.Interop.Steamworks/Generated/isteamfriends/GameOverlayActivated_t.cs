using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct GameOverlayActivated_t
{
    [NativeTypeName("uint8")]
    public byte m_bActive;

    [NativeTypeName("bool")]
    public byte m_bUserInitiated;

    public AppId_t m_nAppID;

    [NativeTypeName("uint32")]
    public uint m_dwOverlayPID;

    public const int k_iCallback = k_iSteamFriendsCallbacks + 31;
}
