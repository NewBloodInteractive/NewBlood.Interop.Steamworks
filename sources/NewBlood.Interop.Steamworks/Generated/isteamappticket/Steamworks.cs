using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define STEAMAPPTICKET_INTERFACE_VERSION \"STEAMAPPTICKET_INTERFACE_VERSION001\"")]
    public static ReadOnlySpan<byte> STEAMAPPTICKET_INTERFACE_VERSION => "STEAMAPPTICKET_INTERFACE_VERSION001"u8;
}
