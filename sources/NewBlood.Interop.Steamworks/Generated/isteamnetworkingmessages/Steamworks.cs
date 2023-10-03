using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define STEAMNETWORKINGMESSAGES_INTERFACE_VERSION \"SteamNetworkingMessages002\"")]
    public static ReadOnlySpan<byte> STEAMNETWORKINGMESSAGES_INTERFACE_VERSION => "SteamNetworkingMessages002"u8;
}
