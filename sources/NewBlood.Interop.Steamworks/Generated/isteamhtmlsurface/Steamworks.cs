using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const uint32")]
    public const uint INVALID_HTMLBROWSER = 0;

    [NativeTypeName("#define STEAMHTMLSURFACE_INTERFACE_VERSION \"STEAMHTMLSURFACE_INTERFACE_VERSION_005\"")]
    public static ReadOnlySpan<byte> STEAMHTMLSURFACE_INTERFACE_VERSION => "STEAMHTMLSURFACE_INTERFACE_VERSION_005"u8;
}
