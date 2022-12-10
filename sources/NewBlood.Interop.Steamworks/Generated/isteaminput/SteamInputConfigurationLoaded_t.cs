using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SteamInputConfigurationLoaded_t
{
    public AppId_t m_unAppID;

    public InputHandle_t m_ulDeviceHandle;

    public CSteamID m_ulMappingCreator;

    [NativeTypeName("uint32")]
    public uint m_unMajorRevision;

    [NativeTypeName("uint32")]
    public uint m_unMinorRevision;

    [NativeTypeName("bool")]
    public byte m_bUsesSteamInputAPI;

    [NativeTypeName("bool")]
    public byte m_bUsesGamepadAPI;

    public const int k_iCallback = k_iSteamControllerCallbacks + 3;
}
