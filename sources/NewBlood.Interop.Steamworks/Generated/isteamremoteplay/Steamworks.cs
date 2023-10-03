using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define STEAMREMOTEPLAY_INTERFACE_VERSION \"STEAMREMOTEPLAY_INTERFACE_VERSION002\"")]
    public static ReadOnlySpan<byte> STEAMREMOTEPLAY_INTERFACE_VERSION => "STEAMREMOTEPLAY_INTERFACE_VERSION002"u8;
}
