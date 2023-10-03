using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const SteamInventoryResult_t")]
    public const int k_SteamInventoryResultInvalid = -1;

    [NativeTypeName("const SteamInventoryUpdateHandle_t")]
    public const ulong k_SteamInventoryUpdateHandleInvalid = 0xffffffffffffffffUL;

    [NativeTypeName("#define STEAMINVENTORY_INTERFACE_VERSION \"STEAMINVENTORY_INTERFACE_V003\"")]
    public static ReadOnlySpan<byte> STEAMINVENTORY_INTERFACE_VERSION => "STEAMINVENTORY_INTERFACE_V003"u8;
}
