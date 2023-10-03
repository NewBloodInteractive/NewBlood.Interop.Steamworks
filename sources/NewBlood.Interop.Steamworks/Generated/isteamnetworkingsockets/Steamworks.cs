using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define STEAMNETWORKINGSOCKETS_INTERFACE_VERSION \"SteamNetworkingSockets012\"")]
    public static ReadOnlySpan<byte> STEAMNETWORKINGSOCKETS_INTERFACE_VERSION => "SteamNetworkingSockets012"u8;
}
