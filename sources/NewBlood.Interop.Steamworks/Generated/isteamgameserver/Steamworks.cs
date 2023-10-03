using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define STEAMGAMESERVER_INTERFACE_VERSION \"SteamGameServer015\"")]
    public static ReadOnlySpan<byte> STEAMGAMESERVER_INTERFACE_VERSION => "SteamGameServer015"u8;
}
