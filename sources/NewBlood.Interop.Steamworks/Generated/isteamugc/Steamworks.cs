using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const UGCQueryHandle_t")]
    public const ulong k_UGCQueryHandleInvalid = 0xffffffffffffffffUL;

    [NativeTypeName("const UGCUpdateHandle_t")]
    public const ulong k_UGCUpdateHandleInvalid = 0xffffffffffffffffUL;

    [NativeTypeName("const uint32")]
    public const uint kNumUGCResultsPerPage = 50;

    [NativeTypeName("const uint32")]
    public const uint k_cchDeveloperMetadataMax = 5000;

    [NativeTypeName("#define STEAMUGC_INTERFACE_VERSION \"STEAMUGC_INTERFACE_VERSION018\"")]
    public static ReadOnlySpan<byte> STEAMUGC_INTERFACE_VERSION => "STEAMUGC_INTERFACE_VERSION018"u8;
}
