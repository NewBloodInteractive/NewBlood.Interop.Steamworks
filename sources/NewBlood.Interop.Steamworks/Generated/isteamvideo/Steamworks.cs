using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define STEAMVIDEO_INTERFACE_VERSION \"STEAMVIDEO_INTERFACE_V007\"")]
    public static ReadOnlySpan<byte> STEAMVIDEO_INTERFACE_VERSION => "STEAMVIDEO_INTERFACE_V007"u8;
}
