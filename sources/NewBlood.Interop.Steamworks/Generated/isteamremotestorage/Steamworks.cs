namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const uint32")]
    public const uint k_unMaxCloudFileChunkSize = 100 * 1024 * 1024;

    [NativeTypeName("const PublishedFileId_t")]
    public const ulong k_PublishedFileIdInvalid = 0;

    [NativeTypeName("const UGCHandle_t")]
    public const ulong k_UGCHandleInvalid = 0xffffffffffffffffUL;

    [NativeTypeName("const PublishedFileUpdateHandle_t")]
    public const ulong k_PublishedFileUpdateHandleInvalid = 0xffffffffffffffffUL;

    [NativeTypeName("const UGCFileWriteStreamHandle_t")]
    public const ulong k_UGCFileStreamHandleInvalid = 0xffffffffffffffffUL;

    [NativeTypeName("const uint32")]
    public const uint k_cchPublishedDocumentTitleMax = 128 + 1;

    [NativeTypeName("const uint32")]
    public const uint k_cchPublishedDocumentDescriptionMax = 8000;

    [NativeTypeName("const uint32")]
    public const uint k_cchPublishedDocumentChangeDescriptionMax = 8000;

    [NativeTypeName("const uint32")]
    public const uint k_unEnumeratePublishedFilesMaxResults = 50;

    [NativeTypeName("const uint32")]
    public const uint k_cchTagListMax = 1024 + 1;

    [NativeTypeName("const uint32")]
    public const uint k_cchFilenameMax = 260;

    [NativeTypeName("const uint32")]
    public const uint k_cchPublishedFileURLMax = 256;
}
