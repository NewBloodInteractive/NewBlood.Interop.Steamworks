using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define STEAMNETWORKING_INTERFACE_VERSION \"SteamNetworking006\"")]
    public static ReadOnlySpan<byte> STEAMNETWORKING_INTERFACE_VERSION => "SteamNetworking006"u8;
}
