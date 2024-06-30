using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const uint32")]
    public const uint k_unMaxTimelinePriority = 1000;

    [NativeTypeName("const float")]
    public const float k_flMaxTimelineEventDuration = 600.0f;

    [NativeTypeName("#define STEAMTIMELINE_INTERFACE_VERSION \"STEAMTIMELINE_INTERFACE_V001\"")]
    public static ReadOnlySpan<byte> STEAMTIMELINE_INTERFACE_VERSION => "STEAMTIMELINE_INTERFACE_V001"u8;
}
