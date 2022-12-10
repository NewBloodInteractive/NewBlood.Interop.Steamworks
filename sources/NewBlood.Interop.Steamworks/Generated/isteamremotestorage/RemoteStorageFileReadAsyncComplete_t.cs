using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct RemoteStorageFileReadAsyncComplete_t
{
    public SteamAPICall_t m_hFileReadAsync;

    public EResult m_eResult;

    [NativeTypeName("uint32")]
    public uint m_nOffset;

    [NativeTypeName("uint32")]
    public uint m_cubRead;

    public const int k_iCallback = k_iSteamRemoteStorageCallbacks + 32;
}
