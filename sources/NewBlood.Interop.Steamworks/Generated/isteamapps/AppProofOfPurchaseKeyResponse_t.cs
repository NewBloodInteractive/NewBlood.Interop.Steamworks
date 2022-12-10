using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct AppProofOfPurchaseKeyResponse_t
{
    public EResult m_eResult;

    [NativeTypeName("uint32")]
    public uint m_nAppID;

    [NativeTypeName("uint32")]
    public uint m_cchKeyLength;

    [NativeTypeName("char[240]")]
    public fixed sbyte m_rgchKey[240];

    public const int k_iCallback = k_iSteamAppsCallbacks + 21;
}
