namespace NewBlood.Interop.Steamworks;

public unsafe partial struct ScePadTriggerEffectVibrationParam
{
    [NativeTypeName("uint8_t")]
    public byte position;

    [NativeTypeName("uint8_t")]
    public byte amplitude;

    [NativeTypeName("uint8_t")]
    public byte frequency;

    [NativeTypeName("uint8_t[45]")]
    public fixed byte padding[45];
}
