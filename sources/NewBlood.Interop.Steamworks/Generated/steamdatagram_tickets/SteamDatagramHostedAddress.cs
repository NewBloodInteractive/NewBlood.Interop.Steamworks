using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct SteamDatagramHostedAddress
{
    public int m_cbSize;

    [NativeTypeName("char[128]")]
    public fixed sbyte m_data[128];
}
