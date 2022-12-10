using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct RegisterActivationCodeResponse_t
{
    public ERegisterActivationCodeResult m_eResult;

    [NativeTypeName("uint32")]
    public uint m_unPackageRegistered;

    public const int k_iCallback = k_iSteamAppsCallbacks + 8;
}
