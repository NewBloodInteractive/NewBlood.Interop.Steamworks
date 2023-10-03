using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define STEAMUSER_INTERFACE_VERSION \"SteamUser023\"")]
    public static ReadOnlySpan<byte> STEAMUSER_INTERFACE_VERSION => "SteamUser023"u8;
}
