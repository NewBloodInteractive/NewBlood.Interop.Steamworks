using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SteamInputActionEvent_t
{
    public InputHandle_t controllerHandle;

    public ESteamInputActionEventType eEventType;

    [NativeTypeName("__AnonymousRecord_isteaminput_L679_C2")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref AnalogAction_t analogAction
    {
        get
        {
            return ref Anonymous.analogAction;
        }
    }

    [UnscopedRef]
    public ref DigitalAction_t digitalAction
    {
        get
        {
            return ref Anonymous.digitalAction;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct AnalogAction_t
    {
        public InputAnalogActionHandle_t actionHandle;

        public InputAnalogActionData_t analogActionData;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct DigitalAction_t
    {
        public InputDigitalActionHandle_t actionHandle;

        public InputDigitalActionData_t digitalActionData;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("SteamInputActionEvent_t::AnalogAction_t")]
        public AnalogAction_t analogAction;

        [FieldOffset(0)]
        [NativeTypeName("SteamInputActionEvent_t::DigitalAction_t")]
        public DigitalAction_t digitalAction;
    }
}
