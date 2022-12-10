using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct RemoteStorageFileShareResult_t
{
    public EResult m_eResult;

    public UGCHandle_t m_hFile;

    [NativeTypeName("char[260]")]
    public fixed sbyte m_rgchFilename[260];

    public const int k_iCallback = k_iSteamRemoteStorageCallbacks + 7;
}
