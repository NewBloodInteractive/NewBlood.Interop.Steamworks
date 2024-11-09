using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct EquippedProfileItems_t
{
    public EResult m_eResult;

    public CSteamID m_steamID;

    [NativeTypeName("bool")]
    public byte m_bHasAnimatedAvatar;

    [NativeTypeName("bool")]
    public byte m_bHasAvatarFrame;

    [NativeTypeName("bool")]
    public byte m_bHasProfileModifier;

    [NativeTypeName("bool")]
    public byte m_bHasProfileBackground;

    [NativeTypeName("bool")]
    public byte m_bHasMiniProfileBackground;

    [NativeTypeName("bool")]
    public byte m_bFromCache;

    public const int k_iCallback = k_iSteamFriendsCallbacks + 51;
}
