using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define STEAMPARENTALSETTINGS_INTERFACE_VERSION \"STEAMPARENTALSETTINGS_INTERFACE_VERSION001\"")]
    public static ReadOnlySpan<byte> STEAMPARENTALSETTINGS_INTERFACE_VERSION => "STEAMPARENTALSETTINGS_INTERFACE_VERSION001"u8;
}
