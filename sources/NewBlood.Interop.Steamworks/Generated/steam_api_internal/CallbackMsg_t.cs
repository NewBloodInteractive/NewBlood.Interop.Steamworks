using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct CallbackMsg_t
{
    public HSteamUser m_hSteamUser;

    public int m_iCallback;

    [NativeTypeName("uint8 *")]
    public byte* m_pubParam;

    public int m_cubParam;
}
