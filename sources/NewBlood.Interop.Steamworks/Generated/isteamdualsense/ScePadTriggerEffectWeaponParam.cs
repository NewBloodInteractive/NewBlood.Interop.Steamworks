namespace NewBlood.Interop.Steamworks;

public unsafe partial struct ScePadTriggerEffectWeaponParam
{
    [NativeTypeName("uint8_t")]
    public byte startPosition;

    [NativeTypeName("uint8_t")]
    public byte endPosition;

    [NativeTypeName("uint8_t")]
    public byte strength;

    [NativeTypeName("uint8_t[45]")]
    public fixed byte padding[45];
}
