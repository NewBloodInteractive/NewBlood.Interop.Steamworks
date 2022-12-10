using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct SteamUGCDetails_t
{
    public PublishedFileId_t m_nPublishedFileId;

    public EResult m_eResult;

    public EWorkshopFileType m_eFileType;

    public AppId_t m_nCreatorAppID;

    public AppId_t m_nConsumerAppID;

    [NativeTypeName("char[129]")]
    public fixed sbyte m_rgchTitle[129];

    [NativeTypeName("char[8000]")]
    public fixed sbyte m_rgchDescription[8000];

    [NativeTypeName("uint64")]
    public ulong m_ulSteamIDOwner;

    [NativeTypeName("uint32")]
    public uint m_rtimeCreated;

    [NativeTypeName("uint32")]
    public uint m_rtimeUpdated;

    [NativeTypeName("uint32")]
    public uint m_rtimeAddedToUserList;

    public ERemoteStoragePublishedFileVisibility m_eVisibility;

    [NativeTypeName("bool")]
    public byte m_bBanned;

    [NativeTypeName("bool")]
    public byte m_bAcceptedForUse;

    [NativeTypeName("bool")]
    public byte m_bTagsTruncated;

    [NativeTypeName("char[1025]")]
    public fixed sbyte m_rgchTags[1025];

    public UGCHandle_t m_hFile;

    public UGCHandle_t m_hPreviewFile;

    [NativeTypeName("char[260]")]
    public fixed sbyte m_pchFileName[260];

    [NativeTypeName("int32")]
    public int m_nFileSize;

    [NativeTypeName("int32")]
    public int m_nPreviewFileSize;

    [NativeTypeName("char[256]")]
    public fixed sbyte m_rgchURL[256];

    [NativeTypeName("uint32")]
    public uint m_unVotesUp;

    [NativeTypeName("uint32")]
    public uint m_unVotesDown;

    public float m_flScore;

    [NativeTypeName("uint32")]
    public uint m_unNumChildren;
}
