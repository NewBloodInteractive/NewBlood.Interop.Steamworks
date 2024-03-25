using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

public static unsafe partial class Steamworks
{
    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern HSteamPipe SteamAPI_GetHSteamPipe();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern HSteamUser SteamAPI_GetHSteamUser();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern HSteamPipe SteamGameServer_GetHSteamPipe();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern HSteamUser SteamGameServer_GetHSteamUser();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* SteamInternal_ContextInit(void* pContextInitData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* SteamInternal_CreateInterface([NativeTypeName("const char *")] sbyte* ver);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* SteamInternal_FindOrCreateUserInterface(HSteamUser hSteamUser, [NativeTypeName("const char *")] sbyte* pszVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* SteamInternal_FindOrCreateGameServerInterface(HSteamUser hSteamUser, [NativeTypeName("const char *")] sbyte* pszVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamAPI_RegisterCallback([NativeTypeName("class CCallbackBase *")] CCallbackBase* pCallback, int iCallback);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamAPI_UnregisterCallback([NativeTypeName("class CCallbackBase *")] CCallbackBase* pCallback);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamAPI_RegisterCallResult([NativeTypeName("class CCallbackBase *")] CCallbackBase* pCallback, SteamAPICall_t hAPICall);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamAPI_UnregisterCallResult([NativeTypeName("class CCallbackBase *")] CCallbackBase* pCallback, SteamAPICall_t hAPICall);

    public const int k_iSteamUserCallbacks = 100;

    public const int k_iSteamGameServerCallbacks = 200;

    public const int k_iSteamFriendsCallbacks = 300;

    public const int k_iSteamBillingCallbacks = 400;

    public const int k_iSteamMatchmakingCallbacks = 500;

    public const int k_iSteamContentServerCallbacks = 600;

    public const int k_iSteamUtilsCallbacks = 700;

    public const int k_iSteamAppsCallbacks = 1000;

    public const int k_iSteamUserStatsCallbacks = 1100;

    public const int k_iSteamNetworkingCallbacks = 1200;

    public const int k_iSteamNetworkingSocketsCallbacks = 1220;

    public const int k_iSteamNetworkingMessagesCallbacks = 1250;

    public const int k_iSteamNetworkingUtilsCallbacks = 1280;

    public const int k_iSteamRemoteStorageCallbacks = 1300;

    public const int k_iSteamGameServerItemsCallbacks = 1500;

    public const int k_iSteamGameCoordinatorCallbacks = 1700;

    public const int k_iSteamGameServerStatsCallbacks = 1800;

    public const int k_iSteam2AsyncCallbacks = 1900;

    public const int k_iSteamGameStatsCallbacks = 2000;

    public const int k_iSteamHTTPCallbacks = 2100;

    public const int k_iSteamScreenshotsCallbacks = 2300;

    public const int k_iSteamStreamLauncherCallbacks = 2600;

    public const int k_iSteamControllerCallbacks = 2800;

    public const int k_iSteamUGCCallbacks = 3400;

    public const int k_iSteamStreamClientCallbacks = 3500;

    public const int k_iSteamMusicCallbacks = 4000;

    public const int k_iSteamMusicRemoteCallbacks = 4100;

    public const int k_iSteamGameNotificationCallbacks = 4400;

    public const int k_iSteamHTMLSurfaceCallbacks = 4500;

    public const int k_iSteamVideoCallbacks = 4600;

    public const int k_iSteamInventoryCallbacks = 4700;

    public const int k_ISteamParentalSettingsCallbacks = 5000;

    public const int k_iSteamGameSearchCallbacks = 5200;

    public const int k_iSteamPartiesCallbacks = 5300;

    public const int k_iSteamSTARCallbacks = 5500;

    public const int k_iSteamRemotePlayCallbacks = 5700;

    public const int k_iSteamChatCallbacks = 5900;
}
