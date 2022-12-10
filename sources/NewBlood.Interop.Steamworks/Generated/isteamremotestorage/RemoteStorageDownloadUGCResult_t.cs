using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct RemoteStorageDownloadUGCResult_t
{
    public EResult m_eResult;

    public UGCHandle_t m_hFile;

    public AppId_t m_nAppID;

    [NativeTypeName("int32")]
    public int m_nSizeInBytes;

    [NativeTypeName("char[260]")]
    public fixed sbyte m_pchFileName[260];

    [NativeTypeName("uint64")]
    public ulong m_ulSteamIDOwner;

    public const int k_iCallback = k_iSteamRemoteStorageCallbacks + 17;
}
