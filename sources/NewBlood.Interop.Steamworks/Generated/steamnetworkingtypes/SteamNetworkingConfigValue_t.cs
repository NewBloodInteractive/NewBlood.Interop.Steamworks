using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

public partial struct SteamNetworkingConfigValue_t
{
    public ESteamNetworkingConfigValue m_eValue;

    public ESteamNetworkingConfigDataType m_eDataType;

    [NativeTypeName("union (anonymous union at ../../sdk/public/steam/steamnetworkingtypes.h:1689:2)")]
    public _m_val_e__Union m_val;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _m_val_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("int32_t")]
        public int m_int32;

        [FieldOffset(0)]
        [NativeTypeName("int64_t")]
        public long m_int64;

        [FieldOffset(0)]
        public float m_float;

        [FieldOffset(0)]
        [NativeTypeName("const char *")]
        public sbyte* m_string;

        [FieldOffset(0)]
        public void* m_ptr;
    }
}
