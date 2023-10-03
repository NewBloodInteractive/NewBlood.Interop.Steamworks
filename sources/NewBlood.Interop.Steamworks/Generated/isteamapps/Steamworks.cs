using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const int")]
    public const int k_cubAppProofOfPurchaseKeyMax = 240;

    [NativeTypeName("#define STEAMAPPS_INTERFACE_VERSION \"STEAMAPPS_INTERFACE_VERSION008\"")]
    public static ReadOnlySpan<byte> STEAMAPPS_INTERFACE_VERSION => "STEAMAPPS_INTERFACE_VERSION008"u8;
}
