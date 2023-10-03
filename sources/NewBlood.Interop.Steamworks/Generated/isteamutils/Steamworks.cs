using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define STEAMUTILS_INTERFACE_VERSION \"SteamUtils010\"")]
    public static ReadOnlySpan<byte> STEAMUTILS_INTERFACE_VERSION => "SteamUtils010"u8;
}
