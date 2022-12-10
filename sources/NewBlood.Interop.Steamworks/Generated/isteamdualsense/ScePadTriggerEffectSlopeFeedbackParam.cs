namespace NewBlood.Interop.Steamworks;

public unsafe partial struct ScePadTriggerEffectSlopeFeedbackParam
{
    [NativeTypeName("uint8_t")]
    public byte startPosition;

    [NativeTypeName("uint8_t")]
    public byte endPosition;

    [NativeTypeName("uint8_t")]
    public byte startStrength;

    [NativeTypeName("uint8_t")]
    public byte endStrength;

    [NativeTypeName("uint8_t[44]")]
    public fixed byte padding[44];
}
