using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define STEAMGAMESERVERSTATS_INTERFACE_VERSION \"SteamGameServerStats001\"")]
    public static ReadOnlySpan<byte> STEAMGAMESERVERSTATS_INTERFACE_VERSION => "SteamGameServerStats001"u8;
}
