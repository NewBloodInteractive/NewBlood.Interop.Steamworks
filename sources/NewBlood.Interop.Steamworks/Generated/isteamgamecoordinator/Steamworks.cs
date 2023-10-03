using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define STEAMGAMECOORDINATOR_INTERFACE_VERSION \"SteamGameCoordinator001\"")]
    public static ReadOnlySpan<byte> STEAMGAMECOORDINATOR_INTERFACE_VERSION => "SteamGameCoordinator001"u8;
}
