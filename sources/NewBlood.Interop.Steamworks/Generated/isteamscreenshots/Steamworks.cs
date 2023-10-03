using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const uint32")]
    public const uint k_nScreenshotMaxTaggedUsers = 32;

    [NativeTypeName("const uint32")]
    public const uint k_nScreenshotMaxTaggedPublishedFiles = 32;

    [NativeTypeName("const int")]
    public const int k_cubUFSTagTypeMax = 255;

    [NativeTypeName("const int")]
    public const int k_cubUFSTagValueMax = 255;

    [NativeTypeName("const int")]
    public const int k_ScreenshotThumbWidth = 200;

    [NativeTypeName("#define INVALID_SCREENSHOT_HANDLE 0")]
    public const int INVALID_SCREENSHOT_HANDLE = 0;

    [NativeTypeName("#define STEAMSCREENSHOTS_INTERFACE_VERSION \"STEAMSCREENSHOTS_INTERFACE_VERSION003\"")]
    public static ReadOnlySpan<byte> STEAMSCREENSHOTS_INTERFACE_VERSION => "STEAMSCREENSHOTS_INTERFACE_VERSION003"u8;
}
