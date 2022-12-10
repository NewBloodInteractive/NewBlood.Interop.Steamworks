using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct StoreAuthURLResponse_t
{
    [NativeTypeName("char[512]")]
    public fixed sbyte m_szURL[512];

    public const int k_iCallback = k_iSteamUserCallbacks + 65;
}
