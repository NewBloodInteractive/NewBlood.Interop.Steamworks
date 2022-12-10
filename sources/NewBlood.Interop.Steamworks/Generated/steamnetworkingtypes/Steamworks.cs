namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const HSteamNetConnection")]
    public const uint k_HSteamNetConnection_Invalid = 0;

    [NativeTypeName("const HSteamListenSocket")]
    public const uint k_HSteamListenSocket_Invalid = 0;

    [NativeTypeName("const HSteamNetPollGroup")]
    public const uint k_HSteamNetPollGroup_Invalid = 0;

    [NativeTypeName("const int")]
    public const int k_cchMaxSteamNetworkingErrMsg = 1024;

    [NativeTypeName("const int")]
    public const int k_cchSteamNetworkingMaxConnectionCloseReason = 128;

    [NativeTypeName("const int")]
    public const int k_cchSteamNetworkingMaxConnectionDescription = 128;

    [NativeTypeName("const int")]
    public const int k_cchSteamNetworkingMaxConnectionAppName = 32;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkConnectionInfoFlags_Unauthenticated = 1;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkConnectionInfoFlags_Unencrypted = 2;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkConnectionInfoFlags_LoopbackBuffers = 4;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkConnectionInfoFlags_Fast = 8;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkConnectionInfoFlags_Relayed = 16;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkConnectionInfoFlags_DualWifi = 32;

    [NativeTypeName("const int")]
    public const int k_cbMaxSteamNetworkingSocketsMessageSizeSend = 512 * 1024;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkingSend_Unreliable = 0;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkingSend_NoNagle = 1;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkingSend_UnreliableNoNagle = k_nSteamNetworkingSend_Unreliable | k_nSteamNetworkingSend_NoNagle;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkingSend_NoDelay = 4;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkingSend_UnreliableNoDelay = k_nSteamNetworkingSend_Unreliable | k_nSteamNetworkingSend_NoDelay | k_nSteamNetworkingSend_NoNagle;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkingSend_Reliable = 8;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkingSend_ReliableNoNagle = k_nSteamNetworkingSend_Reliable | k_nSteamNetworkingSend_NoNagle;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkingSend_UseCurrentThread = 16;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkingSend_AutoRestartBrokenSession = 32;

    [NativeTypeName("const int")]
    public const int k_cchMaxSteamNetworkingPingLocationString = 1024;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkingPing_Failed = -1;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkingPing_Unknown = -2;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Default = -1;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Disable = 0;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Relay = 1;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Private = 2;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Public = 4;

    [NativeTypeName("const int")]
    public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_All = 0x7fffffff;
}
