using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct RemoteStorageGetPublishedFileDetailsResult_t
{
    public EResult m_eResult;

    public PublishedFileId_t m_nPublishedFileId;

    public AppId_t m_nCreatorAppID;

    public AppId_t m_nConsumerAppID;

    [NativeTypeName("char[129]")]
    public fixed sbyte m_rgchTitle[129];

    [NativeTypeName("char[8000]")]
    public fixed sbyte m_rgchDescription[8000];

    public UGCHandle_t m_hFile;

    public UGCHandle_t m_hPreviewFile;

    [NativeTypeName("uint64")]
    public ulong m_ulSteamIDOwner;

    [NativeTypeName("uint32")]
    public uint m_rtimeCreated;

    [NativeTypeName("uint32")]
    public uint m_rtimeUpdated;

    public ERemoteStoragePublishedFileVisibility m_eVisibility;

    [NativeTypeName("bool")]
    public byte m_bBanned;

    [NativeTypeName("char[1025]")]
    public fixed sbyte m_rgchTags[1025];

    [NativeTypeName("bool")]
    public byte m_bTagsTruncated;

    [NativeTypeName("char[260]")]
    public fixed sbyte m_pchFileName[260];

    [NativeTypeName("int32")]
    public int m_nFileSize;

    [NativeTypeName("int32")]
    public int m_nPreviewFileSize;

    [NativeTypeName("char[256]")]
    public fixed sbyte m_rgchURL[256];

    public EWorkshopFileType m_eFileType;

    [NativeTypeName("bool")]
    public byte m_bAcceptedForUse;

    public const int k_iCallback = k_iSteamRemoteStorageCallbacks + 18;
}
