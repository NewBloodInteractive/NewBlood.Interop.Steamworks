namespace NewBlood.Interop.Steamworks;

public static unsafe partial class Steamworks
{
    public static byte SteamAPI_Init()
    {
        return SteamAPI_InitEx(null) == ESteamAPIInitResult.k_ESteamAPIInitResult_OK ? (byte)1 : (byte)0;
    }

    public static ESteamAPIInitResult SteamAPI_InitEx(sbyte** pOutErrMsg)
    {
        fixed (byte* pszInternalCheckInterfaceVersions = STEAMAPI_INITEX_INTERFACES)
        {
            return SteamInternal_SteamAPI_Init((sbyte*)pszInternalCheckInterfaceVersions, pOutErrMsg);
        }
    }
}
