using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

public unsafe partial struct ScePadTriggerEffectParam
{
    [NativeTypeName("uint8_t")]
    public byte triggerMask;

    [NativeTypeName("uint8_t[7]")]
    public fixed byte padding[7];

    [NativeTypeName("ScePadTriggerEffectCommand[2]")]
    public _command_e__FixedBuffer command;

    public partial struct _command_e__FixedBuffer
    {
        public ScePadTriggerEffectCommand e0;
        public ScePadTriggerEffectCommand e1;

        [UnscopedRef]
        public ref ScePadTriggerEffectCommand this[int index]
        {
            get
            {
                return ref AsSpan()[index];
            }
        }

        [UnscopedRef]
        public Span<ScePadTriggerEffectCommand> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
    }
}
