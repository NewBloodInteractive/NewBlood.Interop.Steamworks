using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct InputAnalogActionData_t
{
    public EInputSourceMode eMode;

    public float x;

    public float y;

    [NativeTypeName("bool")]
    public byte bActive;
}
