using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct UnreadChatMessagesChanged_t
{

    public const int k_iCallback = k_iSteamFriendsCallbacks + 48;
}
