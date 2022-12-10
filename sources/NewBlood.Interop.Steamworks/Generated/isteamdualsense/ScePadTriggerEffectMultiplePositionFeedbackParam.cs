namespace NewBlood.Interop.Steamworks;

public unsafe partial struct ScePadTriggerEffectMultiplePositionFeedbackParam
{
    [NativeTypeName("uint8_t[10]")]
    public fixed byte strength[10];

    [NativeTypeName("uint8_t[38]")]
    public fixed byte padding[38];
}
