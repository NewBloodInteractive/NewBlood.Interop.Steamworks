using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define k_SteamMusicNameMaxLength 255")]
    public const int k_SteamMusicNameMaxLength = 255;

    [NativeTypeName("#define k_SteamMusicPNGMaxLength 65535")]
    public const int k_SteamMusicPNGMaxLength = 65535;

    [NativeTypeName("#define STEAMMUSICREMOTE_INTERFACE_VERSION \"STEAMMUSICREMOTE_INTERFACE_VERSION001\"")]
    public static ReadOnlySpan<byte> STEAMMUSICREMOTE_INTERFACE_VERSION => "STEAMMUSICREMOTE_INTERFACE_VERSION001"u8;
}
