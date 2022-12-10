using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct IPCFailure_t
{
    [NativeTypeName("uint8")]
    public byte m_eFailureType;

    public const int k_iCallback = k_iSteamUserCallbacks + 17;

    public enum EFailureType
    {
        k_EFailureFlushedCallbackQueue,
        k_EFailurePipeFail,
    }
}
