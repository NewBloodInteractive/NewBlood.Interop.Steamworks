using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define STEAMAPPLIST_INTERFACE_VERSION \"STEAMAPPLIST_INTERFACE_VERSION001\"")]
    public static ReadOnlySpan<byte> STEAMAPPLIST_INTERFACE_VERSION => "STEAMAPPLIST_INTERFACE_VERSION001"u8;
}
