using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct SteamUGCQueryCompleted_t
{
    public UGCQueryHandle_t m_handle;

    public EResult m_eResult;

    [NativeTypeName("uint32")]
    public uint m_unNumResultsReturned;

    [NativeTypeName("uint32")]
    public uint m_unTotalMatchingResults;

    [NativeTypeName("bool")]
    public byte m_bCachedData;

    [NativeTypeName("char[256]")]
    public fixed sbyte m_rgchNextCursor[256];

    public const int k_iCallback = k_iSteamUGCCallbacks + 1;
}
