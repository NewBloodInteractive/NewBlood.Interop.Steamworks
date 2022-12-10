using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct WorkshopEULAStatus_t
{
    public EResult m_eResult;

    public AppId_t m_nAppID;

    [NativeTypeName("uint32")]
    public uint m_unVersion;

    [NativeTypeName("RTime32")]
    public uint m_rtAction;

    [NativeTypeName("bool")]
    public byte m_bAccepted;

    [NativeTypeName("bool")]
    public byte m_bNeedsAction;

    public const int k_iCallback = k_iSteamUGCCallbacks + 20;
}
