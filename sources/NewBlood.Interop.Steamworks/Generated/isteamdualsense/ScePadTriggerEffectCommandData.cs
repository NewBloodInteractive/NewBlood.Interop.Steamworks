using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Explicit)]
public partial struct ScePadTriggerEffectCommandData
{
    [FieldOffset(0)]
    public ScePadTriggerEffectOffParam offParam;

    [FieldOffset(0)]
    public ScePadTriggerEffectFeedbackParam feedbackParam;

    [FieldOffset(0)]
    public ScePadTriggerEffectWeaponParam weaponParam;

    [FieldOffset(0)]
    public ScePadTriggerEffectVibrationParam vibrationParam;

    [FieldOffset(0)]
    public ScePadTriggerEffectMultiplePositionFeedbackParam multiplePositionFeedbackParam;

    [FieldOffset(0)]
    public ScePadTriggerEffectSlopeFeedbackParam slopeFeedbackParam;

    [FieldOffset(0)]
    public ScePadTriggerEffectMultiplePositionVibrationParam multiplePositionVibrationParam;
}
