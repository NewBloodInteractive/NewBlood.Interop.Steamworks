namespace NewBlood.Interop.Steamworks;

public unsafe partial struct ScePadTriggerEffectMultiplePositionVibrationParam
{
    [NativeTypeName("uint8_t")]
    public byte frequency;

    [NativeTypeName("uint8_t[10]")]
    public fixed byte amplitude[10];

    [NativeTypeName("uint8_t[37]")]
    public fixed byte padding[37];
}
