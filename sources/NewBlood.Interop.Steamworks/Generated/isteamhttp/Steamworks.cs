using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define INVALID_HTTPREQUEST_HANDLE 0")]
    public const int INVALID_HTTPREQUEST_HANDLE = 0;

    [NativeTypeName("#define INVALID_HTTPCOOKIE_HANDLE 0")]
    public const int INVALID_HTTPCOOKIE_HANDLE = 0;

    [NativeTypeName("#define STEAMHTTP_INTERFACE_VERSION \"STEAMHTTP_INTERFACE_VERSION003\"")]
    public static ReadOnlySpan<byte> STEAMHTTP_INTERFACE_VERSION => "STEAMHTTP_INTERFACE_VERSION003"u8;
}
