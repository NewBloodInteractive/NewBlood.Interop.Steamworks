using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct RemoteStoragePublishFileProgress_t
{
    public double m_dPercentFile;

    [NativeTypeName("bool")]
    public byte m_bPreview;

    public const int k_iCallback = k_iSteamRemoteStorageCallbacks + 29;
}
