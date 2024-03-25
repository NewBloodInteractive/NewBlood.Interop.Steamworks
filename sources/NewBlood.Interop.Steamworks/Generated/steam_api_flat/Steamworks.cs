using System;
using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.ISteamHTMLSurface;

namespace NewBlood.Interop.Steamworks;

public static unsafe partial class Steamworks
{
    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateSteamPipe")]
    public static extern HSteamPipe SteamAPI_ISteamClient_CreateSteamPipe(ISteamClient* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BReleaseSteamPipe")]
    public static extern byte SteamAPI_ISteamClient_BReleaseSteamPipe(ISteamClient* self, HSteamPipe hSteamPipe);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ConnectToGlobalUser")]
    public static extern HSteamUser SteamAPI_ISteamClient_ConnectToGlobalUser(ISteamClient* self, HSteamPipe hSteamPipe);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateLocalUser")]
    public static extern HSteamUser SteamAPI_ISteamClient_CreateLocalUser(ISteamClient* self, HSteamPipe* phSteamPipe, EAccountType eAccountType);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ReleaseUser")]
    public static extern void SteamAPI_ISteamClient_ReleaseUser(ISteamClient* self, HSteamPipe hSteamPipe, HSteamUser hUser);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamUser")]
    public static extern ISteamUser* SteamAPI_ISteamClient_GetISteamUser(ISteamClient* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamGameServer")]
    public static extern ISteamGameServer* SteamAPI_ISteamClient_GetISteamGameServer(ISteamClient* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetLocalIPBinding")]
    public static extern void SteamAPI_ISteamClient_SetLocalIPBinding(ISteamClient* self, [NativeTypeName("const SteamIPAddress_t &")] SteamIPAddress_t* unIP, [NativeTypeName("uint16")] ushort usPort);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamFriends")]
    public static extern ISteamFriends* SteamAPI_ISteamClient_GetISteamFriends(ISteamClient* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamUtils")]
    public static extern ISteamUtils* SteamAPI_ISteamClient_GetISteamUtils(ISteamClient* self, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamMatchmaking")]
    public static extern ISteamMatchmaking* SteamAPI_ISteamClient_GetISteamMatchmaking(ISteamClient* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamMatchmakingServers")]
    public static extern ISteamMatchmakingServers* SteamAPI_ISteamClient_GetISteamMatchmakingServers(ISteamClient* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamGenericInterface")]
    public static extern void* SteamAPI_ISteamClient_GetISteamGenericInterface(ISteamClient* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamUserStats")]
    public static extern ISteamUserStats* SteamAPI_ISteamClient_GetISteamUserStats(ISteamClient* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamGameServerStats")]
    public static extern ISteamGameServerStats* SteamAPI_ISteamClient_GetISteamGameServerStats(ISteamClient* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamApps")]
    public static extern ISteamApps* SteamAPI_ISteamClient_GetISteamApps(ISteamClient* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamNetworking")]
    public static extern ISteamNetworking* SteamAPI_ISteamClient_GetISteamNetworking(ISteamClient* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamRemoteStorage")]
    public static extern ISteamRemoteStorage* SteamAPI_ISteamClient_GetISteamRemoteStorage(ISteamClient* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamScreenshots")]
    public static extern ISteamScreenshots* SteamAPI_ISteamClient_GetISteamScreenshots(ISteamClient* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamGameSearch")]
    public static extern ISteamGameSearch* SteamAPI_ISteamClient_GetISteamGameSearch(ISteamClient* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetIPCCallCount")]
    public static extern uint SteamAPI_ISteamClient_GetIPCCallCount(ISteamClient* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetWarningMessageHook")]
    public static extern void SteamAPI_ISteamClient_SetWarningMessageHook(ISteamClient* self, [NativeTypeName("SteamAPIWarningMessageHook_t")] delegate* unmanaged[Cdecl]<int, sbyte*, void> pFunction);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BShutdownIfAllPipesClosed")]
    public static extern byte SteamAPI_ISteamClient_BShutdownIfAllPipesClosed(ISteamClient* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamHTTP")]
    public static extern ISteamHTTP* SteamAPI_ISteamClient_GetISteamHTTP(ISteamClient* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamController")]
    public static extern ISteamController* SteamAPI_ISteamClient_GetISteamController(ISteamClient* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamUGC")]
    public static extern ISteamUGC* SteamAPI_ISteamClient_GetISteamUGC(ISteamClient* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamMusic")]
    public static extern ISteamMusic* SteamAPI_ISteamClient_GetISteamMusic(ISteamClient* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamMusicRemote")]
    public static extern ISteamMusicRemote* SteamAPI_ISteamClient_GetISteamMusicRemote(ISteamClient* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamHTMLSurface")]
    public static extern ISteamHTMLSurface* SteamAPI_ISteamClient_GetISteamHTMLSurface(ISteamClient* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamInventory")]
    public static extern ISteamInventory* SteamAPI_ISteamClient_GetISteamInventory(ISteamClient* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamParentalSettings")]
    public static extern ISteamParentalSettings* SteamAPI_ISteamClient_GetISteamParentalSettings(ISteamClient* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamInput")]
    public static extern ISteamInput* SteamAPI_ISteamClient_GetISteamInput(ISteamClient* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamParties")]
    public static extern ISteamParties* SteamAPI_ISteamClient_GetISteamParties(ISteamClient* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetISteamRemotePlay")]
    public static extern ISteamRemotePlay* SteamAPI_ISteamClient_GetISteamRemotePlay(ISteamClient* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, [NativeTypeName("const char *")] sbyte* pchVersion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamUser* SteamAPI_SteamUser_v023();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetHSteamUser")]
    public static extern HSteamUser SteamAPI_ISteamUser_GetHSteamUser(ISteamUser* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BLoggedOn")]
    public static extern byte SteamAPI_ISteamUser_BLoggedOn(ISteamUser* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_steamid")]
    [GenerateMemberFunction("GetSteamID")]
    public static extern CSteamID SteamAPI_ISteamUser_GetSteamID(ISteamUser* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_InitiateGameConnection_DEPRECATED", ExactSpelling = true)]
    [GenerateMemberFunction("InitiateGameConnection")]
    [Obsolete]
    public static extern int SteamAPI_ISteamUser_InitiateGameConnection(ISteamUser* self, void* pAuthBlob, int cbMaxAuthBlob, [NativeTypeName("uint64_steamid")] CSteamID steamIDGameServer, [NativeTypeName("uint32")] uint unIPServer, [NativeTypeName("uint16")] ushort usPortServer, [NativeTypeName("bool")] byte bSecure);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_TerminateGameConnection_DEPRECATED", ExactSpelling = true)]
    [GenerateMemberFunction("TerminateGameConnection")]
    [Obsolete]
    public static extern void SteamAPI_ISteamUser_TerminateGameConnection(ISteamUser* self, [NativeTypeName("uint32")] uint unIPServer, [NativeTypeName("uint16")] ushort usPortServer);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("TrackAppUsageEvent")]
    public static extern void SteamAPI_ISteamUser_TrackAppUsageEvent(ISteamUser* self, [NativeTypeName("uint64_gameid")] CGameID gameID, int eAppUsageEvent, [NativeTypeName("const char *")] sbyte* pchExtraInfo);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetUserDataFolder")]
    public static extern byte SteamAPI_ISteamUser_GetUserDataFolder(ISteamUser* self, [NativeTypeName("char *")] sbyte* pchBuffer, int cubBuffer);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("StartVoiceRecording")]
    public static extern void SteamAPI_ISteamUser_StartVoiceRecording(ISteamUser* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("StopVoiceRecording")]
    public static extern void SteamAPI_ISteamUser_StopVoiceRecording(ISteamUser* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetAvailableVoice")]
    public static extern EVoiceResult SteamAPI_ISteamUser_GetAvailableVoice(ISteamUser* self, [NativeTypeName("uint32 *")] uint* pcbCompressed, [NativeTypeName("uint32 *")] uint* pcbUncompressed_Deprecated, [NativeTypeName("uint32")] uint nUncompressedVoiceDesiredSampleRate_Deprecated);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetVoice")]
    public static extern EVoiceResult SteamAPI_ISteamUser_GetVoice(ISteamUser* self, [NativeTypeName("bool")] byte bWantCompressed, void* pDestBuffer, [NativeTypeName("uint32")] uint cbDestBufferSize, [NativeTypeName("uint32 *")] uint* nBytesWritten, [NativeTypeName("bool")] byte bWantUncompressed_Deprecated, void* pUncompressedDestBuffer_Deprecated, [NativeTypeName("uint32")] uint cbUncompressedDestBufferSize_Deprecated, [NativeTypeName("uint32 *")] uint* nUncompressBytesWritten_Deprecated, [NativeTypeName("uint32")] uint nUncompressedVoiceDesiredSampleRate_Deprecated);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("DecompressVoice")]
    public static extern EVoiceResult SteamAPI_ISteamUser_DecompressVoice(ISteamUser* self, [NativeTypeName("const void *")] void* pCompressed, [NativeTypeName("uint32")] uint cbCompressed, void* pDestBuffer, [NativeTypeName("uint32")] uint cbDestBufferSize, [NativeTypeName("uint32 *")] uint* nBytesWritten, [NativeTypeName("uint32")] uint nDesiredSampleRate);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetVoiceOptimalSampleRate")]
    public static extern uint SteamAPI_ISteamUser_GetVoiceOptimalSampleRate(ISteamUser* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetAuthSessionTicket")]
    public static extern HAuthTicket SteamAPI_ISteamUser_GetAuthSessionTicket(ISteamUser* self, void* pTicket, int cbMaxTicket, [NativeTypeName("uint32 *")] uint* pcbTicket, [NativeTypeName("const SteamNetworkingIdentity *")] SteamNetworkingIdentity* pSteamNetworkingIdentity);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetAuthTicketForWebApi")]
    public static extern HAuthTicket SteamAPI_ISteamUser_GetAuthTicketForWebApi(ISteamUser* self, [NativeTypeName("const char *")] sbyte* pchIdentity);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("BeginAuthSession")]
    public static extern EBeginAuthSessionResult SteamAPI_ISteamUser_BeginAuthSession(ISteamUser* self, [NativeTypeName("const void *")] void* pAuthTicket, int cbAuthTicket, [NativeTypeName("uint64_steamid")] CSteamID steamID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("EndAuthSession")]
    public static extern void SteamAPI_ISteamUser_EndAuthSession(ISteamUser* self, [NativeTypeName("uint64_steamid")] CSteamID steamID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CancelAuthTicket")]
    public static extern void SteamAPI_ISteamUser_CancelAuthTicket(ISteamUser* self, HAuthTicket hAuthTicket);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("UserHasLicenseForApp")]
    public static extern EUserHasLicenseForAppResult SteamAPI_ISteamUser_UserHasLicenseForApp(ISteamUser* self, [NativeTypeName("uint64_steamid")] CSteamID steamID, AppId_t appID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsBehindNAT")]
    public static extern byte SteamAPI_ISteamUser_BIsBehindNAT(ISteamUser* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AdvertiseGame")]
    public static extern void SteamAPI_ISteamUser_AdvertiseGame(ISteamUser* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDGameServer, [NativeTypeName("uint32")] uint unIPServer, [NativeTypeName("uint16")] ushort usPortServer);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestEncryptedAppTicket")]
    public static extern SteamAPICall_t SteamAPI_ISteamUser_RequestEncryptedAppTicket(ISteamUser* self, void* pDataToInclude, int cbDataToInclude);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetEncryptedAppTicket")]
    public static extern byte SteamAPI_ISteamUser_GetEncryptedAppTicket(ISteamUser* self, void* pTicket, int cbMaxTicket, [NativeTypeName("uint32 *")] uint* pcbTicket);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetGameBadgeLevel")]
    public static extern int SteamAPI_ISteamUser_GetGameBadgeLevel(ISteamUser* self, int nSeries, [NativeTypeName("bool")] byte bFoil);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetPlayerSteamLevel")]
    public static extern int SteamAPI_ISteamUser_GetPlayerSteamLevel(ISteamUser* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestStoreAuthURL")]
    public static extern SteamAPICall_t SteamAPI_ISteamUser_RequestStoreAuthURL(ISteamUser* self, [NativeTypeName("const char *")] sbyte* pchRedirectURL);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsPhoneVerified")]
    public static extern byte SteamAPI_ISteamUser_BIsPhoneVerified(ISteamUser* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsTwoFactorEnabled")]
    public static extern byte SteamAPI_ISteamUser_BIsTwoFactorEnabled(ISteamUser* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsPhoneIdentifying")]
    public static extern byte SteamAPI_ISteamUser_BIsPhoneIdentifying(ISteamUser* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsPhoneRequiringVerification")]
    public static extern byte SteamAPI_ISteamUser_BIsPhoneRequiringVerification(ISteamUser* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetMarketEligibility")]
    public static extern SteamAPICall_t SteamAPI_ISteamUser_GetMarketEligibility(ISteamUser* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetDurationControl")]
    public static extern SteamAPICall_t SteamAPI_ISteamUser_GetDurationControl(ISteamUser* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BSetDurationControlOnlineState")]
    public static extern byte SteamAPI_ISteamUser_BSetDurationControlOnlineState(ISteamUser* self, EDurationControlOnlineState eNewState);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamFriends* SteamAPI_SteamFriends_v017();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetPersonaName")]
    public static extern sbyte* SteamAPI_ISteamFriends_GetPersonaName(ISteamFriends* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetPersonaName")]
    public static extern SteamAPICall_t SteamAPI_ISteamFriends_SetPersonaName(ISteamFriends* self, [NativeTypeName("const char *")] sbyte* pchPersonaName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetPersonaState")]
    public static extern EPersonaState SteamAPI_ISteamFriends_GetPersonaState(ISteamFriends* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFriendCount")]
    public static extern int SteamAPI_ISteamFriends_GetFriendCount(ISteamFriends* self, int iFriendFlags);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_steamid")]
    [GenerateMemberFunction("GetFriendByIndex")]
    public static extern CSteamID SteamAPI_ISteamFriends_GetFriendByIndex(ISteamFriends* self, int iFriend, int iFriendFlags);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFriendRelationship")]
    public static extern EFriendRelationship SteamAPI_ISteamFriends_GetFriendRelationship(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFriendPersonaState")]
    public static extern EPersonaState SteamAPI_ISteamFriends_GetFriendPersonaState(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetFriendPersonaName")]
    public static extern sbyte* SteamAPI_ISteamFriends_GetFriendPersonaName(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetFriendGamePlayed")]
    public static extern byte SteamAPI_ISteamFriends_GetFriendGamePlayed(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend, FriendGameInfo_t* pFriendGameInfo);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetFriendPersonaNameHistory")]
    public static extern sbyte* SteamAPI_ISteamFriends_GetFriendPersonaNameHistory(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend, int iPersonaName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFriendSteamLevel")]
    public static extern int SteamAPI_ISteamFriends_GetFriendSteamLevel(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetPlayerNickname")]
    public static extern sbyte* SteamAPI_ISteamFriends_GetPlayerNickname(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDPlayer);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFriendsGroupCount")]
    public static extern int SteamAPI_ISteamFriends_GetFriendsGroupCount(ISteamFriends* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFriendsGroupIDByIndex")]
    public static extern FriendsGroupID_t SteamAPI_ISteamFriends_GetFriendsGroupIDByIndex(ISteamFriends* self, int iFG);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetFriendsGroupName")]
    public static extern sbyte* SteamAPI_ISteamFriends_GetFriendsGroupName(ISteamFriends* self, FriendsGroupID_t friendsGroupID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFriendsGroupMembersCount")]
    public static extern int SteamAPI_ISteamFriends_GetFriendsGroupMembersCount(ISteamFriends* self, FriendsGroupID_t friendsGroupID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFriendsGroupMembersList")]
    public static extern void SteamAPI_ISteamFriends_GetFriendsGroupMembersList(ISteamFriends* self, FriendsGroupID_t friendsGroupID, CSteamID* pOutSteamIDMembers, int nMembersCount);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("HasFriend")]
    public static extern byte SteamAPI_ISteamFriends_HasFriend(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend, int iFriendFlags);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetClanCount")]
    public static extern int SteamAPI_ISteamFriends_GetClanCount(ISteamFriends* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_steamid")]
    [GenerateMemberFunction("GetClanByIndex")]
    public static extern CSteamID SteamAPI_ISteamFriends_GetClanByIndex(ISteamFriends* self, int iClan);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetClanName")]
    public static extern sbyte* SteamAPI_ISteamFriends_GetClanName(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClan);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetClanTag")]
    public static extern sbyte* SteamAPI_ISteamFriends_GetClanTag(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClan);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetClanActivityCounts")]
    public static extern byte SteamAPI_ISteamFriends_GetClanActivityCounts(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClan, int* pnOnline, int* pnInGame, int* pnChatting);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("DownloadClanActivityCounts")]
    public static extern SteamAPICall_t SteamAPI_ISteamFriends_DownloadClanActivityCounts(ISteamFriends* self, CSteamID* psteamIDClans, int cClansToRequest);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFriendCountFromSource")]
    public static extern int SteamAPI_ISteamFriends_GetFriendCountFromSource(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDSource);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_steamid")]
    [GenerateMemberFunction("GetFriendFromSourceByIndex")]
    public static extern CSteamID SteamAPI_ISteamFriends_GetFriendFromSourceByIndex(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDSource, int iFriend);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsUserInSource")]
    public static extern byte SteamAPI_ISteamFriends_IsUserInSource(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser, [NativeTypeName("uint64_steamid")] CSteamID steamIDSource);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetInGameVoiceSpeaking")]
    public static extern void SteamAPI_ISteamFriends_SetInGameVoiceSpeaking(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser, [NativeTypeName("bool")] byte bSpeaking);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ActivateGameOverlay")]
    public static extern void SteamAPI_ISteamFriends_ActivateGameOverlay(ISteamFriends* self, [NativeTypeName("const char *")] sbyte* pchDialog);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ActivateGameOverlayToUser")]
    public static extern void SteamAPI_ISteamFriends_ActivateGameOverlayToUser(ISteamFriends* self, [NativeTypeName("const char *")] sbyte* pchDialog, [NativeTypeName("uint64_steamid")] CSteamID steamID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ActivateGameOverlayToWebPage")]
    public static extern void SteamAPI_ISteamFriends_ActivateGameOverlayToWebPage(ISteamFriends* self, [NativeTypeName("const char *")] sbyte* pchURL, EActivateGameOverlayToWebPageMode eMode);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ActivateGameOverlayToStore")]
    public static extern void SteamAPI_ISteamFriends_ActivateGameOverlayToStore(ISteamFriends* self, AppId_t nAppID, EOverlayToStoreFlag eFlag);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetPlayedWith")]
    public static extern void SteamAPI_ISteamFriends_SetPlayedWith(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUserPlayedWith);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ActivateGameOverlayInviteDialog")]
    public static extern void SteamAPI_ISteamFriends_ActivateGameOverlayInviteDialog(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetSmallFriendAvatar")]
    public static extern int SteamAPI_ISteamFriends_GetSmallFriendAvatar(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetMediumFriendAvatar")]
    public static extern int SteamAPI_ISteamFriends_GetMediumFriendAvatar(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetLargeFriendAvatar")]
    public static extern int SteamAPI_ISteamFriends_GetLargeFriendAvatar(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("RequestUserInformation")]
    public static extern byte SteamAPI_ISteamFriends_RequestUserInformation(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser, [NativeTypeName("bool")] byte bRequireNameOnly);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestClanOfficerList")]
    public static extern SteamAPICall_t SteamAPI_ISteamFriends_RequestClanOfficerList(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClan);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_steamid")]
    [GenerateMemberFunction("GetClanOwner")]
    public static extern CSteamID SteamAPI_ISteamFriends_GetClanOwner(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClan);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetClanOfficerCount")]
    public static extern int SteamAPI_ISteamFriends_GetClanOfficerCount(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClan);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_steamid")]
    [GenerateMemberFunction("GetClanOfficerByIndex")]
    public static extern CSteamID SteamAPI_ISteamFriends_GetClanOfficerByIndex(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClan, int iOfficer);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetUserRestrictions")]
    public static extern uint SteamAPI_ISteamFriends_GetUserRestrictions(ISteamFriends* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetRichPresence")]
    public static extern byte SteamAPI_ISteamFriends_SetRichPresence(ISteamFriends* self, [NativeTypeName("const char *")] sbyte* pchKey, [NativeTypeName("const char *")] sbyte* pchValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ClearRichPresence")]
    public static extern void SteamAPI_ISteamFriends_ClearRichPresence(ISteamFriends* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetFriendRichPresence")]
    public static extern sbyte* SteamAPI_ISteamFriends_GetFriendRichPresence(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend, [NativeTypeName("const char *")] sbyte* pchKey);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFriendRichPresenceKeyCount")]
    public static extern int SteamAPI_ISteamFriends_GetFriendRichPresenceKeyCount(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetFriendRichPresenceKeyByIndex")]
    public static extern sbyte* SteamAPI_ISteamFriends_GetFriendRichPresenceKeyByIndex(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend, int iKey);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestFriendRichPresence")]
    public static extern void SteamAPI_ISteamFriends_RequestFriendRichPresence(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("InviteUserToGame")]
    public static extern byte SteamAPI_ISteamFriends_InviteUserToGame(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend, [NativeTypeName("const char *")] sbyte* pchConnectString);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetCoplayFriendCount")]
    public static extern int SteamAPI_ISteamFriends_GetCoplayFriendCount(ISteamFriends* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_steamid")]
    [GenerateMemberFunction("GetCoplayFriend")]
    public static extern CSteamID SteamAPI_ISteamFriends_GetCoplayFriend(ISteamFriends* self, int iCoplayFriend);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFriendCoplayTime")]
    public static extern int SteamAPI_ISteamFriends_GetFriendCoplayTime(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFriendCoplayGame")]
    public static extern AppId_t SteamAPI_ISteamFriends_GetFriendCoplayGame(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("JoinClanChatRoom")]
    public static extern SteamAPICall_t SteamAPI_ISteamFriends_JoinClanChatRoom(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClan);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("LeaveClanChatRoom")]
    public static extern byte SteamAPI_ISteamFriends_LeaveClanChatRoom(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClan);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetClanChatMemberCount")]
    public static extern int SteamAPI_ISteamFriends_GetClanChatMemberCount(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClan);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_steamid")]
    [GenerateMemberFunction("GetChatMemberByIndex")]
    public static extern CSteamID SteamAPI_ISteamFriends_GetChatMemberByIndex(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClan, int iUser);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SendClanChatMessage")]
    public static extern byte SteamAPI_ISteamFriends_SendClanChatMessage(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClanChat, [NativeTypeName("const char *")] sbyte* pchText);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetClanChatMessage")]
    public static extern int SteamAPI_ISteamFriends_GetClanChatMessage(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClanChat, int iMessage, void* prgchText, int cchTextMax, EChatEntryType* peChatEntryType, CSteamID* psteamidChatter);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsClanChatAdmin")]
    public static extern byte SteamAPI_ISteamFriends_IsClanChatAdmin(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClanChat, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsClanChatWindowOpenInSteam")]
    public static extern byte SteamAPI_ISteamFriends_IsClanChatWindowOpenInSteam(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClanChat);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("OpenClanChatWindowInSteam")]
    public static extern byte SteamAPI_ISteamFriends_OpenClanChatWindowInSteam(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClanChat);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("CloseClanChatWindowInSteam")]
    public static extern byte SteamAPI_ISteamFriends_CloseClanChatWindowInSteam(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClanChat);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetListenForFriendsMessages")]
    public static extern byte SteamAPI_ISteamFriends_SetListenForFriendsMessages(ISteamFriends* self, [NativeTypeName("bool")] byte bInterceptEnabled);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ReplyToFriendMessage")]
    public static extern byte SteamAPI_ISteamFriends_ReplyToFriendMessage(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend, [NativeTypeName("const char *")] sbyte* pchMsgToSend);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFriendMessage")]
    public static extern int SteamAPI_ISteamFriends_GetFriendMessage(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend, int iMessageID, void* pvData, int cubData, EChatEntryType* peChatEntryType);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFollowerCount")]
    public static extern SteamAPICall_t SteamAPI_ISteamFriends_GetFollowerCount(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("IsFollowing")]
    public static extern SteamAPICall_t SteamAPI_ISteamFriends_IsFollowing(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("EnumerateFollowingList")]
    public static extern SteamAPICall_t SteamAPI_ISteamFriends_EnumerateFollowingList(ISteamFriends* self, [NativeTypeName("uint32")] uint unStartIndex);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsClanPublic")]
    public static extern byte SteamAPI_ISteamFriends_IsClanPublic(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClan);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsClanOfficialGameGroup")]
    public static extern byte SteamAPI_ISteamFriends_IsClanOfficialGameGroup(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClan);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetNumChatsWithUnreadPriorityMessages")]
    public static extern int SteamAPI_ISteamFriends_GetNumChatsWithUnreadPriorityMessages(ISteamFriends* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ActivateGameOverlayRemotePlayTogetherInviteDialog")]
    public static extern void SteamAPI_ISteamFriends_ActivateGameOverlayRemotePlayTogetherInviteDialog(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("RegisterProtocolInOverlayBrowser")]
    public static extern byte SteamAPI_ISteamFriends_RegisterProtocolInOverlayBrowser(ISteamFriends* self, [NativeTypeName("const char *")] sbyte* pchProtocol);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ActivateGameOverlayInviteDialogConnectString")]
    public static extern void SteamAPI_ISteamFriends_ActivateGameOverlayInviteDialogConnectString(ISteamFriends* self, [NativeTypeName("const char *")] sbyte* pchConnectString);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestEquippedProfileItems")]
    public static extern SteamAPICall_t SteamAPI_ISteamFriends_RequestEquippedProfileItems(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BHasEquippedProfileItem")]
    public static extern byte SteamAPI_ISteamFriends_BHasEquippedProfileItem(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamID, ECommunityProfileItemType itemType);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetProfileItemPropertyString")]
    public static extern sbyte* SteamAPI_ISteamFriends_GetProfileItemPropertyString(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamID, ECommunityProfileItemType itemType, ECommunityProfileItemProperty prop);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetProfileItemPropertyUint")]
    public static extern uint SteamAPI_ISteamFriends_GetProfileItemPropertyUint(ISteamFriends* self, [NativeTypeName("uint64_steamid")] CSteamID steamID, ECommunityProfileItemType itemType, ECommunityProfileItemProperty prop);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamUtils* SteamAPI_SteamUtils_v010();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamUtils* SteamAPI_SteamGameServerUtils_v010();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetSecondsSinceAppActive")]
    public static extern uint SteamAPI_ISteamUtils_GetSecondsSinceAppActive(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetSecondsSinceComputerActive")]
    public static extern uint SteamAPI_ISteamUtils_GetSecondsSinceComputerActive(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetConnectedUniverse")]
    public static extern EUniverse SteamAPI_ISteamUtils_GetConnectedUniverse(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetServerRealTime")]
    public static extern uint SteamAPI_ISteamUtils_GetServerRealTime(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetIPCountry")]
    public static extern sbyte* SteamAPI_ISteamUtils_GetIPCountry(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetImageSize")]
    public static extern byte SteamAPI_ISteamUtils_GetImageSize(ISteamUtils* self, int iImage, [NativeTypeName("uint32 *")] uint* pnWidth, [NativeTypeName("uint32 *")] uint* pnHeight);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetImageRGBA")]
    public static extern byte SteamAPI_ISteamUtils_GetImageRGBA(ISteamUtils* self, int iImage, [NativeTypeName("uint8 *")] byte* pubDest, int nDestBufferSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint8")]
    [GenerateMemberFunction("GetCurrentBatteryPower")]
    public static extern byte SteamAPI_ISteamUtils_GetCurrentBatteryPower(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetAppID")]
    public static extern uint SteamAPI_ISteamUtils_GetAppID(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetOverlayNotificationPosition")]
    public static extern void SteamAPI_ISteamUtils_SetOverlayNotificationPosition(ISteamUtils* self, ENotificationPosition eNotificationPosition);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsAPICallCompleted")]
    public static extern byte SteamAPI_ISteamUtils_IsAPICallCompleted(ISteamUtils* self, SteamAPICall_t hSteamAPICall, bool* pbFailed);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetAPICallFailureReason")]
    public static extern ESteamAPICallFailure SteamAPI_ISteamUtils_GetAPICallFailureReason(ISteamUtils* self, SteamAPICall_t hSteamAPICall);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetAPICallResult")]
    public static extern byte SteamAPI_ISteamUtils_GetAPICallResult(ISteamUtils* self, SteamAPICall_t hSteamAPICall, void* pCallback, int cubCallback, int iCallbackExpected, bool* pbFailed);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetIPCCallCount")]
    public static extern uint SteamAPI_ISteamUtils_GetIPCCallCount(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetWarningMessageHook")]
    public static extern void SteamAPI_ISteamUtils_SetWarningMessageHook(ISteamUtils* self, [NativeTypeName("SteamAPIWarningMessageHook_t")] delegate* unmanaged[Cdecl]<int, sbyte*, void> pFunction);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsOverlayEnabled")]
    public static extern byte SteamAPI_ISteamUtils_IsOverlayEnabled(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BOverlayNeedsPresent")]
    public static extern byte SteamAPI_ISteamUtils_BOverlayNeedsPresent(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CheckFileSignature")]
    public static extern SteamAPICall_t SteamAPI_ISteamUtils_CheckFileSignature(ISteamUtils* self, [NativeTypeName("const char *")] sbyte* szFileName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ShowGamepadTextInput")]
    public static extern byte SteamAPI_ISteamUtils_ShowGamepadTextInput(ISteamUtils* self, EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, [NativeTypeName("const char *")] sbyte* pchDescription, [NativeTypeName("uint32")] uint unCharMax, [NativeTypeName("const char *")] sbyte* pchExistingText);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetEnteredGamepadTextLength")]
    public static extern uint SteamAPI_ISteamUtils_GetEnteredGamepadTextLength(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetEnteredGamepadTextInput")]
    public static extern byte SteamAPI_ISteamUtils_GetEnteredGamepadTextInput(ISteamUtils* self, [NativeTypeName("char *")] sbyte* pchText, [NativeTypeName("uint32")] uint cchText);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetSteamUILanguage")]
    public static extern sbyte* SteamAPI_ISteamUtils_GetSteamUILanguage(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsSteamRunningInVR")]
    public static extern byte SteamAPI_ISteamUtils_IsSteamRunningInVR(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetOverlayNotificationInset")]
    public static extern void SteamAPI_ISteamUtils_SetOverlayNotificationInset(ISteamUtils* self, int nHorizontalInset, int nVerticalInset);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsSteamInBigPictureMode")]
    public static extern byte SteamAPI_ISteamUtils_IsSteamInBigPictureMode(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("StartVRDashboard")]
    public static extern void SteamAPI_ISteamUtils_StartVRDashboard(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsVRHeadsetStreamingEnabled")]
    public static extern byte SteamAPI_ISteamUtils_IsVRHeadsetStreamingEnabled(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetVRHeadsetStreamingEnabled")]
    public static extern void SteamAPI_ISteamUtils_SetVRHeadsetStreamingEnabled(ISteamUtils* self, [NativeTypeName("bool")] byte bEnabled);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsSteamChinaLauncher")]
    public static extern byte SteamAPI_ISteamUtils_IsSteamChinaLauncher(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("InitFilterText")]
    public static extern byte SteamAPI_ISteamUtils_InitFilterText(ISteamUtils* self, [NativeTypeName("uint32")] uint unFilterOptions);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("FilterText")]
    public static extern int SteamAPI_ISteamUtils_FilterText(ISteamUtils* self, ETextFilteringContext eContext, [NativeTypeName("uint64_steamid")] CSteamID sourceSteamID, [NativeTypeName("const char *")] sbyte* pchInputMessage, [NativeTypeName("char *")] sbyte* pchOutFilteredText, [NativeTypeName("uint32")] uint nByteSizeOutFilteredText);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetIPv6ConnectivityState")]
    public static extern ESteamIPv6ConnectivityState SteamAPI_ISteamUtils_GetIPv6ConnectivityState(ISteamUtils* self, ESteamIPv6ConnectivityProtocol eProtocol);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsSteamRunningOnSteamDeck")]
    public static extern byte SteamAPI_ISteamUtils_IsSteamRunningOnSteamDeck(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ShowFloatingGamepadTextInput")]
    public static extern byte SteamAPI_ISteamUtils_ShowFloatingGamepadTextInput(ISteamUtils* self, EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetGameLauncherMode")]
    public static extern void SteamAPI_ISteamUtils_SetGameLauncherMode(ISteamUtils* self, [NativeTypeName("bool")] byte bLauncherMode);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("DismissFloatingGamepadTextInput")]
    public static extern byte SteamAPI_ISteamUtils_DismissFloatingGamepadTextInput(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("DismissGamepadTextInput")]
    public static extern byte SteamAPI_ISteamUtils_DismissGamepadTextInput(ISteamUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamMatchmaking* SteamAPI_SteamMatchmaking_v009();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFavoriteGameCount")]
    public static extern int SteamAPI_ISteamMatchmaking_GetFavoriteGameCount(ISteamMatchmaking* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetFavoriteGame")]
    public static extern byte SteamAPI_ISteamMatchmaking_GetFavoriteGame(ISteamMatchmaking* self, int iGame, AppId_t* pnAppID, [NativeTypeName("uint32 *")] uint* pnIP, [NativeTypeName("uint16 *")] ushort* pnConnPort, [NativeTypeName("uint16 *")] ushort* pnQueryPort, [NativeTypeName("uint32 *")] uint* punFlags, [NativeTypeName("uint32 *")] uint* pRTime32LastPlayedOnServer);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AddFavoriteGame")]
    public static extern int SteamAPI_ISteamMatchmaking_AddFavoriteGame(ISteamMatchmaking* self, AppId_t nAppID, [NativeTypeName("uint32")] uint nIP, [NativeTypeName("uint16")] ushort nConnPort, [NativeTypeName("uint16")] ushort nQueryPort, [NativeTypeName("uint32")] uint unFlags, [NativeTypeName("uint32")] uint rTime32LastPlayedOnServer);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("RemoveFavoriteGame")]
    public static extern byte SteamAPI_ISteamMatchmaking_RemoveFavoriteGame(ISteamMatchmaking* self, AppId_t nAppID, [NativeTypeName("uint32")] uint nIP, [NativeTypeName("uint16")] ushort nConnPort, [NativeTypeName("uint16")] ushort nQueryPort, [NativeTypeName("uint32")] uint unFlags);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestLobbyList")]
    public static extern SteamAPICall_t SteamAPI_ISteamMatchmaking_RequestLobbyList(ISteamMatchmaking* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AddRequestLobbyListStringFilter")]
    public static extern void SteamAPI_ISteamMatchmaking_AddRequestLobbyListStringFilter(ISteamMatchmaking* self, [NativeTypeName("const char *")] sbyte* pchKeyToMatch, [NativeTypeName("const char *")] sbyte* pchValueToMatch, ELobbyComparison eComparisonType);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AddRequestLobbyListNumericalFilter")]
    public static extern void SteamAPI_ISteamMatchmaking_AddRequestLobbyListNumericalFilter(ISteamMatchmaking* self, [NativeTypeName("const char *")] sbyte* pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AddRequestLobbyListNearValueFilter")]
    public static extern void SteamAPI_ISteamMatchmaking_AddRequestLobbyListNearValueFilter(ISteamMatchmaking* self, [NativeTypeName("const char *")] sbyte* pchKeyToMatch, int nValueToBeCloseTo);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AddRequestLobbyListFilterSlotsAvailable")]
    public static extern void SteamAPI_ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(ISteamMatchmaking* self, int nSlotsAvailable);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AddRequestLobbyListDistanceFilter")]
    public static extern void SteamAPI_ISteamMatchmaking_AddRequestLobbyListDistanceFilter(ISteamMatchmaking* self, ELobbyDistanceFilter eLobbyDistanceFilter);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AddRequestLobbyListResultCountFilter")]
    public static extern void SteamAPI_ISteamMatchmaking_AddRequestLobbyListResultCountFilter(ISteamMatchmaking* self, int cMaxResults);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AddRequestLobbyListCompatibleMembersFilter")]
    public static extern void SteamAPI_ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_steamid")]
    [GenerateMemberFunction("GetLobbyByIndex")]
    public static extern CSteamID SteamAPI_ISteamMatchmaking_GetLobbyByIndex(ISteamMatchmaking* self, int iLobby);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateLobby")]
    public static extern SteamAPICall_t SteamAPI_ISteamMatchmaking_CreateLobby(ISteamMatchmaking* self, ELobbyType eLobbyType, int cMaxMembers);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("JoinLobby")]
    public static extern SteamAPICall_t SteamAPI_ISteamMatchmaking_JoinLobby(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("LeaveLobby")]
    public static extern void SteamAPI_ISteamMatchmaking_LeaveLobby(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("InviteUserToLobby")]
    public static extern byte SteamAPI_ISteamMatchmaking_InviteUserToLobby(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby, [NativeTypeName("uint64_steamid")] CSteamID steamIDInvitee);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetNumLobbyMembers")]
    public static extern int SteamAPI_ISteamMatchmaking_GetNumLobbyMembers(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_steamid")]
    [GenerateMemberFunction("GetLobbyMemberByIndex")]
    public static extern CSteamID SteamAPI_ISteamMatchmaking_GetLobbyMemberByIndex(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby, int iMember);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetLobbyData")]
    public static extern sbyte* SteamAPI_ISteamMatchmaking_GetLobbyData(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby, [NativeTypeName("const char *")] sbyte* pchKey);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetLobbyData")]
    public static extern byte SteamAPI_ISteamMatchmaking_SetLobbyData(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby, [NativeTypeName("const char *")] sbyte* pchKey, [NativeTypeName("const char *")] sbyte* pchValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetLobbyDataCount")]
    public static extern int SteamAPI_ISteamMatchmaking_GetLobbyDataCount(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetLobbyDataByIndex")]
    public static extern byte SteamAPI_ISteamMatchmaking_GetLobbyDataByIndex(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby, int iLobbyData, [NativeTypeName("char *")] sbyte* pchKey, int cchKeyBufferSize, [NativeTypeName("char *")] sbyte* pchValue, int cchValueBufferSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("DeleteLobbyData")]
    public static extern byte SteamAPI_ISteamMatchmaking_DeleteLobbyData(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby, [NativeTypeName("const char *")] sbyte* pchKey);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetLobbyMemberData")]
    public static extern sbyte* SteamAPI_ISteamMatchmaking_GetLobbyMemberData(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser, [NativeTypeName("const char *")] sbyte* pchKey);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetLobbyMemberData")]
    public static extern void SteamAPI_ISteamMatchmaking_SetLobbyMemberData(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby, [NativeTypeName("const char *")] sbyte* pchKey, [NativeTypeName("const char *")] sbyte* pchValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SendLobbyChatMsg")]
    public static extern byte SteamAPI_ISteamMatchmaking_SendLobbyChatMsg(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby, [NativeTypeName("const void *")] void* pvMsgBody, int cubMsgBody);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetLobbyChatEntry")]
    public static extern int SteamAPI_ISteamMatchmaking_GetLobbyChatEntry(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby, int iChatID, CSteamID* pSteamIDUser, void* pvData, int cubData, EChatEntryType* peChatEntryType);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("RequestLobbyData")]
    public static extern byte SteamAPI_ISteamMatchmaking_RequestLobbyData(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetLobbyGameServer")]
    public static extern void SteamAPI_ISteamMatchmaking_SetLobbyGameServer(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby, [NativeTypeName("uint32")] uint unGameServerIP, [NativeTypeName("uint16")] ushort unGameServerPort, [NativeTypeName("uint64_steamid")] CSteamID steamIDGameServer);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetLobbyGameServer")]
    public static extern byte SteamAPI_ISteamMatchmaking_GetLobbyGameServer(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby, [NativeTypeName("uint32 *")] uint* punGameServerIP, [NativeTypeName("uint16 *")] ushort* punGameServerPort, CSteamID* psteamIDGameServer);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetLobbyMemberLimit")]
    public static extern byte SteamAPI_ISteamMatchmaking_SetLobbyMemberLimit(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby, int cMaxMembers);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetLobbyMemberLimit")]
    public static extern int SteamAPI_ISteamMatchmaking_GetLobbyMemberLimit(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetLobbyType")]
    public static extern byte SteamAPI_ISteamMatchmaking_SetLobbyType(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby, ELobbyType eLobbyType);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetLobbyJoinable")]
    public static extern byte SteamAPI_ISteamMatchmaking_SetLobbyJoinable(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby, [NativeTypeName("bool")] byte bLobbyJoinable);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_steamid")]
    [GenerateMemberFunction("GetLobbyOwner")]
    public static extern CSteamID SteamAPI_ISteamMatchmaking_GetLobbyOwner(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetLobbyOwner")]
    public static extern byte SteamAPI_ISteamMatchmaking_SetLobbyOwner(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby, [NativeTypeName("uint64_steamid")] CSteamID steamIDNewOwner);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetLinkedLobby")]
    public static extern byte SteamAPI_ISteamMatchmaking_SetLinkedLobby(ISteamMatchmaking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobbyDependent);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ServerResponded")]
    public static extern void SteamAPI_ISteamMatchmakingServerListResponse_ServerResponded(ISteamMatchmakingServerListResponse* self, HServerListRequest hRequest, int iServer);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ServerFailedToRespond")]
    public static extern void SteamAPI_ISteamMatchmakingServerListResponse_ServerFailedToRespond(ISteamMatchmakingServerListResponse* self, HServerListRequest hRequest, int iServer);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RefreshComplete")]
    public static extern void SteamAPI_ISteamMatchmakingServerListResponse_RefreshComplete(ISteamMatchmakingServerListResponse* self, HServerListRequest hRequest, EMatchMakingServerResponse response);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ServerResponded")]
    public static extern void SteamAPI_ISteamMatchmakingPingResponse_ServerResponded(ISteamMatchmakingPingResponse* self, [NativeTypeName("gameserveritem_t &")] gameserveritem_t* server);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ServerFailedToRespond")]
    public static extern void SteamAPI_ISteamMatchmakingPingResponse_ServerFailedToRespond(ISteamMatchmakingPingResponse* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AddPlayerToList")]
    public static extern void SteamAPI_ISteamMatchmakingPlayersResponse_AddPlayerToList(ISteamMatchmakingPlayersResponse* self, [NativeTypeName("const char *")] sbyte* pchName, int nScore, float flTimePlayed);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("PlayersFailedToRespond")]
    public static extern void SteamAPI_ISteamMatchmakingPlayersResponse_PlayersFailedToRespond(ISteamMatchmakingPlayersResponse* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("PlayersRefreshComplete")]
    public static extern void SteamAPI_ISteamMatchmakingPlayersResponse_PlayersRefreshComplete(ISteamMatchmakingPlayersResponse* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RulesResponded")]
    public static extern void SteamAPI_ISteamMatchmakingRulesResponse_RulesResponded(ISteamMatchmakingRulesResponse* self, [NativeTypeName("const char *")] sbyte* pchRule, [NativeTypeName("const char *")] sbyte* pchValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RulesFailedToRespond")]
    public static extern void SteamAPI_ISteamMatchmakingRulesResponse_RulesFailedToRespond(ISteamMatchmakingRulesResponse* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RulesRefreshComplete")]
    public static extern void SteamAPI_ISteamMatchmakingRulesResponse_RulesRefreshComplete(ISteamMatchmakingRulesResponse* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamMatchmakingServers* SteamAPI_SteamMatchmakingServers_v002();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestInternetServerList")]
    public static extern HServerListRequest SteamAPI_ISteamMatchmakingServers_RequestInternetServerList(ISteamMatchmakingServers* self, AppId_t iApp, MatchMakingKeyValuePair_t** ppchFilters, [NativeTypeName("uint32")] uint nFilters, ISteamMatchmakingServerListResponse* pRequestServersResponse);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestLANServerList")]
    public static extern HServerListRequest SteamAPI_ISteamMatchmakingServers_RequestLANServerList(ISteamMatchmakingServers* self, AppId_t iApp, ISteamMatchmakingServerListResponse* pRequestServersResponse);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestFriendsServerList")]
    public static extern HServerListRequest SteamAPI_ISteamMatchmakingServers_RequestFriendsServerList(ISteamMatchmakingServers* self, AppId_t iApp, MatchMakingKeyValuePair_t** ppchFilters, [NativeTypeName("uint32")] uint nFilters, ISteamMatchmakingServerListResponse* pRequestServersResponse);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestFavoritesServerList")]
    public static extern HServerListRequest SteamAPI_ISteamMatchmakingServers_RequestFavoritesServerList(ISteamMatchmakingServers* self, AppId_t iApp, MatchMakingKeyValuePair_t** ppchFilters, [NativeTypeName("uint32")] uint nFilters, ISteamMatchmakingServerListResponse* pRequestServersResponse);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestHistoryServerList")]
    public static extern HServerListRequest SteamAPI_ISteamMatchmakingServers_RequestHistoryServerList(ISteamMatchmakingServers* self, AppId_t iApp, MatchMakingKeyValuePair_t** ppchFilters, [NativeTypeName("uint32")] uint nFilters, ISteamMatchmakingServerListResponse* pRequestServersResponse);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestSpectatorServerList")]
    public static extern HServerListRequest SteamAPI_ISteamMatchmakingServers_RequestSpectatorServerList(ISteamMatchmakingServers* self, AppId_t iApp, MatchMakingKeyValuePair_t** ppchFilters, [NativeTypeName("uint32")] uint nFilters, ISteamMatchmakingServerListResponse* pRequestServersResponse);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ReleaseRequest")]
    public static extern void SteamAPI_ISteamMatchmakingServers_ReleaseRequest(ISteamMatchmakingServers* self, HServerListRequest hServerListRequest);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetServerDetails")]
    public static extern gameserveritem_t* SteamAPI_ISteamMatchmakingServers_GetServerDetails(ISteamMatchmakingServers* self, HServerListRequest hRequest, int iServer);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CancelQuery")]
    public static extern void SteamAPI_ISteamMatchmakingServers_CancelQuery(ISteamMatchmakingServers* self, HServerListRequest hRequest);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RefreshQuery")]
    public static extern void SteamAPI_ISteamMatchmakingServers_RefreshQuery(ISteamMatchmakingServers* self, HServerListRequest hRequest);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsRefreshing")]
    public static extern byte SteamAPI_ISteamMatchmakingServers_IsRefreshing(ISteamMatchmakingServers* self, HServerListRequest hRequest);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetServerCount")]
    public static extern int SteamAPI_ISteamMatchmakingServers_GetServerCount(ISteamMatchmakingServers* self, HServerListRequest hRequest);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RefreshServer")]
    public static extern void SteamAPI_ISteamMatchmakingServers_RefreshServer(ISteamMatchmakingServers* self, HServerListRequest hRequest, int iServer);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("PingServer")]
    public static extern HServerQuery SteamAPI_ISteamMatchmakingServers_PingServer(ISteamMatchmakingServers* self, [NativeTypeName("uint32")] uint unIP, [NativeTypeName("uint16")] ushort usPort, ISteamMatchmakingPingResponse* pRequestServersResponse);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("PlayerDetails")]
    public static extern HServerQuery SteamAPI_ISteamMatchmakingServers_PlayerDetails(ISteamMatchmakingServers* self, [NativeTypeName("uint32")] uint unIP, [NativeTypeName("uint16")] ushort usPort, ISteamMatchmakingPlayersResponse* pRequestServersResponse);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ServerRules")]
    public static extern HServerQuery SteamAPI_ISteamMatchmakingServers_ServerRules(ISteamMatchmakingServers* self, [NativeTypeName("uint32")] uint unIP, [NativeTypeName("uint16")] ushort usPort, ISteamMatchmakingRulesResponse* pRequestServersResponse);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CancelServerQuery")]
    public static extern void SteamAPI_ISteamMatchmakingServers_CancelServerQuery(ISteamMatchmakingServers* self, HServerQuery hServerQuery);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamGameSearch* SteamAPI_SteamGameSearch_v001();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AddGameSearchParams")]
    public static extern EGameSearchErrorCode_t SteamAPI_ISteamGameSearch_AddGameSearchParams(ISteamGameSearch* self, [NativeTypeName("const char *")] sbyte* pchKeyToFind, [NativeTypeName("const char *")] sbyte* pchValuesToFind);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SearchForGameWithLobby")]
    public static extern EGameSearchErrorCode_t SteamAPI_ISteamGameSearch_SearchForGameWithLobby(ISteamGameSearch* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDLobby, int nPlayerMin, int nPlayerMax);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SearchForGameSolo")]
    public static extern EGameSearchErrorCode_t SteamAPI_ISteamGameSearch_SearchForGameSolo(ISteamGameSearch* self, int nPlayerMin, int nPlayerMax);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AcceptGame")]
    public static extern EGameSearchErrorCode_t SteamAPI_ISteamGameSearch_AcceptGame(ISteamGameSearch* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("DeclineGame")]
    public static extern EGameSearchErrorCode_t SteamAPI_ISteamGameSearch_DeclineGame(ISteamGameSearch* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RetrieveConnectionDetails")]
    public static extern EGameSearchErrorCode_t SteamAPI_ISteamGameSearch_RetrieveConnectionDetails(ISteamGameSearch* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDHost, [NativeTypeName("char *")] sbyte* pchConnectionDetails, int cubConnectionDetails);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("EndGameSearch")]
    public static extern EGameSearchErrorCode_t SteamAPI_ISteamGameSearch_EndGameSearch(ISteamGameSearch* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetGameHostParams")]
    public static extern EGameSearchErrorCode_t SteamAPI_ISteamGameSearch_SetGameHostParams(ISteamGameSearch* self, [NativeTypeName("const char *")] sbyte* pchKey, [NativeTypeName("const char *")] sbyte* pchValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetConnectionDetails")]
    public static extern EGameSearchErrorCode_t SteamAPI_ISteamGameSearch_SetConnectionDetails(ISteamGameSearch* self, [NativeTypeName("const char *")] sbyte* pchConnectionDetails, int cubConnectionDetails);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestPlayersForGame")]
    public static extern EGameSearchErrorCode_t SteamAPI_ISteamGameSearch_RequestPlayersForGame(ISteamGameSearch* self, int nPlayerMin, int nPlayerMax, int nMaxTeamSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("HostConfirmGameStart")]
    public static extern EGameSearchErrorCode_t SteamAPI_ISteamGameSearch_HostConfirmGameStart(ISteamGameSearch* self, [NativeTypeName("uint64")] ulong ullUniqueGameID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CancelRequestPlayersForGame")]
    public static extern EGameSearchErrorCode_t SteamAPI_ISteamGameSearch_CancelRequestPlayersForGame(ISteamGameSearch* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SubmitPlayerResult")]
    public static extern EGameSearchErrorCode_t SteamAPI_ISteamGameSearch_SubmitPlayerResult(ISteamGameSearch* self, [NativeTypeName("uint64")] ulong ullUniqueGameID, [NativeTypeName("uint64_steamid")] CSteamID steamIDPlayer, EPlayerResult_t EPlayerResult);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("EndGame")]
    public static extern EGameSearchErrorCode_t SteamAPI_ISteamGameSearch_EndGame(ISteamGameSearch* self, [NativeTypeName("uint64")] ulong ullUniqueGameID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamParties* SteamAPI_SteamParties_v002();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetNumActiveBeacons")]
    public static extern uint SteamAPI_ISteamParties_GetNumActiveBeacons(ISteamParties* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetBeaconByIndex")]
    public static extern PartyBeaconID_t SteamAPI_ISteamParties_GetBeaconByIndex(ISteamParties* self, [NativeTypeName("uint32")] uint unIndex);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetBeaconDetails")]
    public static extern byte SteamAPI_ISteamParties_GetBeaconDetails(ISteamParties* self, PartyBeaconID_t ulBeaconID, CSteamID* pSteamIDBeaconOwner, SteamPartyBeaconLocation_t* pLocation, [NativeTypeName("char *")] sbyte* pchMetadata, int cchMetadata);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("JoinParty")]
    public static extern SteamAPICall_t SteamAPI_ISteamParties_JoinParty(ISteamParties* self, PartyBeaconID_t ulBeaconID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetNumAvailableBeaconLocations")]
    public static extern byte SteamAPI_ISteamParties_GetNumAvailableBeaconLocations(ISteamParties* self, [NativeTypeName("uint32 *")] uint* puNumLocations);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetAvailableBeaconLocations")]
    public static extern byte SteamAPI_ISteamParties_GetAvailableBeaconLocations(ISteamParties* self, SteamPartyBeaconLocation_t* pLocationList, [NativeTypeName("uint32")] uint uMaxNumLocations);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateBeacon")]
    public static extern SteamAPICall_t SteamAPI_ISteamParties_CreateBeacon(ISteamParties* self, [NativeTypeName("uint32")] uint unOpenSlots, SteamPartyBeaconLocation_t* pBeaconLocation, [NativeTypeName("const char *")] sbyte* pchConnectString, [NativeTypeName("const char *")] sbyte* pchMetadata);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("OnReservationCompleted")]
    public static extern void SteamAPI_ISteamParties_OnReservationCompleted(ISteamParties* self, PartyBeaconID_t ulBeacon, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CancelReservation")]
    public static extern void SteamAPI_ISteamParties_CancelReservation(ISteamParties* self, PartyBeaconID_t ulBeacon, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ChangeNumOpenSlots")]
    public static extern SteamAPICall_t SteamAPI_ISteamParties_ChangeNumOpenSlots(ISteamParties* self, PartyBeaconID_t ulBeacon, [NativeTypeName("uint32")] uint unOpenSlots);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("DestroyBeacon")]
    public static extern byte SteamAPI_ISteamParties_DestroyBeacon(ISteamParties* self, PartyBeaconID_t ulBeacon);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetBeaconLocationData")]
    public static extern byte SteamAPI_ISteamParties_GetBeaconLocationData(ISteamParties* self, SteamPartyBeaconLocation_t BeaconLocation, ESteamPartyBeaconLocationData eData, [NativeTypeName("char *")] sbyte* pchDataStringOut, int cchDataStringOut);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamRemoteStorage* SteamAPI_SteamRemoteStorage_v016();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("FileWrite")]
    public static extern byte SteamAPI_ISteamRemoteStorage_FileWrite(ISteamRemoteStorage* self, [NativeTypeName("const char *")] sbyte* pchFile, [NativeTypeName("const void *")] void* pvData, [NativeTypeName("int32")] int cubData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int32")]
    [GenerateMemberFunction("FileRead")]
    public static extern int SteamAPI_ISteamRemoteStorage_FileRead(ISteamRemoteStorage* self, [NativeTypeName("const char *")] sbyte* pchFile, void* pvData, [NativeTypeName("int32")] int cubDataToRead);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("FileWriteAsync")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_FileWriteAsync(ISteamRemoteStorage* self, [NativeTypeName("const char *")] sbyte* pchFile, [NativeTypeName("const void *")] void* pvData, [NativeTypeName("uint32")] uint cubData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("FileReadAsync")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_FileReadAsync(ISteamRemoteStorage* self, [NativeTypeName("const char *")] sbyte* pchFile, [NativeTypeName("uint32")] uint nOffset, [NativeTypeName("uint32")] uint cubToRead);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("FileReadAsyncComplete")]
    public static extern byte SteamAPI_ISteamRemoteStorage_FileReadAsyncComplete(ISteamRemoteStorage* self, SteamAPICall_t hReadCall, void* pvBuffer, [NativeTypeName("uint32")] uint cubToRead);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("FileForget")]
    public static extern byte SteamAPI_ISteamRemoteStorage_FileForget(ISteamRemoteStorage* self, [NativeTypeName("const char *")] sbyte* pchFile);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("FileDelete")]
    public static extern byte SteamAPI_ISteamRemoteStorage_FileDelete(ISteamRemoteStorage* self, [NativeTypeName("const char *")] sbyte* pchFile);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("FileShare")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_FileShare(ISteamRemoteStorage* self, [NativeTypeName("const char *")] sbyte* pchFile);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetSyncPlatforms")]
    public static extern byte SteamAPI_ISteamRemoteStorage_SetSyncPlatforms(ISteamRemoteStorage* self, [NativeTypeName("const char *")] sbyte* pchFile, ERemoteStoragePlatform eRemoteStoragePlatform);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("FileWriteStreamOpen")]
    public static extern UGCFileWriteStreamHandle_t SteamAPI_ISteamRemoteStorage_FileWriteStreamOpen(ISteamRemoteStorage* self, [NativeTypeName("const char *")] sbyte* pchFile);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("FileWriteStreamWriteChunk")]
    public static extern byte SteamAPI_ISteamRemoteStorage_FileWriteStreamWriteChunk(ISteamRemoteStorage* self, UGCFileWriteStreamHandle_t writeHandle, [NativeTypeName("const void *")] void* pvData, [NativeTypeName("int32")] int cubData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("FileWriteStreamClose")]
    public static extern byte SteamAPI_ISteamRemoteStorage_FileWriteStreamClose(ISteamRemoteStorage* self, UGCFileWriteStreamHandle_t writeHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("FileWriteStreamCancel")]
    public static extern byte SteamAPI_ISteamRemoteStorage_FileWriteStreamCancel(ISteamRemoteStorage* self, UGCFileWriteStreamHandle_t writeHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("FileExists")]
    public static extern byte SteamAPI_ISteamRemoteStorage_FileExists(ISteamRemoteStorage* self, [NativeTypeName("const char *")] sbyte* pchFile);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("FilePersisted")]
    public static extern byte SteamAPI_ISteamRemoteStorage_FilePersisted(ISteamRemoteStorage* self, [NativeTypeName("const char *")] sbyte* pchFile);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int32")]
    [GenerateMemberFunction("GetFileSize")]
    public static extern int SteamAPI_ISteamRemoteStorage_GetFileSize(ISteamRemoteStorage* self, [NativeTypeName("const char *")] sbyte* pchFile);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int64")]
    [GenerateMemberFunction("GetFileTimestamp")]
    public static extern long SteamAPI_ISteamRemoteStorage_GetFileTimestamp(ISteamRemoteStorage* self, [NativeTypeName("const char *")] sbyte* pchFile);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetSyncPlatforms")]
    public static extern ERemoteStoragePlatform SteamAPI_ISteamRemoteStorage_GetSyncPlatforms(ISteamRemoteStorage* self, [NativeTypeName("const char *")] sbyte* pchFile);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int32")]
    [GenerateMemberFunction("GetFileCount")]
    public static extern int SteamAPI_ISteamRemoteStorage_GetFileCount(ISteamRemoteStorage* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetFileNameAndSize")]
    public static extern sbyte* SteamAPI_ISteamRemoteStorage_GetFileNameAndSize(ISteamRemoteStorage* self, int iFile, [NativeTypeName("int32 *")] int* pnFileSizeInBytes);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetQuota")]
    public static extern byte SteamAPI_ISteamRemoteStorage_GetQuota(ISteamRemoteStorage* self, [NativeTypeName("uint64 *")] ulong* pnTotalBytes, [NativeTypeName("uint64 *")] ulong* puAvailableBytes);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsCloudEnabledForAccount")]
    public static extern byte SteamAPI_ISteamRemoteStorage_IsCloudEnabledForAccount(ISteamRemoteStorage* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsCloudEnabledForApp")]
    public static extern byte SteamAPI_ISteamRemoteStorage_IsCloudEnabledForApp(ISteamRemoteStorage* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetCloudEnabledForApp")]
    public static extern void SteamAPI_ISteamRemoteStorage_SetCloudEnabledForApp(ISteamRemoteStorage* self, [NativeTypeName("bool")] byte bEnabled);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("UGCDownload")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_UGCDownload(ISteamRemoteStorage* self, UGCHandle_t hContent, [NativeTypeName("uint32")] uint unPriority);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetUGCDownloadProgress")]
    public static extern byte SteamAPI_ISteamRemoteStorage_GetUGCDownloadProgress(ISteamRemoteStorage* self, UGCHandle_t hContent, [NativeTypeName("int32 *")] int* pnBytesDownloaded, [NativeTypeName("int32 *")] int* pnBytesExpected);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetUGCDetails")]
    public static extern byte SteamAPI_ISteamRemoteStorage_GetUGCDetails(ISteamRemoteStorage* self, UGCHandle_t hContent, AppId_t* pnAppID, [NativeTypeName("char **")] sbyte** ppchName, [NativeTypeName("int32 *")] int* pnFileSizeInBytes, CSteamID* pSteamIDOwner);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int32")]
    [GenerateMemberFunction("UGCRead")]
    public static extern int SteamAPI_ISteamRemoteStorage_UGCRead(ISteamRemoteStorage* self, UGCHandle_t hContent, void* pvData, [NativeTypeName("int32")] int cubDataToRead, [NativeTypeName("uint32")] uint cOffset, EUGCReadAction eAction);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int32")]
    [GenerateMemberFunction("GetCachedUGCCount")]
    public static extern int SteamAPI_ISteamRemoteStorage_GetCachedUGCCount(ISteamRemoteStorage* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetCachedUGCHandle")]
    public static extern UGCHandle_t SteamAPI_ISteamRemoteStorage_GetCachedUGCHandle(ISteamRemoteStorage* self, [NativeTypeName("int32")] int iCachedContent);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("PublishWorkshopFile")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_PublishWorkshopFile(ISteamRemoteStorage* self, [NativeTypeName("const char *")] sbyte* pchFile, [NativeTypeName("const char *")] sbyte* pchPreviewFile, AppId_t nConsumerAppId, [NativeTypeName("const char *")] sbyte* pchTitle, [NativeTypeName("const char *")] sbyte* pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, SteamParamStringArray_t* pTags, EWorkshopFileType eWorkshopFileType);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreatePublishedFileUpdateRequest")]
    public static extern PublishedFileUpdateHandle_t SteamAPI_ISteamRemoteStorage_CreatePublishedFileUpdateRequest(ISteamRemoteStorage* self, PublishedFileId_t unPublishedFileId);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("UpdatePublishedFileFile")]
    public static extern byte SteamAPI_ISteamRemoteStorage_UpdatePublishedFileFile(ISteamRemoteStorage* self, PublishedFileUpdateHandle_t updateHandle, [NativeTypeName("const char *")] sbyte* pchFile);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("UpdatePublishedFilePreviewFile")]
    public static extern byte SteamAPI_ISteamRemoteStorage_UpdatePublishedFilePreviewFile(ISteamRemoteStorage* self, PublishedFileUpdateHandle_t updateHandle, [NativeTypeName("const char *")] sbyte* pchPreviewFile);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("UpdatePublishedFileTitle")]
    public static extern byte SteamAPI_ISteamRemoteStorage_UpdatePublishedFileTitle(ISteamRemoteStorage* self, PublishedFileUpdateHandle_t updateHandle, [NativeTypeName("const char *")] sbyte* pchTitle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("UpdatePublishedFileDescription")]
    public static extern byte SteamAPI_ISteamRemoteStorage_UpdatePublishedFileDescription(ISteamRemoteStorage* self, PublishedFileUpdateHandle_t updateHandle, [NativeTypeName("const char *")] sbyte* pchDescription);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("UpdatePublishedFileVisibility")]
    public static extern byte SteamAPI_ISteamRemoteStorage_UpdatePublishedFileVisibility(ISteamRemoteStorage* self, PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("UpdatePublishedFileTags")]
    public static extern byte SteamAPI_ISteamRemoteStorage_UpdatePublishedFileTags(ISteamRemoteStorage* self, PublishedFileUpdateHandle_t updateHandle, SteamParamStringArray_t* pTags);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CommitPublishedFileUpdate")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_CommitPublishedFileUpdate(ISteamRemoteStorage* self, PublishedFileUpdateHandle_t updateHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetPublishedFileDetails")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_GetPublishedFileDetails(ISteamRemoteStorage* self, PublishedFileId_t unPublishedFileId, [NativeTypeName("uint32")] uint unMaxSecondsOld);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("DeletePublishedFile")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_DeletePublishedFile(ISteamRemoteStorage* self, PublishedFileId_t unPublishedFileId);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("EnumerateUserPublishedFiles")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_EnumerateUserPublishedFiles(ISteamRemoteStorage* self, [NativeTypeName("uint32")] uint unStartIndex);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SubscribePublishedFile")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_SubscribePublishedFile(ISteamRemoteStorage* self, PublishedFileId_t unPublishedFileId);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("EnumerateUserSubscribedFiles")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_EnumerateUserSubscribedFiles(ISteamRemoteStorage* self, [NativeTypeName("uint32")] uint unStartIndex);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("UnsubscribePublishedFile")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_UnsubscribePublishedFile(ISteamRemoteStorage* self, PublishedFileId_t unPublishedFileId);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("UpdatePublishedFileSetChangeDescription")]
    public static extern byte SteamAPI_ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(ISteamRemoteStorage* self, PublishedFileUpdateHandle_t updateHandle, [NativeTypeName("const char *")] sbyte* pchChangeDescription);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetPublishedItemVoteDetails")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_GetPublishedItemVoteDetails(ISteamRemoteStorage* self, PublishedFileId_t unPublishedFileId);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("UpdateUserPublishedItemVote")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_UpdateUserPublishedItemVote(ISteamRemoteStorage* self, PublishedFileId_t unPublishedFileId, [NativeTypeName("bool")] byte bVoteUp);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetUserPublishedItemVoteDetails")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_GetUserPublishedItemVoteDetails(ISteamRemoteStorage* self, PublishedFileId_t unPublishedFileId);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("EnumerateUserSharedWorkshopFiles")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(ISteamRemoteStorage* self, [NativeTypeName("uint64_steamid")] CSteamID steamId, [NativeTypeName("uint32")] uint unStartIndex, SteamParamStringArray_t* pRequiredTags, SteamParamStringArray_t* pExcludedTags);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("PublishVideo")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_PublishVideo(ISteamRemoteStorage* self, EWorkshopVideoProvider eVideoProvider, [NativeTypeName("const char *")] sbyte* pchVideoAccount, [NativeTypeName("const char *")] sbyte* pchVideoIdentifier, [NativeTypeName("const char *")] sbyte* pchPreviewFile, AppId_t nConsumerAppId, [NativeTypeName("const char *")] sbyte* pchTitle, [NativeTypeName("const char *")] sbyte* pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, SteamParamStringArray_t* pTags);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetUserPublishedFileAction")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_SetUserPublishedFileAction(ISteamRemoteStorage* self, PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("EnumeratePublishedFilesByUserAction")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(ISteamRemoteStorage* self, EWorkshopFileAction eAction, [NativeTypeName("uint32")] uint unStartIndex);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("EnumeratePublishedWorkshopFiles")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(ISteamRemoteStorage* self, EWorkshopEnumerationType eEnumerationType, [NativeTypeName("uint32")] uint unStartIndex, [NativeTypeName("uint32")] uint unCount, [NativeTypeName("uint32")] uint unDays, SteamParamStringArray_t* pTags, SteamParamStringArray_t* pUserTags);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("UGCDownloadToLocation")]
    public static extern SteamAPICall_t SteamAPI_ISteamRemoteStorage_UGCDownloadToLocation(ISteamRemoteStorage* self, UGCHandle_t hContent, [NativeTypeName("const char *")] sbyte* pchLocation, [NativeTypeName("uint32")] uint unPriority);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int32")]
    [GenerateMemberFunction("GetLocalFileChangeCount")]
    public static extern int SteamAPI_ISteamRemoteStorage_GetLocalFileChangeCount(ISteamRemoteStorage* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetLocalFileChange")]
    public static extern sbyte* SteamAPI_ISteamRemoteStorage_GetLocalFileChange(ISteamRemoteStorage* self, int iFile, ERemoteStorageLocalFileChange* pEChangeType, ERemoteStorageFilePathType* pEFilePathType);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BeginFileWriteBatch")]
    public static extern byte SteamAPI_ISteamRemoteStorage_BeginFileWriteBatch(ISteamRemoteStorage* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("EndFileWriteBatch")]
    public static extern byte SteamAPI_ISteamRemoteStorage_EndFileWriteBatch(ISteamRemoteStorage* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamUserStats* SteamAPI_SteamUserStats_v012();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("RequestCurrentStats")]
    public static extern byte SteamAPI_ISteamUserStats_RequestCurrentStats(ISteamUserStats* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetStat")]
    public static extern byte SteamAPI_ISteamUserStats_GetStatInt32(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchName, [NativeTypeName("int32 *")] int* pData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetStat")]
    public static extern byte SteamAPI_ISteamUserStats_GetStatFloat(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchName, float* pData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetStat")]
    public static extern byte SteamAPI_ISteamUserStats_SetStatInt32(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchName, [NativeTypeName("int32")] int nData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetStat")]
    public static extern byte SteamAPI_ISteamUserStats_SetStatFloat(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchName, float fData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("UpdateAvgRateStat")]
    public static extern byte SteamAPI_ISteamUserStats_UpdateAvgRateStat(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchName, float flCountThisSession, double dSessionLength);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetAchievement")]
    public static extern byte SteamAPI_ISteamUserStats_GetAchievement(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchName, bool* pbAchieved);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetAchievement")]
    public static extern byte SteamAPI_ISteamUserStats_SetAchievement(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ClearAchievement")]
    public static extern byte SteamAPI_ISteamUserStats_ClearAchievement(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetAchievementAndUnlockTime")]
    public static extern byte SteamAPI_ISteamUserStats_GetAchievementAndUnlockTime(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchName, bool* pbAchieved, [NativeTypeName("uint32 *")] uint* punUnlockTime);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("StoreStats")]
    public static extern byte SteamAPI_ISteamUserStats_StoreStats(ISteamUserStats* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetAchievementIcon")]
    public static extern int SteamAPI_ISteamUserStats_GetAchievementIcon(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetAchievementDisplayAttribute")]
    public static extern sbyte* SteamAPI_ISteamUserStats_GetAchievementDisplayAttribute(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchName, [NativeTypeName("const char *")] sbyte* pchKey);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IndicateAchievementProgress")]
    public static extern byte SteamAPI_ISteamUserStats_IndicateAchievementProgress(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchName, [NativeTypeName("uint32")] uint nCurProgress, [NativeTypeName("uint32")] uint nMaxProgress);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetNumAchievements")]
    public static extern uint SteamAPI_ISteamUserStats_GetNumAchievements(ISteamUserStats* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetAchievementName")]
    public static extern sbyte* SteamAPI_ISteamUserStats_GetAchievementName(ISteamUserStats* self, [NativeTypeName("uint32")] uint iAchievement);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestUserStats")]
    public static extern SteamAPICall_t SteamAPI_ISteamUserStats_RequestUserStats(ISteamUserStats* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetUserStat")]
    public static extern byte SteamAPI_ISteamUserStats_GetUserStatInt32(ISteamUserStats* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser, [NativeTypeName("const char *")] sbyte* pchName, [NativeTypeName("int32 *")] int* pData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetUserStat")]
    public static extern byte SteamAPI_ISteamUserStats_GetUserStatFloat(ISteamUserStats* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser, [NativeTypeName("const char *")] sbyte* pchName, float* pData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetUserAchievement")]
    public static extern byte SteamAPI_ISteamUserStats_GetUserAchievement(ISteamUserStats* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser, [NativeTypeName("const char *")] sbyte* pchName, bool* pbAchieved);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetUserAchievementAndUnlockTime")]
    public static extern byte SteamAPI_ISteamUserStats_GetUserAchievementAndUnlockTime(ISteamUserStats* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser, [NativeTypeName("const char *")] sbyte* pchName, bool* pbAchieved, [NativeTypeName("uint32 *")] uint* punUnlockTime);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ResetAllStats")]
    public static extern byte SteamAPI_ISteamUserStats_ResetAllStats(ISteamUserStats* self, [NativeTypeName("bool")] byte bAchievementsToo);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("FindOrCreateLeaderboard")]
    public static extern SteamAPICall_t SteamAPI_ISteamUserStats_FindOrCreateLeaderboard(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("FindLeaderboard")]
    public static extern SteamAPICall_t SteamAPI_ISteamUserStats_FindLeaderboard(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchLeaderboardName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetLeaderboardName")]
    public static extern sbyte* SteamAPI_ISteamUserStats_GetLeaderboardName(ISteamUserStats* self, SteamLeaderboard_t hSteamLeaderboard);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetLeaderboardEntryCount")]
    public static extern int SteamAPI_ISteamUserStats_GetLeaderboardEntryCount(ISteamUserStats* self, SteamLeaderboard_t hSteamLeaderboard);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetLeaderboardSortMethod")]
    public static extern ELeaderboardSortMethod SteamAPI_ISteamUserStats_GetLeaderboardSortMethod(ISteamUserStats* self, SteamLeaderboard_t hSteamLeaderboard);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetLeaderboardDisplayType")]
    public static extern ELeaderboardDisplayType SteamAPI_ISteamUserStats_GetLeaderboardDisplayType(ISteamUserStats* self, SteamLeaderboard_t hSteamLeaderboard);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("DownloadLeaderboardEntries")]
    public static extern SteamAPICall_t SteamAPI_ISteamUserStats_DownloadLeaderboardEntries(ISteamUserStats* self, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("DownloadLeaderboardEntriesForUsers")]
    public static extern SteamAPICall_t SteamAPI_ISteamUserStats_DownloadLeaderboardEntriesForUsers(ISteamUserStats* self, SteamLeaderboard_t hSteamLeaderboard, CSteamID* prgUsers, int cUsers);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetDownloadedLeaderboardEntry")]
    public static extern byte SteamAPI_ISteamUserStats_GetDownloadedLeaderboardEntry(ISteamUserStats* self, SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, LeaderboardEntry_t* pLeaderboardEntry, [NativeTypeName("int32 *")] int* pDetails, int cDetailsMax);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("UploadLeaderboardScore")]
    public static extern SteamAPICall_t SteamAPI_ISteamUserStats_UploadLeaderboardScore(ISteamUserStats* self, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, [NativeTypeName("int32")] int nScore, [NativeTypeName("const int32 *")] int* pScoreDetails, int cScoreDetailsCount);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AttachLeaderboardUGC")]
    public static extern SteamAPICall_t SteamAPI_ISteamUserStats_AttachLeaderboardUGC(ISteamUserStats* self, SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetNumberOfCurrentPlayers")]
    public static extern SteamAPICall_t SteamAPI_ISteamUserStats_GetNumberOfCurrentPlayers(ISteamUserStats* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestGlobalAchievementPercentages")]
    public static extern SteamAPICall_t SteamAPI_ISteamUserStats_RequestGlobalAchievementPercentages(ISteamUserStats* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetMostAchievedAchievementInfo")]
    public static extern int SteamAPI_ISteamUserStats_GetMostAchievedAchievementInfo(ISteamUserStats* self, [NativeTypeName("char *")] sbyte* pchName, [NativeTypeName("uint32")] uint unNameBufLen, float* pflPercent, bool* pbAchieved);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetNextMostAchievedAchievementInfo")]
    public static extern int SteamAPI_ISteamUserStats_GetNextMostAchievedAchievementInfo(ISteamUserStats* self, int iIteratorPrevious, [NativeTypeName("char *")] sbyte* pchName, [NativeTypeName("uint32")] uint unNameBufLen, float* pflPercent, bool* pbAchieved);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetAchievementAchievedPercent")]
    public static extern byte SteamAPI_ISteamUserStats_GetAchievementAchievedPercent(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchName, float* pflPercent);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestGlobalStats")]
    public static extern SteamAPICall_t SteamAPI_ISteamUserStats_RequestGlobalStats(ISteamUserStats* self, int nHistoryDays);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetGlobalStat")]
    public static extern byte SteamAPI_ISteamUserStats_GetGlobalStatInt64(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchStatName, [NativeTypeName("int64 *")] long* pData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetGlobalStat")]
    public static extern byte SteamAPI_ISteamUserStats_GetGlobalStatDouble(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchStatName, double* pData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int32")]
    [GenerateMemberFunction("GetGlobalStatHistory")]
    public static extern int SteamAPI_ISteamUserStats_GetGlobalStatHistoryInt64(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchStatName, [NativeTypeName("int64 *")] long* pData, [NativeTypeName("uint32")] uint cubData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int32")]
    [GenerateMemberFunction("GetGlobalStatHistory")]
    public static extern int SteamAPI_ISteamUserStats_GetGlobalStatHistoryDouble(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchStatName, double* pData, [NativeTypeName("uint32")] uint cubData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetAchievementProgressLimits")]
    public static extern byte SteamAPI_ISteamUserStats_GetAchievementProgressLimitsInt32(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchName, [NativeTypeName("int32 *")] int* pnMinProgress, [NativeTypeName("int32 *")] int* pnMaxProgress);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetAchievementProgressLimits")]
    public static extern byte SteamAPI_ISteamUserStats_GetAchievementProgressLimitsFloat(ISteamUserStats* self, [NativeTypeName("const char *")] sbyte* pchName, float* pfMinProgress, float* pfMaxProgress);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamApps* SteamAPI_SteamApps_v008();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsSubscribed")]
    public static extern byte SteamAPI_ISteamApps_BIsSubscribed(ISteamApps* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsLowViolence")]
    public static extern byte SteamAPI_ISteamApps_BIsLowViolence(ISteamApps* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsCybercafe")]
    public static extern byte SteamAPI_ISteamApps_BIsCybercafe(ISteamApps* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsVACBanned")]
    public static extern byte SteamAPI_ISteamApps_BIsVACBanned(ISteamApps* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetCurrentGameLanguage")]
    public static extern sbyte* SteamAPI_ISteamApps_GetCurrentGameLanguage(ISteamApps* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetAvailableGameLanguages")]
    public static extern sbyte* SteamAPI_ISteamApps_GetAvailableGameLanguages(ISteamApps* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsSubscribedApp")]
    public static extern byte SteamAPI_ISteamApps_BIsSubscribedApp(ISteamApps* self, AppId_t appID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsDlcInstalled")]
    public static extern byte SteamAPI_ISteamApps_BIsDlcInstalled(ISteamApps* self, AppId_t appID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetEarliestPurchaseUnixTime")]
    public static extern uint SteamAPI_ISteamApps_GetEarliestPurchaseUnixTime(ISteamApps* self, AppId_t nAppID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsSubscribedFromFreeWeekend")]
    public static extern byte SteamAPI_ISteamApps_BIsSubscribedFromFreeWeekend(ISteamApps* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetDLCCount")]
    public static extern int SteamAPI_ISteamApps_GetDLCCount(ISteamApps* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BGetDLCDataByIndex")]
    public static extern byte SteamAPI_ISteamApps_BGetDLCDataByIndex(ISteamApps* self, int iDLC, AppId_t* pAppID, bool* pbAvailable, [NativeTypeName("char *")] sbyte* pchName, int cchNameBufferSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("InstallDLC")]
    public static extern void SteamAPI_ISteamApps_InstallDLC(ISteamApps* self, AppId_t nAppID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("UninstallDLC")]
    public static extern void SteamAPI_ISteamApps_UninstallDLC(ISteamApps* self, AppId_t nAppID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestAppProofOfPurchaseKey")]
    public static extern void SteamAPI_ISteamApps_RequestAppProofOfPurchaseKey(ISteamApps* self, AppId_t nAppID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetCurrentBetaName")]
    public static extern byte SteamAPI_ISteamApps_GetCurrentBetaName(ISteamApps* self, [NativeTypeName("char *")] sbyte* pchName, int cchNameBufferSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("MarkContentCorrupt")]
    public static extern byte SteamAPI_ISteamApps_MarkContentCorrupt(ISteamApps* self, [NativeTypeName("bool")] byte bMissingFilesOnly);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetInstalledDepots")]
    public static extern uint SteamAPI_ISteamApps_GetInstalledDepots(ISteamApps* self, AppId_t appID, DepotId_t* pvecDepots, [NativeTypeName("uint32")] uint cMaxDepots);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetAppInstallDir")]
    public static extern uint SteamAPI_ISteamApps_GetAppInstallDir(ISteamApps* self, AppId_t appID, [NativeTypeName("char *")] sbyte* pchFolder, [NativeTypeName("uint32")] uint cchFolderBufferSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsAppInstalled")]
    public static extern byte SteamAPI_ISteamApps_BIsAppInstalled(ISteamApps* self, AppId_t appID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_steamid")]
    [GenerateMemberFunction("GetAppOwner")]
    public static extern CSteamID SteamAPI_ISteamApps_GetAppOwner(ISteamApps* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetLaunchQueryParam")]
    public static extern sbyte* SteamAPI_ISteamApps_GetLaunchQueryParam(ISteamApps* self, [NativeTypeName("const char *")] sbyte* pchKey);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetDlcDownloadProgress")]
    public static extern byte SteamAPI_ISteamApps_GetDlcDownloadProgress(ISteamApps* self, AppId_t nAppID, [NativeTypeName("uint64 *")] ulong* punBytesDownloaded, [NativeTypeName("uint64 *")] ulong* punBytesTotal);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetAppBuildId")]
    public static extern int SteamAPI_ISteamApps_GetAppBuildId(ISteamApps* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestAllProofOfPurchaseKeys")]
    public static extern void SteamAPI_ISteamApps_RequestAllProofOfPurchaseKeys(ISteamApps* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFileDetails")]
    public static extern SteamAPICall_t SteamAPI_ISteamApps_GetFileDetails(ISteamApps* self, [NativeTypeName("const char *")] sbyte* pszFileName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetLaunchCommandLine")]
    public static extern int SteamAPI_ISteamApps_GetLaunchCommandLine(ISteamApps* self, [NativeTypeName("char *")] sbyte* pszCommandLine, int cubCommandLine);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsSubscribedFromFamilySharing")]
    public static extern byte SteamAPI_ISteamApps_BIsSubscribedFromFamilySharing(ISteamApps* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsTimedTrial")]
    public static extern byte SteamAPI_ISteamApps_BIsTimedTrial(ISteamApps* self, [NativeTypeName("uint32 *")] uint* punSecondsAllowed, [NativeTypeName("uint32 *")] uint* punSecondsPlayed);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetDlcContext")]
    public static extern byte SteamAPI_ISteamApps_SetDlcContext(ISteamApps* self, AppId_t nAppID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamNetworking* SteamAPI_SteamNetworking_v006();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamNetworking* SteamAPI_SteamGameServerNetworking_v006();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SendP2PPacket")]
    public static extern byte SteamAPI_ISteamNetworking_SendP2PPacket(ISteamNetworking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDRemote, [NativeTypeName("const void *")] void* pubData, [NativeTypeName("uint32")] uint cubData, EP2PSend eP2PSendType, int nChannel);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsP2PPacketAvailable")]
    public static extern byte SteamAPI_ISteamNetworking_IsP2PPacketAvailable(ISteamNetworking* self, [NativeTypeName("uint32 *")] uint* pcubMsgSize, int nChannel);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ReadP2PPacket")]
    public static extern byte SteamAPI_ISteamNetworking_ReadP2PPacket(ISteamNetworking* self, void* pubDest, [NativeTypeName("uint32")] uint cubDest, [NativeTypeName("uint32 *")] uint* pcubMsgSize, CSteamID* psteamIDRemote, int nChannel);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("AcceptP2PSessionWithUser")]
    public static extern byte SteamAPI_ISteamNetworking_AcceptP2PSessionWithUser(ISteamNetworking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDRemote);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("CloseP2PSessionWithUser")]
    public static extern byte SteamAPI_ISteamNetworking_CloseP2PSessionWithUser(ISteamNetworking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDRemote);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("CloseP2PChannelWithUser")]
    public static extern byte SteamAPI_ISteamNetworking_CloseP2PChannelWithUser(ISteamNetworking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDRemote, int nChannel);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetP2PSessionState")]
    public static extern byte SteamAPI_ISteamNetworking_GetP2PSessionState(ISteamNetworking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDRemote, P2PSessionState_t* pConnectionState);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("AllowP2PPacketRelay")]
    public static extern byte SteamAPI_ISteamNetworking_AllowP2PPacketRelay(ISteamNetworking* self, [NativeTypeName("bool")] byte bAllow);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateListenSocket")]
    public static extern SNetListenSocket_t SteamAPI_ISteamNetworking_CreateListenSocket(ISteamNetworking* self, int nVirtualP2PPort, SteamIPAddress_t nIP, [NativeTypeName("uint16")] ushort nPort, [NativeTypeName("bool")] byte bAllowUseOfPacketRelay);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateP2PConnectionSocket")]
    public static extern SNetSocket_t SteamAPI_ISteamNetworking_CreateP2PConnectionSocket(ISteamNetworking* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, [NativeTypeName("bool")] byte bAllowUseOfPacketRelay);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateConnectionSocket")]
    public static extern SNetSocket_t SteamAPI_ISteamNetworking_CreateConnectionSocket(ISteamNetworking* self, SteamIPAddress_t nIP, [NativeTypeName("uint16")] ushort nPort, int nTimeoutSec);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("DestroySocket")]
    public static extern byte SteamAPI_ISteamNetworking_DestroySocket(ISteamNetworking* self, SNetSocket_t hSocket, [NativeTypeName("bool")] byte bNotifyRemoteEnd);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("DestroyListenSocket")]
    public static extern byte SteamAPI_ISteamNetworking_DestroyListenSocket(ISteamNetworking* self, SNetListenSocket_t hSocket, [NativeTypeName("bool")] byte bNotifyRemoteEnd);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SendDataOnSocket")]
    public static extern byte SteamAPI_ISteamNetworking_SendDataOnSocket(ISteamNetworking* self, SNetSocket_t hSocket, void* pubData, [NativeTypeName("uint32")] uint cubData, [NativeTypeName("bool")] byte bReliable);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsDataAvailableOnSocket")]
    public static extern byte SteamAPI_ISteamNetworking_IsDataAvailableOnSocket(ISteamNetworking* self, SNetSocket_t hSocket, [NativeTypeName("uint32 *")] uint* pcubMsgSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("RetrieveDataFromSocket")]
    public static extern byte SteamAPI_ISteamNetworking_RetrieveDataFromSocket(ISteamNetworking* self, SNetSocket_t hSocket, void* pubDest, [NativeTypeName("uint32")] uint cubDest, [NativeTypeName("uint32 *")] uint* pcubMsgSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsDataAvailable")]
    public static extern byte SteamAPI_ISteamNetworking_IsDataAvailable(ISteamNetworking* self, SNetListenSocket_t hListenSocket, [NativeTypeName("uint32 *")] uint* pcubMsgSize, SNetSocket_t* phSocket);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("RetrieveData")]
    public static extern byte SteamAPI_ISteamNetworking_RetrieveData(ISteamNetworking* self, SNetListenSocket_t hListenSocket, void* pubDest, [NativeTypeName("uint32")] uint cubDest, [NativeTypeName("uint32 *")] uint* pcubMsgSize, SNetSocket_t* phSocket);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetSocketInfo")]
    public static extern byte SteamAPI_ISteamNetworking_GetSocketInfo(ISteamNetworking* self, SNetSocket_t hSocket, CSteamID* pSteamIDRemote, int* peSocketStatus, SteamIPAddress_t* punIPRemote, [NativeTypeName("uint16 *")] ushort* punPortRemote);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetListenSocketInfo")]
    public static extern byte SteamAPI_ISteamNetworking_GetListenSocketInfo(ISteamNetworking* self, SNetListenSocket_t hListenSocket, SteamIPAddress_t* pnIP, [NativeTypeName("uint16 *")] ushort* pnPort);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetSocketConnectionType")]
    public static extern ESNetSocketConnectionType SteamAPI_ISteamNetworking_GetSocketConnectionType(ISteamNetworking* self, SNetSocket_t hSocket);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetMaxPacketSize")]
    public static extern int SteamAPI_ISteamNetworking_GetMaxPacketSize(ISteamNetworking* self, SNetSocket_t hSocket);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamScreenshots* SteamAPI_SteamScreenshots_v003();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("WriteScreenshot")]
    public static extern ScreenshotHandle SteamAPI_ISteamScreenshots_WriteScreenshot(ISteamScreenshots* self, void* pubRGB, [NativeTypeName("uint32")] uint cubRGB, int nWidth, int nHeight);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AddScreenshotToLibrary")]
    public static extern ScreenshotHandle SteamAPI_ISteamScreenshots_AddScreenshotToLibrary(ISteamScreenshots* self, [NativeTypeName("const char *")] sbyte* pchFilename, [NativeTypeName("const char *")] sbyte* pchThumbnailFilename, int nWidth, int nHeight);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("TriggerScreenshot")]
    public static extern void SteamAPI_ISteamScreenshots_TriggerScreenshot(ISteamScreenshots* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("HookScreenshots")]
    public static extern void SteamAPI_ISteamScreenshots_HookScreenshots(ISteamScreenshots* self, [NativeTypeName("bool")] byte bHook);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetLocation")]
    public static extern byte SteamAPI_ISteamScreenshots_SetLocation(ISteamScreenshots* self, ScreenshotHandle hScreenshot, [NativeTypeName("const char *")] sbyte* pchLocation);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("TagUser")]
    public static extern byte SteamAPI_ISteamScreenshots_TagUser(ISteamScreenshots* self, ScreenshotHandle hScreenshot, [NativeTypeName("uint64_steamid")] CSteamID steamID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("TagPublishedFile")]
    public static extern byte SteamAPI_ISteamScreenshots_TagPublishedFile(ISteamScreenshots* self, ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsScreenshotsHooked")]
    public static extern byte SteamAPI_ISteamScreenshots_IsScreenshotsHooked(ISteamScreenshots* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AddVRScreenshotToLibrary")]
    public static extern ScreenshotHandle SteamAPI_ISteamScreenshots_AddVRScreenshotToLibrary(ISteamScreenshots* self, EVRScreenshotType eType, [NativeTypeName("const char *")] sbyte* pchFilename, [NativeTypeName("const char *")] sbyte* pchVRFilename);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamMusic* SteamAPI_SteamMusic_v001();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsEnabled")]
    public static extern byte SteamAPI_ISteamMusic_BIsEnabled(ISteamMusic* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsPlaying")]
    public static extern byte SteamAPI_ISteamMusic_BIsPlaying(ISteamMusic* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetPlaybackStatus")]
    public static extern AudioPlayback_Status SteamAPI_ISteamMusic_GetPlaybackStatus(ISteamMusic* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("Play")]
    public static extern void SteamAPI_ISteamMusic_Play(ISteamMusic* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("Pause")]
    public static extern void SteamAPI_ISteamMusic_Pause(ISteamMusic* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("PlayPrevious")]
    public static extern void SteamAPI_ISteamMusic_PlayPrevious(ISteamMusic* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("PlayNext")]
    public static extern void SteamAPI_ISteamMusic_PlayNext(ISteamMusic* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetVolume")]
    public static extern void SteamAPI_ISteamMusic_SetVolume(ISteamMusic* self, float flVolume);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetVolume")]
    public static extern float SteamAPI_ISteamMusic_GetVolume(ISteamMusic* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamMusicRemote* SteamAPI_SteamMusicRemote_v001();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("RegisterSteamMusicRemote")]
    public static extern byte SteamAPI_ISteamMusicRemote_RegisterSteamMusicRemote(ISteamMusicRemote* self, [NativeTypeName("const char *")] sbyte* pchName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("DeregisterSteamMusicRemote")]
    public static extern byte SteamAPI_ISteamMusicRemote_DeregisterSteamMusicRemote(ISteamMusicRemote* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsCurrentMusicRemote")]
    public static extern byte SteamAPI_ISteamMusicRemote_BIsCurrentMusicRemote(ISteamMusicRemote* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BActivationSuccess")]
    public static extern byte SteamAPI_ISteamMusicRemote_BActivationSuccess(ISteamMusicRemote* self, [NativeTypeName("bool")] byte bValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetDisplayName")]
    public static extern byte SteamAPI_ISteamMusicRemote_SetDisplayName(ISteamMusicRemote* self, [NativeTypeName("const char *")] sbyte* pchDisplayName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetPNGIcon_64x64")]
    public static extern byte SteamAPI_ISteamMusicRemote_SetPNGIcon_64x64(ISteamMusicRemote* self, void* pvBuffer, [NativeTypeName("uint32")] uint cbBufferLength);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("EnablePlayPrevious")]
    public static extern byte SteamAPI_ISteamMusicRemote_EnablePlayPrevious(ISteamMusicRemote* self, [NativeTypeName("bool")] byte bValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("EnablePlayNext")]
    public static extern byte SteamAPI_ISteamMusicRemote_EnablePlayNext(ISteamMusicRemote* self, [NativeTypeName("bool")] byte bValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("EnableShuffled")]
    public static extern byte SteamAPI_ISteamMusicRemote_EnableShuffled(ISteamMusicRemote* self, [NativeTypeName("bool")] byte bValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("EnableLooped")]
    public static extern byte SteamAPI_ISteamMusicRemote_EnableLooped(ISteamMusicRemote* self, [NativeTypeName("bool")] byte bValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("EnableQueue")]
    public static extern byte SteamAPI_ISteamMusicRemote_EnableQueue(ISteamMusicRemote* self, [NativeTypeName("bool")] byte bValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("EnablePlaylists")]
    public static extern byte SteamAPI_ISteamMusicRemote_EnablePlaylists(ISteamMusicRemote* self, [NativeTypeName("bool")] byte bValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("UpdatePlaybackStatus")]
    public static extern byte SteamAPI_ISteamMusicRemote_UpdatePlaybackStatus(ISteamMusicRemote* self, AudioPlayback_Status nStatus);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("UpdateShuffled")]
    public static extern byte SteamAPI_ISteamMusicRemote_UpdateShuffled(ISteamMusicRemote* self, [NativeTypeName("bool")] byte bValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("UpdateLooped")]
    public static extern byte SteamAPI_ISteamMusicRemote_UpdateLooped(ISteamMusicRemote* self, [NativeTypeName("bool")] byte bValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("UpdateVolume")]
    public static extern byte SteamAPI_ISteamMusicRemote_UpdateVolume(ISteamMusicRemote* self, float flValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("CurrentEntryWillChange")]
    public static extern byte SteamAPI_ISteamMusicRemote_CurrentEntryWillChange(ISteamMusicRemote* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("CurrentEntryIsAvailable")]
    public static extern byte SteamAPI_ISteamMusicRemote_CurrentEntryIsAvailable(ISteamMusicRemote* self, [NativeTypeName("bool")] byte bAvailable);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("UpdateCurrentEntryText")]
    public static extern byte SteamAPI_ISteamMusicRemote_UpdateCurrentEntryText(ISteamMusicRemote* self, [NativeTypeName("const char *")] sbyte* pchText);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("UpdateCurrentEntryElapsedSeconds")]
    public static extern byte SteamAPI_ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(ISteamMusicRemote* self, int nValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("UpdateCurrentEntryCoverArt")]
    public static extern byte SteamAPI_ISteamMusicRemote_UpdateCurrentEntryCoverArt(ISteamMusicRemote* self, void* pvBuffer, [NativeTypeName("uint32")] uint cbBufferLength);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("CurrentEntryDidChange")]
    public static extern byte SteamAPI_ISteamMusicRemote_CurrentEntryDidChange(ISteamMusicRemote* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("QueueWillChange")]
    public static extern byte SteamAPI_ISteamMusicRemote_QueueWillChange(ISteamMusicRemote* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ResetQueueEntries")]
    public static extern byte SteamAPI_ISteamMusicRemote_ResetQueueEntries(ISteamMusicRemote* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetQueueEntry")]
    public static extern byte SteamAPI_ISteamMusicRemote_SetQueueEntry(ISteamMusicRemote* self, int nID, int nPosition, [NativeTypeName("const char *")] sbyte* pchEntryText);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetCurrentQueueEntry")]
    public static extern byte SteamAPI_ISteamMusicRemote_SetCurrentQueueEntry(ISteamMusicRemote* self, int nID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("QueueDidChange")]
    public static extern byte SteamAPI_ISteamMusicRemote_QueueDidChange(ISteamMusicRemote* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("PlaylistWillChange")]
    public static extern byte SteamAPI_ISteamMusicRemote_PlaylistWillChange(ISteamMusicRemote* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ResetPlaylistEntries")]
    public static extern byte SteamAPI_ISteamMusicRemote_ResetPlaylistEntries(ISteamMusicRemote* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetPlaylistEntry")]
    public static extern byte SteamAPI_ISteamMusicRemote_SetPlaylistEntry(ISteamMusicRemote* self, int nID, int nPosition, [NativeTypeName("const char *")] sbyte* pchEntryText);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetCurrentPlaylistEntry")]
    public static extern byte SteamAPI_ISteamMusicRemote_SetCurrentPlaylistEntry(ISteamMusicRemote* self, int nID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("PlaylistDidChange")]
    public static extern byte SteamAPI_ISteamMusicRemote_PlaylistDidChange(ISteamMusicRemote* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamHTTP* SteamAPI_SteamHTTP_v003();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamHTTP* SteamAPI_SteamGameServerHTTP_v003();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateHTTPRequest")]
    public static extern HTTPRequestHandle SteamAPI_ISteamHTTP_CreateHTTPRequest(ISteamHTTP* self, EHTTPMethod eHTTPRequestMethod, [NativeTypeName("const char *")] sbyte* pchAbsoluteURL);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetHTTPRequestContextValue")]
    public static extern byte SteamAPI_ISteamHTTP_SetHTTPRequestContextValue(ISteamHTTP* self, HTTPRequestHandle hRequest, [NativeTypeName("uint64")] ulong ulContextValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetHTTPRequestNetworkActivityTimeout")]
    public static extern byte SteamAPI_ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(ISteamHTTP* self, HTTPRequestHandle hRequest, [NativeTypeName("uint32")] uint unTimeoutSeconds);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetHTTPRequestHeaderValue")]
    public static extern byte SteamAPI_ISteamHTTP_SetHTTPRequestHeaderValue(ISteamHTTP* self, HTTPRequestHandle hRequest, [NativeTypeName("const char *")] sbyte* pchHeaderName, [NativeTypeName("const char *")] sbyte* pchHeaderValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetHTTPRequestGetOrPostParameter")]
    public static extern byte SteamAPI_ISteamHTTP_SetHTTPRequestGetOrPostParameter(ISteamHTTP* self, HTTPRequestHandle hRequest, [NativeTypeName("const char *")] sbyte* pchParamName, [NativeTypeName("const char *")] sbyte* pchParamValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SendHTTPRequest")]
    public static extern byte SteamAPI_ISteamHTTP_SendHTTPRequest(ISteamHTTP* self, HTTPRequestHandle hRequest, SteamAPICall_t* pCallHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SendHTTPRequestAndStreamResponse")]
    public static extern byte SteamAPI_ISteamHTTP_SendHTTPRequestAndStreamResponse(ISteamHTTP* self, HTTPRequestHandle hRequest, SteamAPICall_t* pCallHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("DeferHTTPRequest")]
    public static extern byte SteamAPI_ISteamHTTP_DeferHTTPRequest(ISteamHTTP* self, HTTPRequestHandle hRequest);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("PrioritizeHTTPRequest")]
    public static extern byte SteamAPI_ISteamHTTP_PrioritizeHTTPRequest(ISteamHTTP* self, HTTPRequestHandle hRequest);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetHTTPResponseHeaderSize")]
    public static extern byte SteamAPI_ISteamHTTP_GetHTTPResponseHeaderSize(ISteamHTTP* self, HTTPRequestHandle hRequest, [NativeTypeName("const char *")] sbyte* pchHeaderName, [NativeTypeName("uint32 *")] uint* unResponseHeaderSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetHTTPResponseHeaderValue")]
    public static extern byte SteamAPI_ISteamHTTP_GetHTTPResponseHeaderValue(ISteamHTTP* self, HTTPRequestHandle hRequest, [NativeTypeName("const char *")] sbyte* pchHeaderName, [NativeTypeName("uint8 *")] byte* pHeaderValueBuffer, [NativeTypeName("uint32")] uint unBufferSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetHTTPResponseBodySize")]
    public static extern byte SteamAPI_ISteamHTTP_GetHTTPResponseBodySize(ISteamHTTP* self, HTTPRequestHandle hRequest, [NativeTypeName("uint32 *")] uint* unBodySize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetHTTPResponseBodyData")]
    public static extern byte SteamAPI_ISteamHTTP_GetHTTPResponseBodyData(ISteamHTTP* self, HTTPRequestHandle hRequest, [NativeTypeName("uint8 *")] byte* pBodyDataBuffer, [NativeTypeName("uint32")] uint unBufferSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetHTTPStreamingResponseBodyData")]
    public static extern byte SteamAPI_ISteamHTTP_GetHTTPStreamingResponseBodyData(ISteamHTTP* self, HTTPRequestHandle hRequest, [NativeTypeName("uint32")] uint cOffset, [NativeTypeName("uint8 *")] byte* pBodyDataBuffer, [NativeTypeName("uint32")] uint unBufferSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ReleaseHTTPRequest")]
    public static extern byte SteamAPI_ISteamHTTP_ReleaseHTTPRequest(ISteamHTTP* self, HTTPRequestHandle hRequest);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetHTTPDownloadProgressPct")]
    public static extern byte SteamAPI_ISteamHTTP_GetHTTPDownloadProgressPct(ISteamHTTP* self, HTTPRequestHandle hRequest, float* pflPercentOut);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetHTTPRequestRawPostBody")]
    public static extern byte SteamAPI_ISteamHTTP_SetHTTPRequestRawPostBody(ISteamHTTP* self, HTTPRequestHandle hRequest, [NativeTypeName("const char *")] sbyte* pchContentType, [NativeTypeName("uint8 *")] byte* pubBody, [NativeTypeName("uint32")] uint unBodyLen);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateCookieContainer")]
    public static extern HTTPCookieContainerHandle SteamAPI_ISteamHTTP_CreateCookieContainer(ISteamHTTP* self, [NativeTypeName("bool")] byte bAllowResponsesToModify);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ReleaseCookieContainer")]
    public static extern byte SteamAPI_ISteamHTTP_ReleaseCookieContainer(ISteamHTTP* self, HTTPCookieContainerHandle hCookieContainer);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetCookie")]
    public static extern byte SteamAPI_ISteamHTTP_SetCookie(ISteamHTTP* self, HTTPCookieContainerHandle hCookieContainer, [NativeTypeName("const char *")] sbyte* pchHost, [NativeTypeName("const char *")] sbyte* pchUrl, [NativeTypeName("const char *")] sbyte* pchCookie);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetHTTPRequestCookieContainer")]
    public static extern byte SteamAPI_ISteamHTTP_SetHTTPRequestCookieContainer(ISteamHTTP* self, HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetHTTPRequestUserAgentInfo")]
    public static extern byte SteamAPI_ISteamHTTP_SetHTTPRequestUserAgentInfo(ISteamHTTP* self, HTTPRequestHandle hRequest, [NativeTypeName("const char *")] sbyte* pchUserAgentInfo);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetHTTPRequestRequiresVerifiedCertificate")]
    public static extern byte SteamAPI_ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(ISteamHTTP* self, HTTPRequestHandle hRequest, [NativeTypeName("bool")] byte bRequireVerifiedCertificate);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetHTTPRequestAbsoluteTimeoutMS")]
    public static extern byte SteamAPI_ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(ISteamHTTP* self, HTTPRequestHandle hRequest, [NativeTypeName("uint32")] uint unMilliseconds);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetHTTPRequestWasTimedOut")]
    public static extern byte SteamAPI_ISteamHTTP_GetHTTPRequestWasTimedOut(ISteamHTTP* self, HTTPRequestHandle hRequest, bool* pbWasTimedOut);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamInput* SteamAPI_SteamInput_v006();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("Init")]
    public static extern byte SteamAPI_ISteamInput_Init(ISteamInput* self, [NativeTypeName("bool")] byte bExplicitlyCallRunFrame);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("Shutdown")]
    public static extern byte SteamAPI_ISteamInput_Shutdown(ISteamInput* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetInputActionManifestFilePath")]
    public static extern byte SteamAPI_ISteamInput_SetInputActionManifestFilePath(ISteamInput* self, [NativeTypeName("const char *")] sbyte* pchInputActionManifestAbsolutePath);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RunFrame")]
    public static extern void SteamAPI_ISteamInput_RunFrame(ISteamInput* self, [NativeTypeName("bool")] byte bReservedValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BWaitForData")]
    public static extern byte SteamAPI_ISteamInput_BWaitForData(ISteamInput* self, [NativeTypeName("bool")] byte bWaitForever, [NativeTypeName("uint32")] uint unTimeout);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BNewDataAvailable")]
    public static extern byte SteamAPI_ISteamInput_BNewDataAvailable(ISteamInput* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetConnectedControllers")]
    public static extern int SteamAPI_ISteamInput_GetConnectedControllers(ISteamInput* self, InputHandle_t* handlesOut);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("EnableDeviceCallbacks")]
    public static extern void SteamAPI_ISteamInput_EnableDeviceCallbacks(ISteamInput* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("EnableActionEventCallbacks")]
    public static extern void SteamAPI_ISteamInput_EnableActionEventCallbacks(ISteamInput* self, [NativeTypeName("SteamInputActionEventCallbackPointer")] delegate* unmanaged[Cdecl]<SteamInputActionEvent_t*, void> pCallback);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetActionSetHandle")]
    public static extern InputActionSetHandle_t SteamAPI_ISteamInput_GetActionSetHandle(ISteamInput* self, [NativeTypeName("const char *")] sbyte* pszActionSetName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ActivateActionSet")]
    public static extern void SteamAPI_ISteamInput_ActivateActionSet(ISteamInput* self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetCurrentActionSet")]
    public static extern InputActionSetHandle_t SteamAPI_ISteamInput_GetCurrentActionSet(ISteamInput* self, InputHandle_t inputHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ActivateActionSetLayer")]
    public static extern void SteamAPI_ISteamInput_ActivateActionSetLayer(ISteamInput* self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("DeactivateActionSetLayer")]
    public static extern void SteamAPI_ISteamInput_DeactivateActionSetLayer(ISteamInput* self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("DeactivateAllActionSetLayers")]
    public static extern void SteamAPI_ISteamInput_DeactivateAllActionSetLayers(ISteamInput* self, InputHandle_t inputHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetActiveActionSetLayers")]
    public static extern int SteamAPI_ISteamInput_GetActiveActionSetLayers(ISteamInput* self, InputHandle_t inputHandle, InputActionSetHandle_t* handlesOut);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetDigitalActionHandle")]
    public static extern InputDigitalActionHandle_t SteamAPI_ISteamInput_GetDigitalActionHandle(ISteamInput* self, [NativeTypeName("const char *")] sbyte* pszActionName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetDigitalActionData")]
    public static extern InputDigitalActionData_t SteamAPI_ISteamInput_GetDigitalActionData(ISteamInput* self, InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetDigitalActionOrigins")]
    public static extern int SteamAPI_ISteamInput_GetDigitalActionOrigins(ISteamInput* self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, EInputActionOrigin* originsOut);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetStringForDigitalActionName")]
    public static extern sbyte* SteamAPI_ISteamInput_GetStringForDigitalActionName(ISteamInput* self, InputDigitalActionHandle_t eActionHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetAnalogActionHandle")]
    public static extern InputAnalogActionHandle_t SteamAPI_ISteamInput_GetAnalogActionHandle(ISteamInput* self, [NativeTypeName("const char *")] sbyte* pszActionName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetAnalogActionData")]
    public static extern InputAnalogActionData_t SteamAPI_ISteamInput_GetAnalogActionData(ISteamInput* self, InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetAnalogActionOrigins")]
    public static extern int SteamAPI_ISteamInput_GetAnalogActionOrigins(ISteamInput* self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, EInputActionOrigin* originsOut);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetGlyphPNGForActionOrigin")]
    public static extern sbyte* SteamAPI_ISteamInput_GetGlyphPNGForActionOrigin(ISteamInput* self, EInputActionOrigin eOrigin, ESteamInputGlyphSize eSize, [NativeTypeName("uint32")] uint unFlags);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetGlyphSVGForActionOrigin")]
    public static extern sbyte* SteamAPI_ISteamInput_GetGlyphSVGForActionOrigin(ISteamInput* self, EInputActionOrigin eOrigin, [NativeTypeName("uint32")] uint unFlags);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetGlyphForActionOrigin_Legacy")]
    public static extern sbyte* SteamAPI_ISteamInput_GetGlyphForActionOrigin_Legacy(ISteamInput* self, EInputActionOrigin eOrigin);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetStringForActionOrigin")]
    public static extern sbyte* SteamAPI_ISteamInput_GetStringForActionOrigin(ISteamInput* self, EInputActionOrigin eOrigin);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetStringForAnalogActionName")]
    public static extern sbyte* SteamAPI_ISteamInput_GetStringForAnalogActionName(ISteamInput* self, InputAnalogActionHandle_t eActionHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("StopAnalogActionMomentum")]
    public static extern void SteamAPI_ISteamInput_StopAnalogActionMomentum(ISteamInput* self, InputHandle_t inputHandle, InputAnalogActionHandle_t eAction);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetMotionData")]
    public static extern InputMotionData_t SteamAPI_ISteamInput_GetMotionData(ISteamInput* self, InputHandle_t inputHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("TriggerVibration")]
    public static extern void SteamAPI_ISteamInput_TriggerVibration(ISteamInput* self, InputHandle_t inputHandle, [NativeTypeName("unsigned short")] ushort usLeftSpeed, [NativeTypeName("unsigned short")] ushort usRightSpeed);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("TriggerVibrationExtended")]
    public static extern void SteamAPI_ISteamInput_TriggerVibrationExtended(ISteamInput* self, InputHandle_t inputHandle, [NativeTypeName("unsigned short")] ushort usLeftSpeed, [NativeTypeName("unsigned short")] ushort usRightSpeed, [NativeTypeName("unsigned short")] ushort usLeftTriggerSpeed, [NativeTypeName("unsigned short")] ushort usRightTriggerSpeed);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("TriggerSimpleHapticEvent")]
    public static extern void SteamAPI_ISteamInput_TriggerSimpleHapticEvent(ISteamInput* self, InputHandle_t inputHandle, EControllerHapticLocation eHapticLocation, [NativeTypeName("uint8")] byte nIntensity, [NativeTypeName("char")] sbyte nGainDB, [NativeTypeName("uint8")] byte nOtherIntensity, [NativeTypeName("char")] sbyte nOtherGainDB);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetLEDColor")]
    public static extern void SteamAPI_ISteamInput_SetLEDColor(ISteamInput* self, InputHandle_t inputHandle, [NativeTypeName("uint8")] byte nColorR, [NativeTypeName("uint8")] byte nColorG, [NativeTypeName("uint8")] byte nColorB, [NativeTypeName("unsigned int")] uint nFlags);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("Legacy_TriggerHapticPulse")]
    public static extern void SteamAPI_ISteamInput_Legacy_TriggerHapticPulse(ISteamInput* self, InputHandle_t inputHandle, ESteamControllerPad eTargetPad, [NativeTypeName("unsigned short")] ushort usDurationMicroSec);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("Legacy_TriggerRepeatedHapticPulse")]
    public static extern void SteamAPI_ISteamInput_Legacy_TriggerRepeatedHapticPulse(ISteamInput* self, InputHandle_t inputHandle, ESteamControllerPad eTargetPad, [NativeTypeName("unsigned short")] ushort usDurationMicroSec, [NativeTypeName("unsigned short")] ushort usOffMicroSec, [NativeTypeName("unsigned short")] ushort unRepeat, [NativeTypeName("unsigned int")] uint nFlags);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ShowBindingPanel")]
    public static extern byte SteamAPI_ISteamInput_ShowBindingPanel(ISteamInput* self, InputHandle_t inputHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetInputTypeForHandle")]
    public static extern ESteamInputType SteamAPI_ISteamInput_GetInputTypeForHandle(ISteamInput* self, InputHandle_t inputHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetControllerForGamepadIndex")]
    public static extern InputHandle_t SteamAPI_ISteamInput_GetControllerForGamepadIndex(ISteamInput* self, int nIndex);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetGamepadIndexForController")]
    public static extern int SteamAPI_ISteamInput_GetGamepadIndexForController(ISteamInput* self, InputHandle_t ulinputHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetStringForXboxOrigin")]
    public static extern sbyte* SteamAPI_ISteamInput_GetStringForXboxOrigin(ISteamInput* self, EXboxOrigin eOrigin);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetGlyphForXboxOrigin")]
    public static extern sbyte* SteamAPI_ISteamInput_GetGlyphForXboxOrigin(ISteamInput* self, EXboxOrigin eOrigin);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetActionOriginFromXboxOrigin")]
    public static extern EInputActionOrigin SteamAPI_ISteamInput_GetActionOriginFromXboxOrigin(ISteamInput* self, InputHandle_t inputHandle, EXboxOrigin eOrigin);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("TranslateActionOrigin")]
    public static extern EInputActionOrigin SteamAPI_ISteamInput_TranslateActionOrigin(ISteamInput* self, ESteamInputType eDestinationInputType, EInputActionOrigin eSourceOrigin);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetDeviceBindingRevision")]
    public static extern byte SteamAPI_ISteamInput_GetDeviceBindingRevision(ISteamInput* self, InputHandle_t inputHandle, int* pMajor, int* pMinor);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetRemotePlaySessionID")]
    public static extern uint SteamAPI_ISteamInput_GetRemotePlaySessionID(ISteamInput* self, InputHandle_t inputHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint16")]
    [GenerateMemberFunction("GetSessionInputConfigurationSettings")]
    public static extern ushort SteamAPI_ISteamInput_GetSessionInputConfigurationSettings(ISteamInput* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetDualSenseTriggerEffect")]
    public static extern void SteamAPI_ISteamInput_SetDualSenseTriggerEffect(ISteamInput* self, InputHandle_t inputHandle, [NativeTypeName("const ScePadTriggerEffectParam *")] ScePadTriggerEffectParam* pParam);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamController* SteamAPI_SteamController_v008();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("Init")]
    public static extern byte SteamAPI_ISteamController_Init(ISteamController* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("Shutdown")]
    public static extern byte SteamAPI_ISteamController_Shutdown(ISteamController* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RunFrame")]
    public static extern void SteamAPI_ISteamController_RunFrame(ISteamController* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetConnectedControllers")]
    public static extern int SteamAPI_ISteamController_GetConnectedControllers(ISteamController* self, ControllerHandle_t* handlesOut);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetActionSetHandle")]
    public static extern ControllerActionSetHandle_t SteamAPI_ISteamController_GetActionSetHandle(ISteamController* self, [NativeTypeName("const char *")] sbyte* pszActionSetName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ActivateActionSet")]
    public static extern void SteamAPI_ISteamController_ActivateActionSet(ISteamController* self, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetCurrentActionSet")]
    public static extern ControllerActionSetHandle_t SteamAPI_ISteamController_GetCurrentActionSet(ISteamController* self, ControllerHandle_t controllerHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ActivateActionSetLayer")]
    public static extern void SteamAPI_ISteamController_ActivateActionSetLayer(ISteamController* self, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("DeactivateActionSetLayer")]
    public static extern void SteamAPI_ISteamController_DeactivateActionSetLayer(ISteamController* self, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("DeactivateAllActionSetLayers")]
    public static extern void SteamAPI_ISteamController_DeactivateAllActionSetLayers(ISteamController* self, ControllerHandle_t controllerHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetActiveActionSetLayers")]
    public static extern int SteamAPI_ISteamController_GetActiveActionSetLayers(ISteamController* self, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t* handlesOut);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetDigitalActionHandle")]
    public static extern ControllerDigitalActionHandle_t SteamAPI_ISteamController_GetDigitalActionHandle(ISteamController* self, [NativeTypeName("const char *")] sbyte* pszActionName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetDigitalActionData")]
    public static extern InputDigitalActionData_t SteamAPI_ISteamController_GetDigitalActionData(ISteamController* self, ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetDigitalActionOrigins")]
    public static extern int SteamAPI_ISteamController_GetDigitalActionOrigins(ISteamController* self, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerDigitalActionHandle_t digitalActionHandle, EControllerActionOrigin* originsOut);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetAnalogActionHandle")]
    public static extern ControllerAnalogActionHandle_t SteamAPI_ISteamController_GetAnalogActionHandle(ISteamController* self, [NativeTypeName("const char *")] sbyte* pszActionName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetAnalogActionData")]
    public static extern InputAnalogActionData_t SteamAPI_ISteamController_GetAnalogActionData(ISteamController* self, ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetAnalogActionOrigins")]
    public static extern int SteamAPI_ISteamController_GetAnalogActionOrigins(ISteamController* self, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerAnalogActionHandle_t analogActionHandle, EControllerActionOrigin* originsOut);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetGlyphForActionOrigin")]
    public static extern sbyte* SteamAPI_ISteamController_GetGlyphForActionOrigin(ISteamController* self, EControllerActionOrigin eOrigin);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetStringForActionOrigin")]
    public static extern sbyte* SteamAPI_ISteamController_GetStringForActionOrigin(ISteamController* self, EControllerActionOrigin eOrigin);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("StopAnalogActionMomentum")]
    public static extern void SteamAPI_ISteamController_StopAnalogActionMomentum(ISteamController* self, ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t eAction);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetMotionData")]
    public static extern InputMotionData_t SteamAPI_ISteamController_GetMotionData(ISteamController* self, ControllerHandle_t controllerHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("TriggerHapticPulse")]
    public static extern void SteamAPI_ISteamController_TriggerHapticPulse(ISteamController* self, ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, [NativeTypeName("unsigned short")] ushort usDurationMicroSec);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("TriggerRepeatedHapticPulse")]
    public static extern void SteamAPI_ISteamController_TriggerRepeatedHapticPulse(ISteamController* self, ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, [NativeTypeName("unsigned short")] ushort usDurationMicroSec, [NativeTypeName("unsigned short")] ushort usOffMicroSec, [NativeTypeName("unsigned short")] ushort unRepeat, [NativeTypeName("unsigned int")] uint nFlags);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("TriggerVibration")]
    public static extern void SteamAPI_ISteamController_TriggerVibration(ISteamController* self, ControllerHandle_t controllerHandle, [NativeTypeName("unsigned short")] ushort usLeftSpeed, [NativeTypeName("unsigned short")] ushort usRightSpeed);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetLEDColor")]
    public static extern void SteamAPI_ISteamController_SetLEDColor(ISteamController* self, ControllerHandle_t controllerHandle, [NativeTypeName("uint8")] byte nColorR, [NativeTypeName("uint8")] byte nColorG, [NativeTypeName("uint8")] byte nColorB, [NativeTypeName("unsigned int")] uint nFlags);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ShowBindingPanel")]
    public static extern byte SteamAPI_ISteamController_ShowBindingPanel(ISteamController* self, ControllerHandle_t controllerHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetInputTypeForHandle")]
    public static extern ESteamInputType SteamAPI_ISteamController_GetInputTypeForHandle(ISteamController* self, ControllerHandle_t controllerHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetControllerForGamepadIndex")]
    public static extern ControllerHandle_t SteamAPI_ISteamController_GetControllerForGamepadIndex(ISteamController* self, int nIndex);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetGamepadIndexForController")]
    public static extern int SteamAPI_ISteamController_GetGamepadIndexForController(ISteamController* self, ControllerHandle_t ulControllerHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetStringForXboxOrigin")]
    public static extern sbyte* SteamAPI_ISteamController_GetStringForXboxOrigin(ISteamController* self, EXboxOrigin eOrigin);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetGlyphForXboxOrigin")]
    public static extern sbyte* SteamAPI_ISteamController_GetGlyphForXboxOrigin(ISteamController* self, EXboxOrigin eOrigin);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetActionOriginFromXboxOrigin")]
    public static extern EControllerActionOrigin SteamAPI_ISteamController_GetActionOriginFromXboxOrigin(ISteamController* self, ControllerHandle_t controllerHandle, EXboxOrigin eOrigin);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("TranslateActionOrigin")]
    public static extern EControllerActionOrigin SteamAPI_ISteamController_TranslateActionOrigin(ISteamController* self, ESteamInputType eDestinationInputType, EControllerActionOrigin eSourceOrigin);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetControllerBindingRevision")]
    public static extern byte SteamAPI_ISteamController_GetControllerBindingRevision(ISteamController* self, ControllerHandle_t controllerHandle, int* pMajor, int* pMinor);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamUGC* SteamAPI_SteamUGC_v018();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamUGC* SteamAPI_SteamGameServerUGC_v018();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateQueryUserUGCRequest")]
    public static extern UGCQueryHandle_t SteamAPI_ISteamUGC_CreateQueryUserUGCRequest(ISteamUGC* self, AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, [NativeTypeName("uint32")] uint unPage);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateQueryAllUGCRequest")]
    public static extern UGCQueryHandle_t SteamAPI_ISteamUGC_CreateQueryAllUGCRequestPage(ISteamUGC* self, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, [NativeTypeName("uint32")] uint unPage);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateQueryAllUGCRequest")]
    public static extern UGCQueryHandle_t SteamAPI_ISteamUGC_CreateQueryAllUGCRequestCursor(ISteamUGC* self, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, [NativeTypeName("const char *")] sbyte* pchCursor);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateQueryUGCDetailsRequest")]
    public static extern UGCQueryHandle_t SteamAPI_ISteamUGC_CreateQueryUGCDetailsRequest(ISteamUGC* self, PublishedFileId_t* pvecPublishedFileID, [NativeTypeName("uint32")] uint unNumPublishedFileIDs);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SendQueryUGCRequest")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_SendQueryUGCRequest(ISteamUGC* self, UGCQueryHandle_t handle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetQueryUGCResult")]
    public static extern byte SteamAPI_ISteamUGC_GetQueryUGCResult(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("uint32")] uint index, SteamUGCDetails_t* pDetails);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetQueryUGCNumTags")]
    public static extern uint SteamAPI_ISteamUGC_GetQueryUGCNumTags(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("uint32")] uint index);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetQueryUGCTag")]
    public static extern byte SteamAPI_ISteamUGC_GetQueryUGCTag(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("uint32")] uint index, [NativeTypeName("uint32")] uint indexTag, [NativeTypeName("char *")] sbyte* pchValue, [NativeTypeName("uint32")] uint cchValueSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetQueryUGCTagDisplayName")]
    public static extern byte SteamAPI_ISteamUGC_GetQueryUGCTagDisplayName(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("uint32")] uint index, [NativeTypeName("uint32")] uint indexTag, [NativeTypeName("char *")] sbyte* pchValue, [NativeTypeName("uint32")] uint cchValueSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetQueryUGCPreviewURL")]
    public static extern byte SteamAPI_ISteamUGC_GetQueryUGCPreviewURL(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("uint32")] uint index, [NativeTypeName("char *")] sbyte* pchURL, [NativeTypeName("uint32")] uint cchURLSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetQueryUGCMetadata")]
    public static extern byte SteamAPI_ISteamUGC_GetQueryUGCMetadata(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("uint32")] uint index, [NativeTypeName("char *")] sbyte* pchMetadata, [NativeTypeName("uint32")] uint cchMetadatasize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetQueryUGCChildren")]
    public static extern byte SteamAPI_ISteamUGC_GetQueryUGCChildren(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("uint32")] uint index, PublishedFileId_t* pvecPublishedFileID, [NativeTypeName("uint32")] uint cMaxEntries);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetQueryUGCStatistic")]
    public static extern byte SteamAPI_ISteamUGC_GetQueryUGCStatistic(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("uint32")] uint index, EItemStatistic eStatType, [NativeTypeName("uint64 *")] ulong* pStatValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetQueryUGCNumAdditionalPreviews")]
    public static extern uint SteamAPI_ISteamUGC_GetQueryUGCNumAdditionalPreviews(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("uint32")] uint index);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetQueryUGCAdditionalPreview")]
    public static extern byte SteamAPI_ISteamUGC_GetQueryUGCAdditionalPreview(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("uint32")] uint index, [NativeTypeName("uint32")] uint previewIndex, [NativeTypeName("char *")] sbyte* pchURLOrVideoID, [NativeTypeName("uint32")] uint cchURLSize, [NativeTypeName("char *")] sbyte* pchOriginalFileName, [NativeTypeName("uint32")] uint cchOriginalFileNameSize, EItemPreviewType* pPreviewType);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetQueryUGCNumKeyValueTags")]
    public static extern uint SteamAPI_ISteamUGC_GetQueryUGCNumKeyValueTags(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("uint32")] uint index);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetQueryUGCKeyValueTag")]
    public static extern byte SteamAPI_ISteamUGC_GetQueryUGCKeyValueTag(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("uint32")] uint index, [NativeTypeName("uint32")] uint keyValueTagIndex, [NativeTypeName("char *")] sbyte* pchKey, [NativeTypeName("uint32")] uint cchKeySize, [NativeTypeName("char *")] sbyte* pchValue, [NativeTypeName("uint32")] uint cchValueSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetQueryUGCKeyValueTag")]
    public static extern byte SteamAPI_ISteamUGC_GetQueryFirstUGCKeyValueTag(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("uint32")] uint index, [NativeTypeName("const char *")] sbyte* pchKey, [NativeTypeName("char *")] sbyte* pchValue, [NativeTypeName("uint32")] uint cchValueSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetQueryUGCContentDescriptors")]
    public static extern uint SteamAPI_ISteamUGC_GetQueryUGCContentDescriptors(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("uint32")] uint index, EUGCContentDescriptorID* pvecDescriptors, [NativeTypeName("uint32")] uint cMaxEntries);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ReleaseQueryUGCRequest")]
    public static extern byte SteamAPI_ISteamUGC_ReleaseQueryUGCRequest(ISteamUGC* self, UGCQueryHandle_t handle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("AddRequiredTag")]
    public static extern byte SteamAPI_ISteamUGC_AddRequiredTag(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("const char *")] sbyte* pTagName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("AddRequiredTagGroup")]
    public static extern byte SteamAPI_ISteamUGC_AddRequiredTagGroup(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("const SteamParamStringArray_t *")] SteamParamStringArray_t* pTagGroups);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("AddExcludedTag")]
    public static extern byte SteamAPI_ISteamUGC_AddExcludedTag(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("const char *")] sbyte* pTagName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetReturnOnlyIDs")]
    public static extern byte SteamAPI_ISteamUGC_SetReturnOnlyIDs(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("bool")] byte bReturnOnlyIDs);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetReturnKeyValueTags")]
    public static extern byte SteamAPI_ISteamUGC_SetReturnKeyValueTags(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("bool")] byte bReturnKeyValueTags);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetReturnLongDescription")]
    public static extern byte SteamAPI_ISteamUGC_SetReturnLongDescription(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("bool")] byte bReturnLongDescription);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetReturnMetadata")]
    public static extern byte SteamAPI_ISteamUGC_SetReturnMetadata(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("bool")] byte bReturnMetadata);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetReturnChildren")]
    public static extern byte SteamAPI_ISteamUGC_SetReturnChildren(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("bool")] byte bReturnChildren);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetReturnAdditionalPreviews")]
    public static extern byte SteamAPI_ISteamUGC_SetReturnAdditionalPreviews(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("bool")] byte bReturnAdditionalPreviews);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetReturnTotalOnly")]
    public static extern byte SteamAPI_ISteamUGC_SetReturnTotalOnly(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("bool")] byte bReturnTotalOnly);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetReturnPlaytimeStats")]
    public static extern byte SteamAPI_ISteamUGC_SetReturnPlaytimeStats(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("uint32")] uint unDays);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetLanguage")]
    public static extern byte SteamAPI_ISteamUGC_SetLanguage(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("const char *")] sbyte* pchLanguage);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetAllowCachedResponse")]
    public static extern byte SteamAPI_ISteamUGC_SetAllowCachedResponse(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("uint32")] uint unMaxAgeSeconds);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetCloudFileNameFilter")]
    public static extern byte SteamAPI_ISteamUGC_SetCloudFileNameFilter(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("const char *")] sbyte* pMatchCloudFileName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetMatchAnyTag")]
    public static extern byte SteamAPI_ISteamUGC_SetMatchAnyTag(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("bool")] byte bMatchAnyTag);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetSearchText")]
    public static extern byte SteamAPI_ISteamUGC_SetSearchText(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("const char *")] sbyte* pSearchText);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetRankedByTrendDays")]
    public static extern byte SteamAPI_ISteamUGC_SetRankedByTrendDays(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("uint32")] uint unDays);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetTimeCreatedDateRange")]
    public static extern byte SteamAPI_ISteamUGC_SetTimeCreatedDateRange(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("RTime32")] uint rtStart, [NativeTypeName("RTime32")] uint rtEnd);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetTimeUpdatedDateRange")]
    public static extern byte SteamAPI_ISteamUGC_SetTimeUpdatedDateRange(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("RTime32")] uint rtStart, [NativeTypeName("RTime32")] uint rtEnd);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("AddRequiredKeyValueTag")]
    public static extern byte SteamAPI_ISteamUGC_AddRequiredKeyValueTag(ISteamUGC* self, UGCQueryHandle_t handle, [NativeTypeName("const char *")] sbyte* pKey, [NativeTypeName("const char *")] sbyte* pValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestUGCDetails")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_RequestUGCDetails(ISteamUGC* self, PublishedFileId_t nPublishedFileID, [NativeTypeName("uint32")] uint unMaxAgeSeconds);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateItem")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_CreateItem(ISteamUGC* self, AppId_t nConsumerAppId, EWorkshopFileType eFileType);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("StartItemUpdate")]
    public static extern UGCUpdateHandle_t SteamAPI_ISteamUGC_StartItemUpdate(ISteamUGC* self, AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetItemTitle")]
    public static extern byte SteamAPI_ISteamUGC_SetItemTitle(ISteamUGC* self, UGCUpdateHandle_t handle, [NativeTypeName("const char *")] sbyte* pchTitle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetItemDescription")]
    public static extern byte SteamAPI_ISteamUGC_SetItemDescription(ISteamUGC* self, UGCUpdateHandle_t handle, [NativeTypeName("const char *")] sbyte* pchDescription);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetItemUpdateLanguage")]
    public static extern byte SteamAPI_ISteamUGC_SetItemUpdateLanguage(ISteamUGC* self, UGCUpdateHandle_t handle, [NativeTypeName("const char *")] sbyte* pchLanguage);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetItemMetadata")]
    public static extern byte SteamAPI_ISteamUGC_SetItemMetadata(ISteamUGC* self, UGCUpdateHandle_t handle, [NativeTypeName("const char *")] sbyte* pchMetaData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetItemVisibility")]
    public static extern byte SteamAPI_ISteamUGC_SetItemVisibility(ISteamUGC* self, UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetItemTags")]
    public static extern byte SteamAPI_ISteamUGC_SetItemTags(ISteamUGC* self, UGCUpdateHandle_t updateHandle, [NativeTypeName("const SteamParamStringArray_t *")] SteamParamStringArray_t* pTags, [NativeTypeName("bool")] byte bAllowAdminTags);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetItemContent")]
    public static extern byte SteamAPI_ISteamUGC_SetItemContent(ISteamUGC* self, UGCUpdateHandle_t handle, [NativeTypeName("const char *")] sbyte* pszContentFolder);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetItemPreview")]
    public static extern byte SteamAPI_ISteamUGC_SetItemPreview(ISteamUGC* self, UGCUpdateHandle_t handle, [NativeTypeName("const char *")] sbyte* pszPreviewFile);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetAllowLegacyUpload")]
    public static extern byte SteamAPI_ISteamUGC_SetAllowLegacyUpload(ISteamUGC* self, UGCUpdateHandle_t handle, [NativeTypeName("bool")] byte bAllowLegacyUpload);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("RemoveAllItemKeyValueTags")]
    public static extern byte SteamAPI_ISteamUGC_RemoveAllItemKeyValueTags(ISteamUGC* self, UGCUpdateHandle_t handle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("RemoveItemKeyValueTags")]
    public static extern byte SteamAPI_ISteamUGC_RemoveItemKeyValueTags(ISteamUGC* self, UGCUpdateHandle_t handle, [NativeTypeName("const char *")] sbyte* pchKey);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("AddItemKeyValueTag")]
    public static extern byte SteamAPI_ISteamUGC_AddItemKeyValueTag(ISteamUGC* self, UGCUpdateHandle_t handle, [NativeTypeName("const char *")] sbyte* pchKey, [NativeTypeName("const char *")] sbyte* pchValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("AddItemPreviewFile")]
    public static extern byte SteamAPI_ISteamUGC_AddItemPreviewFile(ISteamUGC* self, UGCUpdateHandle_t handle, [NativeTypeName("const char *")] sbyte* pszPreviewFile, EItemPreviewType type);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("AddItemPreviewVideo")]
    public static extern byte SteamAPI_ISteamUGC_AddItemPreviewVideo(ISteamUGC* self, UGCUpdateHandle_t handle, [NativeTypeName("const char *")] sbyte* pszVideoID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("UpdateItemPreviewFile")]
    public static extern byte SteamAPI_ISteamUGC_UpdateItemPreviewFile(ISteamUGC* self, UGCUpdateHandle_t handle, [NativeTypeName("uint32")] uint index, [NativeTypeName("const char *")] sbyte* pszPreviewFile);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("UpdateItemPreviewVideo")]
    public static extern byte SteamAPI_ISteamUGC_UpdateItemPreviewVideo(ISteamUGC* self, UGCUpdateHandle_t handle, [NativeTypeName("uint32")] uint index, [NativeTypeName("const char *")] sbyte* pszVideoID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("RemoveItemPreview")]
    public static extern byte SteamAPI_ISteamUGC_RemoveItemPreview(ISteamUGC* self, UGCUpdateHandle_t handle, [NativeTypeName("uint32")] uint index);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("AddContentDescriptor")]
    public static extern byte SteamAPI_ISteamUGC_AddContentDescriptor(ISteamUGC* self, UGCUpdateHandle_t handle, EUGCContentDescriptorID descid);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("RemoveContentDescriptor")]
    public static extern byte SteamAPI_ISteamUGC_RemoveContentDescriptor(ISteamUGC* self, UGCUpdateHandle_t handle, EUGCContentDescriptorID descid);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SubmitItemUpdate")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_SubmitItemUpdate(ISteamUGC* self, UGCUpdateHandle_t handle, [NativeTypeName("const char *")] sbyte* pchChangeNote);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetItemUpdateProgress")]
    public static extern EItemUpdateStatus SteamAPI_ISteamUGC_GetItemUpdateProgress(ISteamUGC* self, UGCUpdateHandle_t handle, [NativeTypeName("uint64 *")] ulong* punBytesProcessed, [NativeTypeName("uint64 *")] ulong* punBytesTotal);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetUserItemVote")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_SetUserItemVote(ISteamUGC* self, PublishedFileId_t nPublishedFileID, [NativeTypeName("bool")] byte bVoteUp);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetUserItemVote")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_GetUserItemVote(ISteamUGC* self, PublishedFileId_t nPublishedFileID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AddItemToFavorites")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_AddItemToFavorites(ISteamUGC* self, AppId_t nAppId, PublishedFileId_t nPublishedFileID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RemoveItemFromFavorites")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_RemoveItemFromFavorites(ISteamUGC* self, AppId_t nAppId, PublishedFileId_t nPublishedFileID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SubscribeItem")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_SubscribeItem(ISteamUGC* self, PublishedFileId_t nPublishedFileID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("UnsubscribeItem")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_UnsubscribeItem(ISteamUGC* self, PublishedFileId_t nPublishedFileID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetNumSubscribedItems")]
    public static extern uint SteamAPI_ISteamUGC_GetNumSubscribedItems(ISteamUGC* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetSubscribedItems")]
    public static extern uint SteamAPI_ISteamUGC_GetSubscribedItems(ISteamUGC* self, PublishedFileId_t* pvecPublishedFileID, [NativeTypeName("uint32")] uint cMaxEntries);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetItemState")]
    public static extern uint SteamAPI_ISteamUGC_GetItemState(ISteamUGC* self, PublishedFileId_t nPublishedFileID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetItemInstallInfo")]
    public static extern byte SteamAPI_ISteamUGC_GetItemInstallInfo(ISteamUGC* self, PublishedFileId_t nPublishedFileID, [NativeTypeName("uint64 *")] ulong* punSizeOnDisk, [NativeTypeName("char *")] sbyte* pchFolder, [NativeTypeName("uint32")] uint cchFolderSize, [NativeTypeName("uint32 *")] uint* punTimeStamp);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetItemDownloadInfo")]
    public static extern byte SteamAPI_ISteamUGC_GetItemDownloadInfo(ISteamUGC* self, PublishedFileId_t nPublishedFileID, [NativeTypeName("uint64 *")] ulong* punBytesDownloaded, [NativeTypeName("uint64 *")] ulong* punBytesTotal);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("DownloadItem")]
    public static extern byte SteamAPI_ISteamUGC_DownloadItem(ISteamUGC* self, PublishedFileId_t nPublishedFileID, [NativeTypeName("bool")] byte bHighPriority);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BInitWorkshopForGameServer")]
    public static extern byte SteamAPI_ISteamUGC_BInitWorkshopForGameServer(ISteamUGC* self, DepotId_t unWorkshopDepotID, [NativeTypeName("const char *")] sbyte* pszFolder);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SuspendDownloads")]
    public static extern void SteamAPI_ISteamUGC_SuspendDownloads(ISteamUGC* self, [NativeTypeName("bool")] byte bSuspend);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("StartPlaytimeTracking")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_StartPlaytimeTracking(ISteamUGC* self, PublishedFileId_t* pvecPublishedFileID, [NativeTypeName("uint32")] uint unNumPublishedFileIDs);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("StopPlaytimeTracking")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_StopPlaytimeTracking(ISteamUGC* self, PublishedFileId_t* pvecPublishedFileID, [NativeTypeName("uint32")] uint unNumPublishedFileIDs);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("StopPlaytimeTrackingForAllItems")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_StopPlaytimeTrackingForAllItems(ISteamUGC* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AddDependency")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_AddDependency(ISteamUGC* self, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RemoveDependency")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_RemoveDependency(ISteamUGC* self, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AddAppDependency")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_AddAppDependency(ISteamUGC* self, PublishedFileId_t nPublishedFileID, AppId_t nAppID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RemoveAppDependency")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_RemoveAppDependency(ISteamUGC* self, PublishedFileId_t nPublishedFileID, AppId_t nAppID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetAppDependencies")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_GetAppDependencies(ISteamUGC* self, PublishedFileId_t nPublishedFileID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("DeleteItem")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_DeleteItem(ISteamUGC* self, PublishedFileId_t nPublishedFileID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ShowWorkshopEULA")]
    public static extern byte SteamAPI_ISteamUGC_ShowWorkshopEULA(ISteamUGC* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetWorkshopEULAStatus")]
    public static extern SteamAPICall_t SteamAPI_ISteamUGC_GetWorkshopEULAStatus(ISteamUGC* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetUserContentDescriptorPreferences")]
    public static extern uint SteamAPI_ISteamUGC_GetUserContentDescriptorPreferences(ISteamUGC* self, EUGCContentDescriptorID* pvecDescriptors, [NativeTypeName("uint32")] uint cMaxEntries);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamHTMLSurface* SteamAPI_SteamHTMLSurface_v005();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("Init")]
    public static extern byte SteamAPI_ISteamHTMLSurface_Init(ISteamHTMLSurface* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("Shutdown")]
    public static extern byte SteamAPI_ISteamHTMLSurface_Shutdown(ISteamHTMLSurface* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateBrowser")]
    public static extern SteamAPICall_t SteamAPI_ISteamHTMLSurface_CreateBrowser(ISteamHTMLSurface* self, [NativeTypeName("const char *")] sbyte* pchUserAgent, [NativeTypeName("const char *")] sbyte* pchUserCSS);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RemoveBrowser")]
    public static extern void SteamAPI_ISteamHTMLSurface_RemoveBrowser(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("LoadURL")]
    public static extern void SteamAPI_ISteamHTMLSurface_LoadURL(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("const char *")] sbyte* pchURL, [NativeTypeName("const char *")] sbyte* pchPostData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetSize")]
    public static extern void SteamAPI_ISteamHTMLSurface_SetSize(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("uint32")] uint unWidth, [NativeTypeName("uint32")] uint unHeight);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("StopLoad")]
    public static extern void SteamAPI_ISteamHTMLSurface_StopLoad(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("Reload")]
    public static extern void SteamAPI_ISteamHTMLSurface_Reload(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GoBack")]
    public static extern void SteamAPI_ISteamHTMLSurface_GoBack(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GoForward")]
    public static extern void SteamAPI_ISteamHTMLSurface_GoForward(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AddHeader")]
    public static extern void SteamAPI_ISteamHTMLSurface_AddHeader(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("const char *")] sbyte* pchKey, [NativeTypeName("const char *")] sbyte* pchValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ExecuteJavascript")]
    public static extern void SteamAPI_ISteamHTMLSurface_ExecuteJavascript(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("const char *")] sbyte* pchScript);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("MouseUp")]
    public static extern void SteamAPI_ISteamHTMLSurface_MouseUp(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("ISteamHTMLSurface::EHTMLMouseButton")] EHTMLMouseButton eMouseButton);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("MouseDown")]
    public static extern void SteamAPI_ISteamHTMLSurface_MouseDown(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("ISteamHTMLSurface::EHTMLMouseButton")] EHTMLMouseButton eMouseButton);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("MouseDoubleClick")]
    public static extern void SteamAPI_ISteamHTMLSurface_MouseDoubleClick(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("ISteamHTMLSurface::EHTMLMouseButton")] EHTMLMouseButton eMouseButton);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("MouseMove")]
    public static extern void SteamAPI_ISteamHTMLSurface_MouseMove(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, int x, int y);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("MouseWheel")]
    public static extern void SteamAPI_ISteamHTMLSurface_MouseWheel(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("int32")] int nDelta);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("KeyDown")]
    public static extern void SteamAPI_ISteamHTMLSurface_KeyDown(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("uint32")] uint nNativeKeyCode, [NativeTypeName("ISteamHTMLSurface::EHTMLKeyModifiers")] EHTMLKeyModifiers eHTMLKeyModifiers, [NativeTypeName("bool")] byte bIsSystemKey);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("KeyUp")]
    public static extern void SteamAPI_ISteamHTMLSurface_KeyUp(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("uint32")] uint nNativeKeyCode, [NativeTypeName("ISteamHTMLSurface::EHTMLKeyModifiers")] EHTMLKeyModifiers eHTMLKeyModifiers);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("KeyChar")]
    public static extern void SteamAPI_ISteamHTMLSurface_KeyChar(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("uint32")] uint cUnicodeChar, [NativeTypeName("ISteamHTMLSurface::EHTMLKeyModifiers")] EHTMLKeyModifiers eHTMLKeyModifiers);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetHorizontalScroll")]
    public static extern void SteamAPI_ISteamHTMLSurface_SetHorizontalScroll(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("uint32")] uint nAbsolutePixelScroll);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetVerticalScroll")]
    public static extern void SteamAPI_ISteamHTMLSurface_SetVerticalScroll(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("uint32")] uint nAbsolutePixelScroll);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetKeyFocus")]
    public static extern void SteamAPI_ISteamHTMLSurface_SetKeyFocus(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("bool")] byte bHasKeyFocus);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ViewSource")]
    public static extern void SteamAPI_ISteamHTMLSurface_ViewSource(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CopyToClipboard")]
    public static extern void SteamAPI_ISteamHTMLSurface_CopyToClipboard(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("PasteFromClipboard")]
    public static extern void SteamAPI_ISteamHTMLSurface_PasteFromClipboard(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("Find")]
    public static extern void SteamAPI_ISteamHTMLSurface_Find(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("const char *")] sbyte* pchSearchStr, [NativeTypeName("bool")] byte bCurrentlyInFind, [NativeTypeName("bool")] byte bReverse);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("StopFind")]
    public static extern void SteamAPI_ISteamHTMLSurface_StopFind(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetLinkAtPosition")]
    public static extern void SteamAPI_ISteamHTMLSurface_GetLinkAtPosition(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, int x, int y);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetCookie")]
    public static extern void SteamAPI_ISteamHTMLSurface_SetCookie(ISteamHTMLSurface* self, [NativeTypeName("const char *")] sbyte* pchHostname, [NativeTypeName("const char *")] sbyte* pchKey, [NativeTypeName("const char *")] sbyte* pchValue, [NativeTypeName("const char *")] sbyte* pchPath, [NativeTypeName("RTime32")] uint nExpires, [NativeTypeName("bool")] byte bSecure, [NativeTypeName("bool")] byte bHTTPOnly);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetPageScaleFactor")]
    public static extern void SteamAPI_ISteamHTMLSurface_SetPageScaleFactor(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetBackgroundMode")]
    public static extern void SteamAPI_ISteamHTMLSurface_SetBackgroundMode(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("bool")] byte bBackgroundMode);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetDPIScalingFactor")]
    public static extern void SteamAPI_ISteamHTMLSurface_SetDPIScalingFactor(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, float flDPIScaling);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("OpenDeveloperTools")]
    public static extern void SteamAPI_ISteamHTMLSurface_OpenDeveloperTools(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AllowStartRequest")]
    public static extern void SteamAPI_ISteamHTMLSurface_AllowStartRequest(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("bool")] byte bAllowed);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("JSDialogResponse")]
    public static extern void SteamAPI_ISteamHTMLSurface_JSDialogResponse(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("bool")] byte bResult);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("FileLoadDialogResponse")]
    public static extern void SteamAPI_ISteamHTMLSurface_FileLoadDialogResponse(ISteamHTMLSurface* self, HHTMLBrowser unBrowserHandle, [NativeTypeName("const char **")] sbyte** pchSelectedFiles);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamInventory* SteamAPI_SteamInventory_v003();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamInventory* SteamAPI_SteamGameServerInventory_v003();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetResultStatus")]
    public static extern EResult SteamAPI_ISteamInventory_GetResultStatus(ISteamInventory* self, SteamInventoryResult_t resultHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetResultItems")]
    public static extern byte SteamAPI_ISteamInventory_GetResultItems(ISteamInventory* self, SteamInventoryResult_t resultHandle, SteamItemDetails_t* pOutItemsArray, [NativeTypeName("uint32 *")] uint* punOutItemsArraySize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetResultItemProperty")]
    public static extern byte SteamAPI_ISteamInventory_GetResultItemProperty(ISteamInventory* self, SteamInventoryResult_t resultHandle, [NativeTypeName("uint32")] uint unItemIndex, [NativeTypeName("const char *")] sbyte* pchPropertyName, [NativeTypeName("char *")] sbyte* pchValueBuffer, [NativeTypeName("uint32 *")] uint* punValueBufferSizeOut);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetResultTimestamp")]
    public static extern uint SteamAPI_ISteamInventory_GetResultTimestamp(ISteamInventory* self, SteamInventoryResult_t resultHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("CheckResultSteamID")]
    public static extern byte SteamAPI_ISteamInventory_CheckResultSteamID(ISteamInventory* self, SteamInventoryResult_t resultHandle, [NativeTypeName("uint64_steamid")] CSteamID steamIDExpected);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("DestroyResult")]
    public static extern void SteamAPI_ISteamInventory_DestroyResult(ISteamInventory* self, SteamInventoryResult_t resultHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetAllItems")]
    public static extern byte SteamAPI_ISteamInventory_GetAllItems(ISteamInventory* self, SteamInventoryResult_t* pResultHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetItemsByID")]
    public static extern byte SteamAPI_ISteamInventory_GetItemsByID(ISteamInventory* self, SteamInventoryResult_t* pResultHandle, [NativeTypeName("const SteamItemInstanceID_t *")] SteamItemInstanceID_t* pInstanceIDs, [NativeTypeName("uint32")] uint unCountInstanceIDs);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SerializeResult")]
    public static extern byte SteamAPI_ISteamInventory_SerializeResult(ISteamInventory* self, SteamInventoryResult_t resultHandle, void* pOutBuffer, [NativeTypeName("uint32 *")] uint* punOutBufferSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("DeserializeResult")]
    public static extern byte SteamAPI_ISteamInventory_DeserializeResult(ISteamInventory* self, SteamInventoryResult_t* pOutResultHandle, [NativeTypeName("const void *")] void* pBuffer, [NativeTypeName("uint32")] uint unBufferSize, [NativeTypeName("bool")] byte bRESERVED_MUST_BE_FALSE);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GenerateItems")]
    public static extern byte SteamAPI_ISteamInventory_GenerateItems(ISteamInventory* self, SteamInventoryResult_t* pResultHandle, [NativeTypeName("const SteamItemDef_t *")] SteamItemDef_t* pArrayItemDefs, [NativeTypeName("const uint32 *")] uint* punArrayQuantity, [NativeTypeName("uint32")] uint unArrayLength);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GrantPromoItems")]
    public static extern byte SteamAPI_ISteamInventory_GrantPromoItems(ISteamInventory* self, SteamInventoryResult_t* pResultHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("AddPromoItem")]
    public static extern byte SteamAPI_ISteamInventory_AddPromoItem(ISteamInventory* self, SteamInventoryResult_t* pResultHandle, SteamItemDef_t itemDef);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("AddPromoItems")]
    public static extern byte SteamAPI_ISteamInventory_AddPromoItems(ISteamInventory* self, SteamInventoryResult_t* pResultHandle, [NativeTypeName("const SteamItemDef_t *")] SteamItemDef_t* pArrayItemDefs, [NativeTypeName("uint32")] uint unArrayLength);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ConsumeItem")]
    public static extern byte SteamAPI_ISteamInventory_ConsumeItem(ISteamInventory* self, SteamInventoryResult_t* pResultHandle, SteamItemInstanceID_t itemConsume, [NativeTypeName("uint32")] uint unQuantity);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ExchangeItems")]
    public static extern byte SteamAPI_ISteamInventory_ExchangeItems(ISteamInventory* self, SteamInventoryResult_t* pResultHandle, [NativeTypeName("const SteamItemDef_t *")] SteamItemDef_t* pArrayGenerate, [NativeTypeName("const uint32 *")] uint* punArrayGenerateQuantity, [NativeTypeName("uint32")] uint unArrayGenerateLength, [NativeTypeName("const SteamItemInstanceID_t *")] SteamItemInstanceID_t* pArrayDestroy, [NativeTypeName("const uint32 *")] uint* punArrayDestroyQuantity, [NativeTypeName("uint32")] uint unArrayDestroyLength);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("TransferItemQuantity")]
    public static extern byte SteamAPI_ISteamInventory_TransferItemQuantity(ISteamInventory* self, SteamInventoryResult_t* pResultHandle, SteamItemInstanceID_t itemIdSource, [NativeTypeName("uint32")] uint unQuantity, SteamItemInstanceID_t itemIdDest);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SendItemDropHeartbeat")]
    public static extern void SteamAPI_ISteamInventory_SendItemDropHeartbeat(ISteamInventory* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("TriggerItemDrop")]
    public static extern byte SteamAPI_ISteamInventory_TriggerItemDrop(ISteamInventory* self, SteamInventoryResult_t* pResultHandle, SteamItemDef_t dropListDefinition);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("TradeItems")]
    public static extern byte SteamAPI_ISteamInventory_TradeItems(ISteamInventory* self, SteamInventoryResult_t* pResultHandle, [NativeTypeName("uint64_steamid")] CSteamID steamIDTradePartner, [NativeTypeName("const SteamItemInstanceID_t *")] SteamItemInstanceID_t* pArrayGive, [NativeTypeName("const uint32 *")] uint* pArrayGiveQuantity, [NativeTypeName("uint32")] uint nArrayGiveLength, [NativeTypeName("const SteamItemInstanceID_t *")] SteamItemInstanceID_t* pArrayGet, [NativeTypeName("const uint32 *")] uint* pArrayGetQuantity, [NativeTypeName("uint32")] uint nArrayGetLength);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("LoadItemDefinitions")]
    public static extern byte SteamAPI_ISteamInventory_LoadItemDefinitions(ISteamInventory* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetItemDefinitionIDs")]
    public static extern byte SteamAPI_ISteamInventory_GetItemDefinitionIDs(ISteamInventory* self, SteamItemDef_t* pItemDefIDs, [NativeTypeName("uint32 *")] uint* punItemDefIDsArraySize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetItemDefinitionProperty")]
    public static extern byte SteamAPI_ISteamInventory_GetItemDefinitionProperty(ISteamInventory* self, SteamItemDef_t iDefinition, [NativeTypeName("const char *")] sbyte* pchPropertyName, [NativeTypeName("char *")] sbyte* pchValueBuffer, [NativeTypeName("uint32 *")] uint* punValueBufferSizeOut);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestEligiblePromoItemDefinitionsIDs")]
    public static extern SteamAPICall_t SteamAPI_ISteamInventory_RequestEligiblePromoItemDefinitionsIDs(ISteamInventory* self, [NativeTypeName("uint64_steamid")] CSteamID steamID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetEligiblePromoItemDefinitionIDs")]
    public static extern byte SteamAPI_ISteamInventory_GetEligiblePromoItemDefinitionIDs(ISteamInventory* self, [NativeTypeName("uint64_steamid")] CSteamID steamID, SteamItemDef_t* pItemDefIDs, [NativeTypeName("uint32 *")] uint* punItemDefIDsArraySize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("StartPurchase")]
    public static extern SteamAPICall_t SteamAPI_ISteamInventory_StartPurchase(ISteamInventory* self, [NativeTypeName("const SteamItemDef_t *")] SteamItemDef_t* pArrayItemDefs, [NativeTypeName("const uint32 *")] uint* punArrayQuantity, [NativeTypeName("uint32")] uint unArrayLength);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestPrices")]
    public static extern SteamAPICall_t SteamAPI_ISteamInventory_RequestPrices(ISteamInventory* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetNumItemsWithPrices")]
    public static extern uint SteamAPI_ISteamInventory_GetNumItemsWithPrices(ISteamInventory* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetItemsWithPrices")]
    public static extern byte SteamAPI_ISteamInventory_GetItemsWithPrices(ISteamInventory* self, SteamItemDef_t* pArrayItemDefs, [NativeTypeName("uint64 *")] ulong* pCurrentPrices, [NativeTypeName("uint64 *")] ulong* pBasePrices, [NativeTypeName("uint32")] uint unArrayLength);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetItemPrice")]
    public static extern byte SteamAPI_ISteamInventory_GetItemPrice(ISteamInventory* self, SteamItemDef_t iDefinition, [NativeTypeName("uint64 *")] ulong* pCurrentPrice, [NativeTypeName("uint64 *")] ulong* pBasePrice);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("StartUpdateProperties")]
    public static extern SteamInventoryUpdateHandle_t SteamAPI_ISteamInventory_StartUpdateProperties(ISteamInventory* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("RemoveProperty")]
    public static extern byte SteamAPI_ISteamInventory_RemoveProperty(ISteamInventory* self, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, [NativeTypeName("const char *")] sbyte* pchPropertyName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetProperty")]
    public static extern byte SteamAPI_ISteamInventory_SetPropertyString(ISteamInventory* self, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, [NativeTypeName("const char *")] sbyte* pchPropertyName, [NativeTypeName("const char *")] sbyte* pchPropertyValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetProperty")]
    public static extern byte SteamAPI_ISteamInventory_SetPropertyBool(ISteamInventory* self, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, [NativeTypeName("const char *")] sbyte* pchPropertyName, [NativeTypeName("bool")] byte bValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetProperty")]
    public static extern byte SteamAPI_ISteamInventory_SetPropertyInt64(ISteamInventory* self, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, [NativeTypeName("const char *")] sbyte* pchPropertyName, [NativeTypeName("int64")] long nValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetProperty")]
    public static extern byte SteamAPI_ISteamInventory_SetPropertyFloat(ISteamInventory* self, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, [NativeTypeName("const char *")] sbyte* pchPropertyName, float flValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SubmitUpdateProperties")]
    public static extern byte SteamAPI_ISteamInventory_SubmitUpdateProperties(ISteamInventory* self, SteamInventoryUpdateHandle_t handle, SteamInventoryResult_t* pResultHandle);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("InspectItem")]
    public static extern byte SteamAPI_ISteamInventory_InspectItem(ISteamInventory* self, SteamInventoryResult_t* pResultHandle, [NativeTypeName("const char *")] sbyte* pchItemToken);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamParentalSettings* SteamAPI_SteamParentalSettings_v001();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsParentalLockEnabled")]
    public static extern byte SteamAPI_ISteamParentalSettings_BIsParentalLockEnabled(ISteamParentalSettings* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsParentalLockLocked")]
    public static extern byte SteamAPI_ISteamParentalSettings_BIsParentalLockLocked(ISteamParentalSettings* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsAppBlocked")]
    public static extern byte SteamAPI_ISteamParentalSettings_BIsAppBlocked(ISteamParentalSettings* self, AppId_t nAppID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsAppInBlockList")]
    public static extern byte SteamAPI_ISteamParentalSettings_BIsAppInBlockList(ISteamParentalSettings* self, AppId_t nAppID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsFeatureBlocked")]
    public static extern byte SteamAPI_ISteamParentalSettings_BIsFeatureBlocked(ISteamParentalSettings* self, EParentalFeature eFeature);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BIsFeatureInBlockList")]
    public static extern byte SteamAPI_ISteamParentalSettings_BIsFeatureInBlockList(ISteamParentalSettings* self, EParentalFeature eFeature);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamRemotePlay* SteamAPI_SteamRemotePlay_v002();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetSessionCount")]
    public static extern uint SteamAPI_ISteamRemotePlay_GetSessionCount(ISteamRemotePlay* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetSessionID")]
    public static extern RemotePlaySessionID_t SteamAPI_ISteamRemotePlay_GetSessionID(ISteamRemotePlay* self, int iSessionIndex);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_steamid")]
    [GenerateMemberFunction("GetSessionSteamID")]
    public static extern CSteamID SteamAPI_ISteamRemotePlay_GetSessionSteamID(ISteamRemotePlay* self, RemotePlaySessionID_t unSessionID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetSessionClientName")]
    public static extern sbyte* SteamAPI_ISteamRemotePlay_GetSessionClientName(ISteamRemotePlay* self, RemotePlaySessionID_t unSessionID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetSessionClientFormFactor")]
    public static extern ESteamDeviceFormFactor SteamAPI_ISteamRemotePlay_GetSessionClientFormFactor(ISteamRemotePlay* self, RemotePlaySessionID_t unSessionID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BGetSessionClientResolution")]
    public static extern byte SteamAPI_ISteamRemotePlay_BGetSessionClientResolution(ISteamRemotePlay* self, RemotePlaySessionID_t unSessionID, int* pnResolutionX, int* pnResolutionY);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BStartRemotePlayTogether")]
    public static extern byte SteamAPI_ISteamRemotePlay_BStartRemotePlayTogether(ISteamRemotePlay* self, [NativeTypeName("bool")] byte bShowOverlay);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BSendRemotePlayTogetherInvite")]
    public static extern byte SteamAPI_ISteamRemotePlay_BSendRemotePlayTogetherInvite(ISteamRemotePlay* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDFriend);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamNetworkingMessages* SteamAPI_SteamNetworkingMessages_SteamAPI_v002();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamNetworkingMessages* SteamAPI_SteamGameServerNetworkingMessages_SteamAPI_v002();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SendMessageToUser")]
    public static extern EResult SteamAPI_ISteamNetworkingMessages_SendMessageToUser(ISteamNetworkingMessages* self, [NativeTypeName("const SteamNetworkingIdentity &")] SteamNetworkingIdentity* identityRemote, [NativeTypeName("const void *")] void* pubData, [NativeTypeName("uint32")] uint cubData, int nSendFlags, int nRemoteChannel);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ReceiveMessagesOnChannel")]
    public static extern int SteamAPI_ISteamNetworkingMessages_ReceiveMessagesOnChannel(ISteamNetworkingMessages* self, int nLocalChannel, SteamNetworkingMessage_t** ppOutMessages, int nMaxMessages);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("AcceptSessionWithUser")]
    public static extern byte SteamAPI_ISteamNetworkingMessages_AcceptSessionWithUser(ISteamNetworkingMessages* self, [NativeTypeName("const SteamNetworkingIdentity &")] SteamNetworkingIdentity* identityRemote);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("CloseSessionWithUser")]
    public static extern byte SteamAPI_ISteamNetworkingMessages_CloseSessionWithUser(ISteamNetworkingMessages* self, [NativeTypeName("const SteamNetworkingIdentity &")] SteamNetworkingIdentity* identityRemote);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("CloseChannelWithUser")]
    public static extern byte SteamAPI_ISteamNetworkingMessages_CloseChannelWithUser(ISteamNetworkingMessages* self, [NativeTypeName("const SteamNetworkingIdentity &")] SteamNetworkingIdentity* identityRemote, int nLocalChannel);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetSessionConnectionInfo")]
    public static extern ESteamNetworkingConnectionState SteamAPI_ISteamNetworkingMessages_GetSessionConnectionInfo(ISteamNetworkingMessages* self, [NativeTypeName("const SteamNetworkingIdentity &")] SteamNetworkingIdentity* identityRemote, SteamNetConnectionInfo_t* pConnectionInfo, SteamNetConnectionRealTimeStatus_t* pQuickStatus);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamNetworkingSockets* SteamAPI_SteamNetworkingSockets_SteamAPI_v012();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamNetworkingSockets* SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateListenSocketIP")]
    public static extern HSteamListenSocket SteamAPI_ISteamNetworkingSockets_CreateListenSocketIP(ISteamNetworkingSockets* self, [NativeTypeName("const SteamNetworkingIPAddr &")] SteamNetworkingIPAddr* localAddress, int nOptions, [NativeTypeName("const SteamNetworkingConfigValue_t *")] SteamNetworkingConfigValue_t* pOptions);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ConnectByIPAddress")]
    public static extern HSteamNetConnection SteamAPI_ISteamNetworkingSockets_ConnectByIPAddress(ISteamNetworkingSockets* self, [NativeTypeName("const SteamNetworkingIPAddr &")] SteamNetworkingIPAddr* address, int nOptions, [NativeTypeName("const SteamNetworkingConfigValue_t *")] SteamNetworkingConfigValue_t* pOptions);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateListenSocketP2P")]
    public static extern HSteamListenSocket SteamAPI_ISteamNetworkingSockets_CreateListenSocketP2P(ISteamNetworkingSockets* self, int nLocalVirtualPort, int nOptions, [NativeTypeName("const SteamNetworkingConfigValue_t *")] SteamNetworkingConfigValue_t* pOptions);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ConnectP2P")]
    public static extern HSteamNetConnection SteamAPI_ISteamNetworkingSockets_ConnectP2P(ISteamNetworkingSockets* self, [NativeTypeName("const SteamNetworkingIdentity &")] SteamNetworkingIdentity* identityRemote, int nRemoteVirtualPort, int nOptions, [NativeTypeName("const SteamNetworkingConfigValue_t *")] SteamNetworkingConfigValue_t* pOptions);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AcceptConnection")]
    public static extern EResult SteamAPI_ISteamNetworkingSockets_AcceptConnection(ISteamNetworkingSockets* self, HSteamNetConnection hConn);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("CloseConnection")]
    public static extern byte SteamAPI_ISteamNetworkingSockets_CloseConnection(ISteamNetworkingSockets* self, HSteamNetConnection hPeer, int nReason, [NativeTypeName("const char *")] sbyte* pszDebug, [NativeTypeName("bool")] byte bEnableLinger);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("CloseListenSocket")]
    public static extern byte SteamAPI_ISteamNetworkingSockets_CloseListenSocket(ISteamNetworkingSockets* self, HSteamListenSocket hSocket);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetConnectionUserData")]
    public static extern byte SteamAPI_ISteamNetworkingSockets_SetConnectionUserData(ISteamNetworkingSockets* self, HSteamNetConnection hPeer, [NativeTypeName("int64")] long nUserData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int64")]
    [GenerateMemberFunction("GetConnectionUserData")]
    public static extern long SteamAPI_ISteamNetworkingSockets_GetConnectionUserData(ISteamNetworkingSockets* self, HSteamNetConnection hPeer);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetConnectionName")]
    public static extern void SteamAPI_ISteamNetworkingSockets_SetConnectionName(ISteamNetworkingSockets* self, HSteamNetConnection hPeer, [NativeTypeName("const char *")] sbyte* pszName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetConnectionName")]
    public static extern byte SteamAPI_ISteamNetworkingSockets_GetConnectionName(ISteamNetworkingSockets* self, HSteamNetConnection hPeer, [NativeTypeName("char *")] sbyte* pszName, int nMaxLen);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SendMessageToConnection")]
    public static extern EResult SteamAPI_ISteamNetworkingSockets_SendMessageToConnection(ISteamNetworkingSockets* self, HSteamNetConnection hConn, [NativeTypeName("const void *")] void* pData, [NativeTypeName("uint32")] uint cbData, int nSendFlags, [NativeTypeName("int64 *")] long* pOutMessageNumber);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SendMessages")]
    public static extern void SteamAPI_ISteamNetworkingSockets_SendMessages(ISteamNetworkingSockets* self, int nMessages, [NativeTypeName("SteamNetworkingMessage_t *const *")] SteamNetworkingMessage_t** pMessages, [NativeTypeName("int64 *")] long* pOutMessageNumberOrResult);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("FlushMessagesOnConnection")]
    public static extern EResult SteamAPI_ISteamNetworkingSockets_FlushMessagesOnConnection(ISteamNetworkingSockets* self, HSteamNetConnection hConn);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ReceiveMessagesOnConnection")]
    public static extern int SteamAPI_ISteamNetworkingSockets_ReceiveMessagesOnConnection(ISteamNetworkingSockets* self, HSteamNetConnection hConn, SteamNetworkingMessage_t** ppOutMessages, int nMaxMessages);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetConnectionInfo")]
    public static extern byte SteamAPI_ISteamNetworkingSockets_GetConnectionInfo(ISteamNetworkingSockets* self, HSteamNetConnection hConn, SteamNetConnectionInfo_t* pInfo);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetConnectionRealTimeStatus")]
    public static extern EResult SteamAPI_ISteamNetworkingSockets_GetConnectionRealTimeStatus(ISteamNetworkingSockets* self, HSteamNetConnection hConn, SteamNetConnectionRealTimeStatus_t* pStatus, int nLanes, SteamNetConnectionRealTimeLaneStatus_t* pLanes);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetDetailedConnectionStatus")]
    public static extern int SteamAPI_ISteamNetworkingSockets_GetDetailedConnectionStatus(ISteamNetworkingSockets* self, HSteamNetConnection hConn, [NativeTypeName("char *")] sbyte* pszBuf, int cbBuf);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetListenSocketAddress")]
    public static extern byte SteamAPI_ISteamNetworkingSockets_GetListenSocketAddress(ISteamNetworkingSockets* self, HSteamListenSocket hSocket, SteamNetworkingIPAddr* address);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("CreateSocketPair")]
    public static extern byte SteamAPI_ISteamNetworkingSockets_CreateSocketPair(ISteamNetworkingSockets* self, HSteamNetConnection* pOutConnection1, HSteamNetConnection* pOutConnection2, [NativeTypeName("bool")] byte bUseNetworkLoopback, [NativeTypeName("const SteamNetworkingIdentity *")] SteamNetworkingIdentity* pIdentity1, [NativeTypeName("const SteamNetworkingIdentity *")] SteamNetworkingIdentity* pIdentity2);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ConfigureConnectionLanes")]
    public static extern EResult SteamAPI_ISteamNetworkingSockets_ConfigureConnectionLanes(ISteamNetworkingSockets* self, HSteamNetConnection hConn, int nNumLanes, [NativeTypeName("const int *")] int* pLanePriorities, [NativeTypeName("const uint16 *")] ushort* pLaneWeights);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetIdentity")]
    public static extern byte SteamAPI_ISteamNetworkingSockets_GetIdentity(ISteamNetworkingSockets* self, SteamNetworkingIdentity* pIdentity);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("InitAuthentication")]
    public static extern ESteamNetworkingAvailability SteamAPI_ISteamNetworkingSockets_InitAuthentication(ISteamNetworkingSockets* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetAuthenticationStatus")]
    public static extern ESteamNetworkingAvailability SteamAPI_ISteamNetworkingSockets_GetAuthenticationStatus(ISteamNetworkingSockets* self, SteamNetAuthenticationStatus_t* pDetails);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("HSteamNetPollGroup")]
    [GenerateMemberFunction("CreatePollGroup")]
    public static extern uint SteamAPI_ISteamNetworkingSockets_CreatePollGroup(ISteamNetworkingSockets* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("DestroyPollGroup")]
    public static extern byte SteamAPI_ISteamNetworkingSockets_DestroyPollGroup(ISteamNetworkingSockets* self, [NativeTypeName("HSteamNetPollGroup")] uint hPollGroup);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetConnectionPollGroup")]
    public static extern byte SteamAPI_ISteamNetworkingSockets_SetConnectionPollGroup(ISteamNetworkingSockets* self, HSteamNetConnection hConn, [NativeTypeName("HSteamNetPollGroup")] uint hPollGroup);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ReceiveMessagesOnPollGroup")]
    public static extern int SteamAPI_ISteamNetworkingSockets_ReceiveMessagesOnPollGroup(ISteamNetworkingSockets* self, [NativeTypeName("HSteamNetPollGroup")] uint hPollGroup, SteamNetworkingMessage_t** ppOutMessages, int nMaxMessages);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ReceivedRelayAuthTicket")]
    public static extern byte SteamAPI_ISteamNetworkingSockets_ReceivedRelayAuthTicket(ISteamNetworkingSockets* self, [NativeTypeName("const void *")] void* pvTicket, int cbTicket, SteamDatagramRelayAuthTicket* pOutParsedTicket);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("FindRelayAuthTicketForServer")]
    public static extern int SteamAPI_ISteamNetworkingSockets_FindRelayAuthTicketForServer(ISteamNetworkingSockets* self, [NativeTypeName("const SteamNetworkingIdentity &")] SteamNetworkingIdentity* identityGameServer, int nRemoteVirtualPort, SteamDatagramRelayAuthTicket* pOutParsedTicket);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ConnectToHostedDedicatedServer")]
    public static extern HSteamNetConnection SteamAPI_ISteamNetworkingSockets_ConnectToHostedDedicatedServer(ISteamNetworkingSockets* self, [NativeTypeName("const SteamNetworkingIdentity &")] SteamNetworkingIdentity* identityTarget, int nRemoteVirtualPort, int nOptions, [NativeTypeName("const SteamNetworkingConfigValue_t *")] SteamNetworkingConfigValue_t* pOptions);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint16")]
    [GenerateMemberFunction("GetHostedDedicatedServerPort")]
    public static extern ushort SteamAPI_ISteamNetworkingSockets_GetHostedDedicatedServerPort(ISteamNetworkingSockets* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SteamNetworkingPOPID")]
    [GenerateMemberFunction("GetHostedDedicatedServerPOPID")]
    public static extern uint SteamAPI_ISteamNetworkingSockets_GetHostedDedicatedServerPOPID(ISteamNetworkingSockets* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetHostedDedicatedServerAddress")]
    public static extern EResult SteamAPI_ISteamNetworkingSockets_GetHostedDedicatedServerAddress(ISteamNetworkingSockets* self, SteamDatagramHostedAddress* pRouting);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateHostedDedicatedServerListenSocket")]
    public static extern HSteamListenSocket SteamAPI_ISteamNetworkingSockets_CreateHostedDedicatedServerListenSocket(ISteamNetworkingSockets* self, int nLocalVirtualPort, int nOptions, [NativeTypeName("const SteamNetworkingConfigValue_t *")] SteamNetworkingConfigValue_t* pOptions);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetGameCoordinatorServerLogin")]
    public static extern EResult SteamAPI_ISteamNetworkingSockets_GetGameCoordinatorServerLogin(ISteamNetworkingSockets* self, SteamDatagramGameCoordinatorServerLogin* pLoginInfo, int* pcbSignedBlob, void* pBlob);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ConnectP2PCustomSignaling")]
    public static extern HSteamNetConnection SteamAPI_ISteamNetworkingSockets_ConnectP2PCustomSignaling(ISteamNetworkingSockets* self, ISteamNetworkingConnectionSignaling* pSignaling, [NativeTypeName("const SteamNetworkingIdentity *")] SteamNetworkingIdentity* pPeerIdentity, int nRemoteVirtualPort, int nOptions, [NativeTypeName("const SteamNetworkingConfigValue_t *")] SteamNetworkingConfigValue_t* pOptions);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ReceivedP2PCustomSignal")]
    public static extern byte SteamAPI_ISteamNetworkingSockets_ReceivedP2PCustomSignal(ISteamNetworkingSockets* self, [NativeTypeName("const void *")] void* pMsg, int cbMsg, ISteamNetworkingSignalingRecvContext* pContext);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetCertificateRequest")]
    public static extern byte SteamAPI_ISteamNetworkingSockets_GetCertificateRequest(ISteamNetworkingSockets* self, int* pcbBlob, void* pBlob, [NativeTypeName("SteamNetworkingErrMsg &")] sbyte** errMsg);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetCertificate")]
    public static extern byte SteamAPI_ISteamNetworkingSockets_SetCertificate(ISteamNetworkingSockets* self, [NativeTypeName("const void *")] void* pCertificate, int cbCertificate, [NativeTypeName("SteamNetworkingErrMsg &")] sbyte** errMsg);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ResetIdentity")]
    public static extern void SteamAPI_ISteamNetworkingSockets_ResetIdentity(ISteamNetworkingSockets* self, [NativeTypeName("const SteamNetworkingIdentity *")] SteamNetworkingIdentity* pIdentity);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RunCallbacks")]
    public static extern void SteamAPI_ISteamNetworkingSockets_RunCallbacks(ISteamNetworkingSockets* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BeginAsyncRequestFakeIP")]
    public static extern byte SteamAPI_ISteamNetworkingSockets_BeginAsyncRequestFakeIP(ISteamNetworkingSockets* self, int nNumPorts);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFakeIP")]
    public static extern void SteamAPI_ISteamNetworkingSockets_GetFakeIP(ISteamNetworkingSockets* self, int idxFirstPort, SteamNetworkingFakeIPResult_t* pInfo);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateListenSocketP2PFakeIP")]
    public static extern HSteamListenSocket SteamAPI_ISteamNetworkingSockets_CreateListenSocketP2PFakeIP(ISteamNetworkingSockets* self, int idxFakePort, int nOptions, [NativeTypeName("const SteamNetworkingConfigValue_t *")] SteamNetworkingConfigValue_t* pOptions);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetRemoteFakeIPForConnection")]
    public static extern EResult SteamAPI_ISteamNetworkingSockets_GetRemoteFakeIPForConnection(ISteamNetworkingSockets* self, HSteamNetConnection hConn, SteamNetworkingIPAddr* pOutAddr);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CreateFakeUDPPort")]
    public static extern ISteamNetworkingFakeUDPPort* SteamAPI_ISteamNetworkingSockets_CreateFakeUDPPort(ISteamNetworkingSockets* self, int idxFakeServerPort);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamNetworkingUtils* SteamAPI_SteamNetworkingUtils_SteamAPI_v004();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AllocateMessage")]
    public static extern SteamNetworkingMessage_t* SteamAPI_ISteamNetworkingUtils_AllocateMessage(ISteamNetworkingUtils* self, int cbAllocateBuffer);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("InitRelayNetworkAccess")]
    public static extern void SteamAPI_ISteamNetworkingUtils_InitRelayNetworkAccess(ISteamNetworkingUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetRelayNetworkStatus")]
    public static extern ESteamNetworkingAvailability SteamAPI_ISteamNetworkingUtils_GetRelayNetworkStatus(ISteamNetworkingUtils* self, SteamRelayNetworkStatus_t* pDetails);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetLocalPingLocation")]
    public static extern float SteamAPI_ISteamNetworkingUtils_GetLocalPingLocation(ISteamNetworkingUtils* self, [NativeTypeName("SteamNetworkPingLocation_t &")] SteamNetworkPingLocation_t* result);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("EstimatePingTimeBetweenTwoLocations")]
    public static extern int SteamAPI_ISteamNetworkingUtils_EstimatePingTimeBetweenTwoLocations(ISteamNetworkingUtils* self, [NativeTypeName("const SteamNetworkPingLocation_t &")] SteamNetworkPingLocation_t* location1, [NativeTypeName("const SteamNetworkPingLocation_t &")] SteamNetworkPingLocation_t* location2);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("EstimatePingTimeFromLocalHost")]
    public static extern int SteamAPI_ISteamNetworkingUtils_EstimatePingTimeFromLocalHost(ISteamNetworkingUtils* self, [NativeTypeName("const SteamNetworkPingLocation_t &")] SteamNetworkPingLocation_t* remoteLocation);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ConvertPingLocationToString")]
    public static extern void SteamAPI_ISteamNetworkingUtils_ConvertPingLocationToString(ISteamNetworkingUtils* self, [NativeTypeName("const SteamNetworkPingLocation_t &")] SteamNetworkPingLocation_t* location, [NativeTypeName("char *")] sbyte* pszBuf, int cchBufSize);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ParsePingLocationString")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_ParsePingLocationString(ISteamNetworkingUtils* self, [NativeTypeName("const char *")] sbyte* pszString, [NativeTypeName("SteamNetworkPingLocation_t &")] SteamNetworkPingLocation_t* result);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("CheckPingDataUpToDate")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_CheckPingDataUpToDate(ISteamNetworkingUtils* self, float flMaxAgeSeconds);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetPingToDataCenter")]
    public static extern int SteamAPI_ISteamNetworkingUtils_GetPingToDataCenter(ISteamNetworkingUtils* self, [NativeTypeName("SteamNetworkingPOPID")] uint popID, [NativeTypeName("SteamNetworkingPOPID *")] uint* pViaRelayPoP);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetDirectPingToPOP")]
    public static extern int SteamAPI_ISteamNetworkingUtils_GetDirectPingToPOP(ISteamNetworkingUtils* self, [NativeTypeName("SteamNetworkingPOPID")] uint popID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetPOPCount")]
    public static extern int SteamAPI_ISteamNetworkingUtils_GetPOPCount(ISteamNetworkingUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetPOPList")]
    public static extern int SteamAPI_ISteamNetworkingUtils_GetPOPList(ISteamNetworkingUtils* self, [NativeTypeName("SteamNetworkingPOPID *")] uint* list, int nListSz);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SteamNetworkingMicroseconds")]
    [GenerateMemberFunction("GetLocalTimestamp")]
    public static extern long SteamAPI_ISteamNetworkingUtils_GetLocalTimestamp(ISteamNetworkingUtils* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetDebugOutputFunction")]
    public static extern void SteamAPI_ISteamNetworkingUtils_SetDebugOutputFunction(ISteamNetworkingUtils* self, ESteamNetworkingSocketsDebugOutputType eDetailLevel, [NativeTypeName("FSteamNetworkingSocketsDebugOutput")] delegate* unmanaged[Cdecl]<ESteamNetworkingSocketsDebugOutputType, sbyte*, void> pfnFunc);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsFakeIPv4")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_IsFakeIPv4(ISteamNetworkingUtils* self, [NativeTypeName("uint32")] uint nIPv4);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetIPv4FakeIPType")]
    public static extern ESteamNetworkingFakeIPType SteamAPI_ISteamNetworkingUtils_GetIPv4FakeIPType(ISteamNetworkingUtils* self, [NativeTypeName("uint32")] uint nIPv4);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetRealIdentityForFakeIP")]
    public static extern EResult SteamAPI_ISteamNetworkingUtils_GetRealIdentityForFakeIP(ISteamNetworkingUtils* self, [NativeTypeName("const SteamNetworkingIPAddr &")] SteamNetworkingIPAddr* fakeIP, SteamNetworkingIdentity* pOutRealIdentity);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetGlobalConfigValueInt32")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_SetGlobalConfigValueInt32(ISteamNetworkingUtils* self, ESteamNetworkingConfigValue eValue, [NativeTypeName("int32")] int val);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetGlobalConfigValueFloat")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_SetGlobalConfigValueFloat(ISteamNetworkingUtils* self, ESteamNetworkingConfigValue eValue, float val);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetGlobalConfigValueString")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_SetGlobalConfigValueString(ISteamNetworkingUtils* self, ESteamNetworkingConfigValue eValue, [NativeTypeName("const char *")] sbyte* val);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetGlobalConfigValuePtr")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_SetGlobalConfigValuePtr(ISteamNetworkingUtils* self, ESteamNetworkingConfigValue eValue, void* val);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetConnectionConfigValueInt32")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_SetConnectionConfigValueInt32(ISteamNetworkingUtils* self, HSteamNetConnection hConn, ESteamNetworkingConfigValue eValue, [NativeTypeName("int32")] int val);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetConnectionConfigValueFloat")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_SetConnectionConfigValueFloat(ISteamNetworkingUtils* self, HSteamNetConnection hConn, ESteamNetworkingConfigValue eValue, float val);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetConnectionConfigValueString")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_SetConnectionConfigValueString(ISteamNetworkingUtils* self, HSteamNetConnection hConn, ESteamNetworkingConfigValue eValue, [NativeTypeName("const char *")] sbyte* val);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetGlobalCallback_SteamNetConnectionStatusChanged")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_SetGlobalCallback_SteamNetConnectionStatusChanged(ISteamNetworkingUtils* self, [NativeTypeName("FnSteamNetConnectionStatusChanged")] delegate* unmanaged[Cdecl]<SteamNetConnectionStatusChangedCallback_t*, void> fnCallback);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetGlobalCallback_SteamNetAuthenticationStatusChanged")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_SetGlobalCallback_SteamNetAuthenticationStatusChanged(ISteamNetworkingUtils* self, [NativeTypeName("FnSteamNetAuthenticationStatusChanged")] delegate* unmanaged[Cdecl]<SteamNetAuthenticationStatus_t*, void> fnCallback);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetGlobalCallback_SteamRelayNetworkStatusChanged")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_SetGlobalCallback_SteamRelayNetworkStatusChanged(ISteamNetworkingUtils* self, [NativeTypeName("FnSteamRelayNetworkStatusChanged")] delegate* unmanaged[Cdecl]<SteamRelayNetworkStatus_t*, void> fnCallback);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetGlobalCallback_FakeIPResult")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_SetGlobalCallback_FakeIPResult(ISteamNetworkingUtils* self, [NativeTypeName("FnSteamNetworkingFakeIPResult")] delegate* unmanaged[Cdecl]<SteamNetworkingFakeIPResult_t*, void> fnCallback);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetGlobalCallback_MessagesSessionRequest")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_SetGlobalCallback_MessagesSessionRequest(ISteamNetworkingUtils* self, [NativeTypeName("FnSteamNetworkingMessagesSessionRequest")] delegate* unmanaged[Cdecl]<SteamNetworkingMessagesSessionRequest_t*, void> fnCallback);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetGlobalCallback_MessagesSessionFailed")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_SetGlobalCallback_MessagesSessionFailed(ISteamNetworkingUtils* self, [NativeTypeName("FnSteamNetworkingMessagesSessionFailed")] delegate* unmanaged[Cdecl]<SteamNetworkingMessagesSessionFailed_t*, void> fnCallback);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetConfigValue")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_SetConfigValue(ISteamNetworkingUtils* self, ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, [NativeTypeName("intptr_t")] nint scopeObj, ESteamNetworkingConfigDataType eDataType, [NativeTypeName("const void *")] void* pArg);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetConfigValueStruct")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_SetConfigValueStruct(ISteamNetworkingUtils* self, [NativeTypeName("const SteamNetworkingConfigValue_t &")] SteamNetworkingConfigValue_t* opt, ESteamNetworkingConfigScope eScopeType, [NativeTypeName("intptr_t")] nint scopeObj);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetConfigValue")]
    public static extern ESteamNetworkingGetConfigValueResult SteamAPI_ISteamNetworkingUtils_GetConfigValue(ISteamNetworkingUtils* self, ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, [NativeTypeName("intptr_t")] nint scopeObj, ESteamNetworkingConfigDataType* pOutDataType, void* pResult, [NativeTypeName("size_t *")] nuint* cbResult);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetConfigValueInfo")]
    public static extern sbyte* SteamAPI_ISteamNetworkingUtils_GetConfigValueInfo(ISteamNetworkingUtils* self, ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigDataType* pOutDataType, ESteamNetworkingConfigScope* pOutScope);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("IterateGenericEditableConfigValues")]
    public static extern ESteamNetworkingConfigValue SteamAPI_ISteamNetworkingUtils_IterateGenericEditableConfigValues(ISteamNetworkingUtils* self, ESteamNetworkingConfigValue eCurrent, [NativeTypeName("bool")] byte bEnumerateDevVars);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SteamNetworkingIPAddr_ToString")]
    public static extern void SteamAPI_ISteamNetworkingUtils_SteamNetworkingIPAddr_ToString(ISteamNetworkingUtils* self, [NativeTypeName("const SteamNetworkingIPAddr &")] SteamNetworkingIPAddr* addr, [NativeTypeName("char *")] sbyte* buf, [NativeTypeName("uint32")] uint cbBuf, [NativeTypeName("bool")] byte bWithPort);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SteamNetworkingIPAddr_ParseString")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_SteamNetworkingIPAddr_ParseString(ISteamNetworkingUtils* self, SteamNetworkingIPAddr* pAddr, [NativeTypeName("const char *")] sbyte* pszStr);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SteamNetworkingIPAddr_GetFakeIPType")]
    public static extern ESteamNetworkingFakeIPType SteamAPI_ISteamNetworkingUtils_SteamNetworkingIPAddr_GetFakeIPType(ISteamNetworkingUtils* self, [NativeTypeName("const SteamNetworkingIPAddr &")] SteamNetworkingIPAddr* addr);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SteamNetworkingIdentity_ToString")]
    public static extern void SteamAPI_ISteamNetworkingUtils_SteamNetworkingIdentity_ToString(ISteamNetworkingUtils* self, [NativeTypeName("const SteamNetworkingIdentity &")] SteamNetworkingIdentity* identity, [NativeTypeName("char *")] sbyte* buf, [NativeTypeName("uint32")] uint cbBuf);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SteamNetworkingIdentity_ParseString")]
    public static extern byte SteamAPI_ISteamNetworkingUtils_SteamNetworkingIdentity_ParseString(ISteamNetworkingUtils* self, SteamNetworkingIdentity* pIdentity, [NativeTypeName("const char *")] sbyte* pszStr);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamGameServer* SteamAPI_SteamGameServer_v015();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetProduct")]
    public static extern void SteamAPI_ISteamGameServer_SetProduct(ISteamGameServer* self, [NativeTypeName("const char *")] sbyte* pszProduct);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetGameDescription")]
    public static extern void SteamAPI_ISteamGameServer_SetGameDescription(ISteamGameServer* self, [NativeTypeName("const char *")] sbyte* pszGameDescription);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetModDir")]
    public static extern void SteamAPI_ISteamGameServer_SetModDir(ISteamGameServer* self, [NativeTypeName("const char *")] sbyte* pszModDir);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetDedicatedServer")]
    public static extern void SteamAPI_ISteamGameServer_SetDedicatedServer(ISteamGameServer* self, [NativeTypeName("bool")] byte bDedicated);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("LogOn")]
    public static extern void SteamAPI_ISteamGameServer_LogOn(ISteamGameServer* self, [NativeTypeName("const char *")] sbyte* pszToken);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("LogOnAnonymous")]
    public static extern void SteamAPI_ISteamGameServer_LogOnAnonymous(ISteamGameServer* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("LogOff")]
    public static extern void SteamAPI_ISteamGameServer_LogOff(ISteamGameServer* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BLoggedOn")]
    public static extern byte SteamAPI_ISteamGameServer_BLoggedOn(ISteamGameServer* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BSecure")]
    public static extern byte SteamAPI_ISteamGameServer_BSecure(ISteamGameServer* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_steamid")]
    [GenerateMemberFunction("GetSteamID")]
    public static extern CSteamID SteamAPI_ISteamGameServer_GetSteamID(ISteamGameServer* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("WasRestartRequested")]
    public static extern byte SteamAPI_ISteamGameServer_WasRestartRequested(ISteamGameServer* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetMaxPlayerCount")]
    public static extern void SteamAPI_ISteamGameServer_SetMaxPlayerCount(ISteamGameServer* self, int cPlayersMax);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetBotPlayerCount")]
    public static extern void SteamAPI_ISteamGameServer_SetBotPlayerCount(ISteamGameServer* self, int cBotplayers);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetServerName")]
    public static extern void SteamAPI_ISteamGameServer_SetServerName(ISteamGameServer* self, [NativeTypeName("const char *")] sbyte* pszServerName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetMapName")]
    public static extern void SteamAPI_ISteamGameServer_SetMapName(ISteamGameServer* self, [NativeTypeName("const char *")] sbyte* pszMapName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetPasswordProtected")]
    public static extern void SteamAPI_ISteamGameServer_SetPasswordProtected(ISteamGameServer* self, [NativeTypeName("bool")] byte bPasswordProtected);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetSpectatorPort")]
    public static extern void SteamAPI_ISteamGameServer_SetSpectatorPort(ISteamGameServer* self, [NativeTypeName("uint16")] ushort unSpectatorPort);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetSpectatorServerName")]
    public static extern void SteamAPI_ISteamGameServer_SetSpectatorServerName(ISteamGameServer* self, [NativeTypeName("const char *")] sbyte* pszSpectatorServerName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ClearAllKeyValues")]
    public static extern void SteamAPI_ISteamGameServer_ClearAllKeyValues(ISteamGameServer* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetKeyValue")]
    public static extern void SteamAPI_ISteamGameServer_SetKeyValue(ISteamGameServer* self, [NativeTypeName("const char *")] sbyte* pKey, [NativeTypeName("const char *")] sbyte* pValue);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetGameTags")]
    public static extern void SteamAPI_ISteamGameServer_SetGameTags(ISteamGameServer* self, [NativeTypeName("const char *")] sbyte* pchGameTags);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetGameData")]
    public static extern void SteamAPI_ISteamGameServer_SetGameData(ISteamGameServer* self, [NativeTypeName("const char *")] sbyte* pchGameData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetRegion")]
    public static extern void SteamAPI_ISteamGameServer_SetRegion(ISteamGameServer* self, [NativeTypeName("const char *")] sbyte* pszRegion);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetAdvertiseServerActive")]
    public static extern void SteamAPI_ISteamGameServer_SetAdvertiseServerActive(ISteamGameServer* self, [NativeTypeName("bool")] byte bActive);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetAuthSessionTicket")]
    public static extern HAuthTicket SteamAPI_ISteamGameServer_GetAuthSessionTicket(ISteamGameServer* self, void* pTicket, int cbMaxTicket, [NativeTypeName("uint32 *")] uint* pcbTicket, [NativeTypeName("const SteamNetworkingIdentity *")] SteamNetworkingIdentity* pSnid);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("BeginAuthSession")]
    public static extern EBeginAuthSessionResult SteamAPI_ISteamGameServer_BeginAuthSession(ISteamGameServer* self, [NativeTypeName("const void *")] void* pAuthTicket, int cbAuthTicket, [NativeTypeName("uint64_steamid")] CSteamID steamID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("EndAuthSession")]
    public static extern void SteamAPI_ISteamGameServer_EndAuthSession(ISteamGameServer* self, [NativeTypeName("uint64_steamid")] CSteamID steamID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("CancelAuthTicket")]
    public static extern void SteamAPI_ISteamGameServer_CancelAuthTicket(ISteamGameServer* self, HAuthTicket hAuthTicket);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("UserHasLicenseForApp")]
    public static extern EUserHasLicenseForAppResult SteamAPI_ISteamGameServer_UserHasLicenseForApp(ISteamGameServer* self, [NativeTypeName("uint64_steamid")] CSteamID steamID, AppId_t appID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("RequestUserGroupStatus")]
    public static extern byte SteamAPI_ISteamGameServer_RequestUserGroupStatus(ISteamGameServer* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser, [NativeTypeName("uint64_steamid")] CSteamID steamIDGroup);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetGameplayStats")]
    public static extern void SteamAPI_ISteamGameServer_GetGameplayStats(ISteamGameServer* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetServerReputation")]
    public static extern SteamAPICall_t SteamAPI_ISteamGameServer_GetServerReputation(ISteamGameServer* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetPublicIP")]
    public static extern SteamIPAddress_t SteamAPI_ISteamGameServer_GetPublicIP(ISteamGameServer* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("HandleIncomingPacket")]
    public static extern byte SteamAPI_ISteamGameServer_HandleIncomingPacket(ISteamGameServer* self, [NativeTypeName("const void *")] void* pData, int cbData, [NativeTypeName("uint32")] uint srcIP, [NativeTypeName("uint16")] ushort srcPort);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetNextOutgoingPacket")]
    public static extern int SteamAPI_ISteamGameServer_GetNextOutgoingPacket(ISteamGameServer* self, void* pOut, int cbMaxOut, [NativeTypeName("uint32 *")] uint* pNetAdr, [NativeTypeName("uint16 *")] ushort* pPort);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("AssociateWithClan")]
    public static extern SteamAPICall_t SteamAPI_ISteamGameServer_AssociateWithClan(ISteamGameServer* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDClan);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ComputeNewPlayerCompatibility")]
    public static extern SteamAPICall_t SteamAPI_ISteamGameServer_ComputeNewPlayerCompatibility(ISteamGameServer* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDNewPlayer);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SendUserConnectAndAuthenticate_DEPRECATED", ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SendUserConnectAndAuthenticate")]
    [Obsolete]
    public static extern byte SteamAPI_ISteamGameServer_SendUserConnectAndAuthenticate(ISteamGameServer* self, [NativeTypeName("uint32")] uint unIPClient, [NativeTypeName("const void *")] void* pvAuthBlob, [NativeTypeName("uint32")] uint cubAuthBlobSize, CSteamID* pSteamIDUser);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_steamid")]
    [GenerateMemberFunction("CreateUnauthenticatedUserConnection")]
    public static extern CSteamID SteamAPI_ISteamGameServer_CreateUnauthenticatedUserConnection(ISteamGameServer* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SendUserDisconnect_DEPRECATED", ExactSpelling = true)]
    [GenerateMemberFunction("SendUserDisconnect")]
    [Obsolete]
    public static extern void SteamAPI_ISteamGameServer_SendUserDisconnect(ISteamGameServer* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("BUpdateUserData")]
    public static extern byte SteamAPI_ISteamGameServer_BUpdateUserData(ISteamGameServer* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser, [NativeTypeName("const char *")] sbyte* pchPlayerName, [NativeTypeName("uint32")] uint uScore);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISteamGameServerStats* SteamAPI_SteamGameServerStats_v001();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("RequestUserStats")]
    public static extern SteamAPICall_t SteamAPI_ISteamGameServerStats_RequestUserStats(ISteamGameServerStats* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetUserStat")]
    public static extern byte SteamAPI_ISteamGameServerStats_GetUserStatInt32(ISteamGameServerStats* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser, [NativeTypeName("const char *")] sbyte* pchName, [NativeTypeName("int32 *")] int* pData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetUserStat")]
    public static extern byte SteamAPI_ISteamGameServerStats_GetUserStatFloat(ISteamGameServerStats* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser, [NativeTypeName("const char *")] sbyte* pchName, float* pData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("GetUserAchievement")]
    public static extern byte SteamAPI_ISteamGameServerStats_GetUserAchievement(ISteamGameServerStats* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser, [NativeTypeName("const char *")] sbyte* pchName, bool* pbAchieved);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetUserStat")]
    public static extern byte SteamAPI_ISteamGameServerStats_SetUserStatInt32(ISteamGameServerStats* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser, [NativeTypeName("const char *")] sbyte* pchName, [NativeTypeName("int32")] int nData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetUserStat")]
    public static extern byte SteamAPI_ISteamGameServerStats_SetUserStatFloat(ISteamGameServerStats* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser, [NativeTypeName("const char *")] sbyte* pchName, float fData);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("UpdateUserAvgRateStat")]
    public static extern byte SteamAPI_ISteamGameServerStats_UpdateUserAvgRateStat(ISteamGameServerStats* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser, [NativeTypeName("const char *")] sbyte* pchName, float flCountThisSession, double dSessionLength);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetUserAchievement")]
    public static extern byte SteamAPI_ISteamGameServerStats_SetUserAchievement(ISteamGameServerStats* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser, [NativeTypeName("const char *")] sbyte* pchName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ClearUserAchievement")]
    public static extern byte SteamAPI_ISteamGameServerStats_ClearUserAchievement(ISteamGameServerStats* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser, [NativeTypeName("const char *")] sbyte* pchName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("StoreUserStats")]
    public static extern SteamAPICall_t SteamAPI_ISteamGameServerStats_StoreUserStats(ISteamGameServerStats* self, [NativeTypeName("uint64_steamid")] CSteamID steamIDUser);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("DestroyFakeUDPPort")]
    public static extern void SteamAPI_ISteamNetworkingFakeUDPPort_DestroyFakeUDPPort(ISteamNetworkingFakeUDPPort* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SendMessageToFakeIP")]
    public static extern EResult SteamAPI_ISteamNetworkingFakeUDPPort_SendMessageToFakeIP(ISteamNetworkingFakeUDPPort* self, [NativeTypeName("const SteamNetworkingIPAddr &")] SteamNetworkingIPAddr* remoteAddress, [NativeTypeName("const void *")] void* pData, [NativeTypeName("uint32")] uint cbData, int nSendFlags);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ReceiveMessages")]
    public static extern int SteamAPI_ISteamNetworkingFakeUDPPort_ReceiveMessages(ISteamNetworkingFakeUDPPort* self, SteamNetworkingMessage_t** ppOutMessages, int nMaxMessages);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ScheduleCleanup")]
    public static extern void SteamAPI_ISteamNetworkingFakeUDPPort_ScheduleCleanup(ISteamNetworkingFakeUDPPort* self, [NativeTypeName("const SteamNetworkingIPAddr &")] SteamNetworkingIPAddr* remoteAddress);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsSet")]
    public static extern byte SteamAPI_SteamIPAddress_t_IsSet(SteamIPAddress_t* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("Construct")]
    public static extern void SteamAPI_MatchMakingKeyValuePair_t_Construct(MatchMakingKeyValuePair_t* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("Construct")]
    public static extern void SteamAPI_servernetadr_t_Construct(servernetadr_t* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("Init")]
    public static extern void SteamAPI_servernetadr_t_Init(servernetadr_t* self, [NativeTypeName("unsigned int")] uint ip, [NativeTypeName("uint16")] ushort usQueryPort, [NativeTypeName("uint16")] ushort usConnectionPort);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint16")]
    [GenerateMemberFunction("GetQueryPort")]
    public static extern ushort SteamAPI_servernetadr_t_GetQueryPort(servernetadr_t* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetQueryPort")]
    public static extern void SteamAPI_servernetadr_t_SetQueryPort(servernetadr_t* self, [NativeTypeName("uint16")] ushort usPort);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint16")]
    [GenerateMemberFunction("GetConnectionPort")]
    public static extern ushort SteamAPI_servernetadr_t_GetConnectionPort(servernetadr_t* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetConnectionPort")]
    public static extern void SteamAPI_servernetadr_t_SetConnectionPort(servernetadr_t* self, [NativeTypeName("uint16")] ushort usPort);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetIP")]
    public static extern uint SteamAPI_servernetadr_t_GetIP(servernetadr_t* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetIP")]
    public static extern void SteamAPI_servernetadr_t_SetIP(servernetadr_t* self, [NativeTypeName("uint32")] uint unIP);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetConnectionAddressString")]
    public static extern sbyte* SteamAPI_servernetadr_t_GetConnectionAddressString(servernetadr_t* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetQueryAddressString")]
    public static extern sbyte* SteamAPI_servernetadr_t_GetQueryAddressString(servernetadr_t* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsLessThan")]
    public static extern byte SteamAPI_servernetadr_t_IsLessThan(servernetadr_t* self, [NativeTypeName("const servernetadr_t &")] servernetadr_t* netadr);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("Assign")]
    public static extern void SteamAPI_servernetadr_t_Assign(servernetadr_t* self, [NativeTypeName("const servernetadr_t &")] servernetadr_t* that);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("Construct")]
    public static extern void SteamAPI_gameserveritem_t_Construct(gameserveritem_t* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetName")]
    public static extern sbyte* SteamAPI_gameserveritem_t_GetName(gameserveritem_t* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetName")]
    public static extern void SteamAPI_gameserveritem_t_SetName(gameserveritem_t* self, [NativeTypeName("const char *")] sbyte* pName);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("Clear")]
    public static extern void SteamAPI_SteamNetworkingIPAddr_Clear(SteamNetworkingIPAddr* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsIPv6AllZeros")]
    public static extern byte SteamAPI_SteamNetworkingIPAddr_IsIPv6AllZeros(SteamNetworkingIPAddr* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetIPv6")]
    public static extern void SteamAPI_SteamNetworkingIPAddr_SetIPv6(SteamNetworkingIPAddr* self, [NativeTypeName("const uint8 *")] byte* ipv6, [NativeTypeName("uint16")] ushort nPort);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetIPv4")]
    public static extern void SteamAPI_SteamNetworkingIPAddr_SetIPv4(SteamNetworkingIPAddr* self, [NativeTypeName("uint32")] uint nIP, [NativeTypeName("uint16")] ushort nPort);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsIPv4")]
    public static extern byte SteamAPI_SteamNetworkingIPAddr_IsIPv4(SteamNetworkingIPAddr* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetIPv4")]
    public static extern uint SteamAPI_SteamNetworkingIPAddr_GetIPv4(SteamNetworkingIPAddr* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetIPv6LocalHost")]
    public static extern void SteamAPI_SteamNetworkingIPAddr_SetIPv6LocalHost(SteamNetworkingIPAddr* self, [NativeTypeName("uint16")] ushort nPort);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsLocalHost")]
    public static extern byte SteamAPI_SteamNetworkingIPAddr_IsLocalHost(SteamNetworkingIPAddr* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ToString")]
    public static extern void SteamAPI_SteamNetworkingIPAddr_ToString(SteamNetworkingIPAddr* self, [NativeTypeName("char *")] sbyte* buf, [NativeTypeName("uint32")] uint cbBuf, [NativeTypeName("bool")] byte bWithPort);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ParseString")]
    public static extern byte SteamAPI_SteamNetworkingIPAddr_ParseString(SteamNetworkingIPAddr* self, [NativeTypeName("const char *")] sbyte* pszStr);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsEqualTo")]
    public static extern byte SteamAPI_SteamNetworkingIPAddr_IsEqualTo(SteamNetworkingIPAddr* self, [NativeTypeName("const SteamNetworkingIPAddr &")] SteamNetworkingIPAddr* x);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFakeIPType")]
    public static extern ESteamNetworkingFakeIPType SteamAPI_SteamNetworkingIPAddr_GetFakeIPType(SteamNetworkingIPAddr* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsFakeIP")]
    public static extern byte SteamAPI_SteamNetworkingIPAddr_IsFakeIP(SteamNetworkingIPAddr* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("Clear")]
    public static extern void SteamAPI_SteamNetworkingIdentity_Clear(SteamNetworkingIdentity* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsInvalid")]
    public static extern byte SteamAPI_SteamNetworkingIdentity_IsInvalid(SteamNetworkingIdentity* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetSteamID")]
    public static extern void SteamAPI_SteamNetworkingIdentity_SetSteamID(SteamNetworkingIdentity* self, [NativeTypeName("uint64_steamid")] CSteamID steamID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_steamid")]
    [GenerateMemberFunction("GetSteamID")]
    public static extern CSteamID SteamAPI_SteamNetworkingIdentity_GetSteamID(SteamNetworkingIdentity* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetSteamID64")]
    public static extern void SteamAPI_SteamNetworkingIdentity_SetSteamID64(SteamNetworkingIdentity* self, [NativeTypeName("uint64")] ulong steamID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64")]
    [GenerateMemberFunction("GetSteamID64")]
    public static extern ulong SteamAPI_SteamNetworkingIdentity_GetSteamID64(SteamNetworkingIdentity* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetXboxPairwiseID")]
    public static extern byte SteamAPI_SteamNetworkingIdentity_SetXboxPairwiseID(SteamNetworkingIdentity* self, [NativeTypeName("const char *")] sbyte* pszString);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetXboxPairwiseID")]
    public static extern sbyte* SteamAPI_SteamNetworkingIdentity_GetXboxPairwiseID(SteamNetworkingIdentity* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetPSNID")]
    public static extern void SteamAPI_SteamNetworkingIdentity_SetPSNID(SteamNetworkingIdentity* self, [NativeTypeName("uint64")] ulong id);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64")]
    [GenerateMemberFunction("GetPSNID")]
    public static extern ulong SteamAPI_SteamNetworkingIdentity_GetPSNID(SteamNetworkingIdentity* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetStadiaID")]
    public static extern void SteamAPI_SteamNetworkingIdentity_SetStadiaID(SteamNetworkingIdentity* self, [NativeTypeName("uint64")] ulong id);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64")]
    [GenerateMemberFunction("GetStadiaID")]
    public static extern ulong SteamAPI_SteamNetworkingIdentity_GetStadiaID(SteamNetworkingIdentity* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetIPAddr")]
    public static extern void SteamAPI_SteamNetworkingIdentity_SetIPAddr(SteamNetworkingIdentity* self, [NativeTypeName("const SteamNetworkingIPAddr &")] SteamNetworkingIPAddr* addr);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const SteamNetworkingIPAddr *")]
    [GenerateMemberFunction("GetIPAddr")]
    public static extern SteamNetworkingIPAddr* SteamAPI_SteamNetworkingIdentity_GetIPAddr(SteamNetworkingIdentity* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetIPv4Addr")]
    public static extern void SteamAPI_SteamNetworkingIdentity_SetIPv4Addr(SteamNetworkingIdentity* self, [NativeTypeName("uint32")] uint nIPv4, [NativeTypeName("uint16")] ushort nPort);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32")]
    [GenerateMemberFunction("GetIPv4")]
    public static extern uint SteamAPI_SteamNetworkingIdentity_GetIPv4(SteamNetworkingIdentity* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("GetFakeIPType")]
    public static extern ESteamNetworkingFakeIPType SteamAPI_SteamNetworkingIdentity_GetFakeIPType(SteamNetworkingIdentity* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsFakeIP")]
    public static extern byte SteamAPI_SteamNetworkingIdentity_IsFakeIP(SteamNetworkingIdentity* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetLocalHost")]
    public static extern void SteamAPI_SteamNetworkingIdentity_SetLocalHost(SteamNetworkingIdentity* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsLocalHost")]
    public static extern byte SteamAPI_SteamNetworkingIdentity_IsLocalHost(SteamNetworkingIdentity* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetGenericString")]
    public static extern byte SteamAPI_SteamNetworkingIdentity_SetGenericString(SteamNetworkingIdentity* self, [NativeTypeName("const char *")] sbyte* pszString);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    [GenerateMemberFunction("GetGenericString")]
    public static extern sbyte* SteamAPI_SteamNetworkingIdentity_GetGenericString(SteamNetworkingIdentity* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("SetGenericBytes")]
    public static extern byte SteamAPI_SteamNetworkingIdentity_SetGenericBytes(SteamNetworkingIdentity* self, [NativeTypeName("const void *")] void* data, [NativeTypeName("uint32")] uint cbLen);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const uint8 *")]
    [GenerateMemberFunction("GetGenericBytes")]
    public static extern byte* SteamAPI_SteamNetworkingIdentity_GetGenericBytes(SteamNetworkingIdentity* self, [NativeTypeName("int &")] int* cbLen);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("IsEqualTo")]
    public static extern byte SteamAPI_SteamNetworkingIdentity_IsEqualTo(SteamNetworkingIdentity* self, [NativeTypeName("const SteamNetworkingIdentity &")] SteamNetworkingIdentity* x);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("ToString")]
    public static extern void SteamAPI_SteamNetworkingIdentity_ToString(SteamNetworkingIdentity* self, [NativeTypeName("char *")] sbyte* buf, [NativeTypeName("uint32")] uint cbBuf);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    [GenerateMemberFunction("ParseString")]
    public static extern byte SteamAPI_SteamNetworkingIdentity_ParseString(SteamNetworkingIdentity* self, [NativeTypeName("const char *")] sbyte* pszStr);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("Release")]
    public static extern void SteamAPI_SteamNetworkingMessage_t_Release(SteamNetworkingMessage_t* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetInt32")]
    public static extern void SteamAPI_SteamNetworkingConfigValue_t_SetInt32(SteamNetworkingConfigValue_t* self, ESteamNetworkingConfigValue eVal, [NativeTypeName("int32_t")] int data);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetInt64")]
    public static extern void SteamAPI_SteamNetworkingConfigValue_t_SetInt64(SteamNetworkingConfigValue_t* self, ESteamNetworkingConfigValue eVal, [NativeTypeName("int64_t")] long data);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetFloat")]
    public static extern void SteamAPI_SteamNetworkingConfigValue_t_SetFloat(SteamNetworkingConfigValue_t* self, ESteamNetworkingConfigValue eVal, float data);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetPtr")]
    public static extern void SteamAPI_SteamNetworkingConfigValue_t_SetPtr(SteamNetworkingConfigValue_t* self, ESteamNetworkingConfigValue eVal, void* data);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetString")]
    public static extern void SteamAPI_SteamNetworkingConfigValue_t_SetString(SteamNetworkingConfigValue_t* self, ESteamNetworkingConfigValue eVal, [NativeTypeName("const char *")] sbyte* data);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("Clear")]
    public static extern void SteamAPI_SteamDatagramHostedAddress_Clear(SteamDatagramHostedAddress* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SteamNetworkingPOPID")]
    [GenerateMemberFunction("GetPopID")]
    public static extern uint SteamAPI_SteamDatagramHostedAddress_GetPopID(SteamDatagramHostedAddress* self);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [GenerateMemberFunction("SetDevAddress")]
    public static extern void SteamAPI_SteamDatagramHostedAddress_SetDevAddress(SteamDatagramHostedAddress* self, [NativeTypeName("uint32")] uint nIP, [NativeTypeName("uint16")] ushort nPort, [NativeTypeName("SteamNetworkingPOPID")] uint popid);
}
