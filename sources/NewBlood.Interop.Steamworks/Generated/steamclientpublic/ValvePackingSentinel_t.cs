using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct ValvePackingSentinel_t
{
    [NativeTypeName("uint32")]
    public uint m_u32;

    [NativeTypeName("uint64")]
    public ulong m_u64;

    [NativeTypeName("uint16")]
    public ushort m_u16;

    public double m_d;
}
