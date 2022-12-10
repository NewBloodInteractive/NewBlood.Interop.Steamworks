namespace NewBlood.Interop.Steamworks;

public unsafe partial struct ScePadTriggerEffectCommand
{
    public ScePadTriggerEffectMode mode;

    [NativeTypeName("uint8_t[4]")]
    public fixed byte padding[4];

    public ScePadTriggerEffectCommandData commandData;
}
