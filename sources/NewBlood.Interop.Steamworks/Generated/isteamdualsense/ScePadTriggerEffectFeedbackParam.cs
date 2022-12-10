namespace NewBlood.Interop.Steamworks;

public unsafe partial struct ScePadTriggerEffectFeedbackParam
{
    [NativeTypeName("uint8_t")]
    public byte position;

    [NativeTypeName("uint8_t")]
    public byte strength;

    [NativeTypeName("uint8_t[46]")]
    public fixed byte padding[46];
}
