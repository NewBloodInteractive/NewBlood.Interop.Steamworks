using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct GSGameplayStats_t
{
    public EResult m_eResult;

    [NativeTypeName("int32")]
    public int m_nRank;

    [NativeTypeName("uint32")]
    public uint m_unTotalConnects;

    [NativeTypeName("uint32")]
    public uint m_unTotalMinutesPlayed;

    public const int k_iCallback = k_iSteamGameServerCallbacks + 7;
}
