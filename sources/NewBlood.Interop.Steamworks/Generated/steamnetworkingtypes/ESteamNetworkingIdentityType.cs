namespace NewBlood.Interop.Steamworks;

public enum ESteamNetworkingIdentityType
{
    k_ESteamNetworkingIdentityType_Invalid = 0,
    k_ESteamNetworkingIdentityType_SteamID = 16,
    k_ESteamNetworkingIdentityType_XboxPairwiseID = 17,
    k_ESteamNetworkingIdentityType_SonyPSN = 18,
    k_ESteamNetworkingIdentityType_GoogleStadia = 19,
    k_ESteamNetworkingIdentityType_IPAddress = 1,
    k_ESteamNetworkingIdentityType_GenericString = 2,
    k_ESteamNetworkingIdentityType_GenericBytes = 3,
    k_ESteamNetworkingIdentityType_UnknownType = 4,
    k_ESteamNetworkingIdentityType__Force32bit = 0x7fffffff,
}
