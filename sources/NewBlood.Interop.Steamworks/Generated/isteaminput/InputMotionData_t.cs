using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct InputMotionData_t
{
    public float rotQuatX;

    public float rotQuatY;

    public float rotQuatZ;

    public float rotQuatW;

    public float posAccelX;

    public float posAccelY;

    public float posAccelZ;

    public float rotVelX;

    public float rotVelY;

    public float rotVelZ;
}
