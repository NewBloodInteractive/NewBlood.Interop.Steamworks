using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct DurationControl_t
{
    public EResult m_eResult;

    public AppId_t m_appid;

    [NativeTypeName("bool")]
    public byte m_bApplicable;

    [NativeTypeName("int32")]
    public int m_csecsLast5h;

    public EDurationControlProgress m_progress;

    public EDurationControlNotification m_notification;

    [NativeTypeName("int32")]
    public int m_csecsToday;

    [NativeTypeName("int32")]
    public int m_csecsRemaining;

    public const int k_iCallback = k_iSteamUserCallbacks + 67;
}
