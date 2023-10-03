using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    public const int k_cchStatNameMax = 128;

    public const int k_cchLeaderboardNameMax = 128;

    public const int k_cLeaderboardDetailsMax = 64;

    [NativeTypeName("#define STEAMUSERSTATS_INTERFACE_VERSION \"STEAMUSERSTATS_INTERFACE_VERSION012\"")]
    public static ReadOnlySpan<byte> STEAMUSERSTATS_INTERFACE_VERSION => "STEAMUSERSTATS_INTERFACE_VERSION012"u8;
}
