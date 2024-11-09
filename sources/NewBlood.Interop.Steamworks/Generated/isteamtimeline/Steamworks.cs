using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const uint32")]
    public const uint k_unMaxTimelinePriority = 1000;

    [NativeTypeName("const uint32")]
    public const uint k_unTimelinePriority_KeepCurrentValue = 1000000;

    [NativeTypeName("const float")]
    public const float k_flMaxTimelineEventDuration = 600.0f;

    [NativeTypeName("const uint32")]
    public const uint k_cchMaxPhaseIDLength = 64;

    [NativeTypeName("#define STEAMTIMELINE_INTERFACE_VERSION \"STEAMTIMELINE_INTERFACE_V004\"")]
    public static ReadOnlySpan<byte> STEAMTIMELINE_INTERFACE_VERSION => "STEAMTIMELINE_INTERFACE_V004"u8;
}
