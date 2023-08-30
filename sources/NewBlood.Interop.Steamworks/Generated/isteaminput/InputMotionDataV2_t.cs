using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct InputMotionDataV2_t
{
    public float driftCorrectedQuatX;

    public float driftCorrectedQuatY;

    public float driftCorrectedQuatZ;

    public float driftCorrectedQuatW;

    public float sensorFusionQuatX;

    public float sensorFusionQuatY;

    public float sensorFusionQuatZ;

    public float sensorFusionQuatW;

    public float deferredSensorFusionQuatX;

    public float deferredSensorFusionQuatY;

    public float deferredSensorFusionQuatZ;

    public float deferredSensorFusionQuatW;

    public float gravityX;

    public float gravityY;

    public float gravityZ;

    public float degreesPerSecondX;

    public float degreesPerSecondY;

    public float degreesPerSecondZ;
}
