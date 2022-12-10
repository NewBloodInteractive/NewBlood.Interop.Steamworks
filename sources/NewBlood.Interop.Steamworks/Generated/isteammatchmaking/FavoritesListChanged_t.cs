using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct FavoritesListChanged_t
{
    [NativeTypeName("uint32")]
    public uint m_nIP;

    [NativeTypeName("uint32")]
    public uint m_nQueryPort;

    [NativeTypeName("uint32")]
    public uint m_nConnPort;

    [NativeTypeName("uint32")]
    public uint m_nAppID;

    [NativeTypeName("uint32")]
    public uint m_nFlags;

    [NativeTypeName("bool")]
    public byte m_bAdd;

    public AccountID_t m_unAccountId;

    public const int k_iCallback = k_iSteamMatchmakingCallbacks + 2;
}
