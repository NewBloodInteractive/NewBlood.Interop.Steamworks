using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define STEAMNETWORKINGUTILS_INTERFACE_VERSION \"SteamNetworkingUtils004\"")]
    public static ReadOnlySpan<byte> STEAMNETWORKINGUTILS_INTERFACE_VERSION => "SteamNetworkingUtils004"u8;
}
