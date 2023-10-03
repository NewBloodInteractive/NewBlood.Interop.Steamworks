using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define STEAMCLIENT_INTERFACE_VERSION \"SteamClient020\"")]
    public static ReadOnlySpan<byte> STEAMCLIENT_INTERFACE_VERSION => "SteamClient020"u8;
}
