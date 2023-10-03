using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define STEAMMUSIC_INTERFACE_VERSION \"STEAMMUSIC_INTERFACE_VERSION001\"")]
    public static ReadOnlySpan<byte> STEAMMUSIC_INTERFACE_VERSION => "STEAMMUSIC_INTERFACE_VERSION001"u8;
}
