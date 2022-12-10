using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct FileDetailsResult_t
{
    public EResult m_eResult;

    [NativeTypeName("uint64")]
    public ulong m_ulFileSize;

    [NativeTypeName("uint8[20]")]
    public fixed byte m_FileSHA[20];

    [NativeTypeName("uint32")]
    public uint m_unFlags;

    public const int k_iCallback = k_iSteamAppsCallbacks + 23;
}
