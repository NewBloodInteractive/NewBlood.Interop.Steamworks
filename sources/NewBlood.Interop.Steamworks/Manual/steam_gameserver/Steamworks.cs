namespace NewBlood.Interop.Steamworks;

public static unsafe partial class Steamworks
{
    public static byte SteamGameServer_Init(uint unIP, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, sbyte* pchVersionString)
    {
        return SteamGameServer_InitEx(unIP, usGamePort, usQueryPort, eServerMode, pchVersionString, null) == ESteamAPIInitResult.k_ESteamAPIInitResult_OK ? (byte)1 : (byte)0;
    }

    public static ESteamAPIInitResult SteamGameServer_InitEx(uint unIP, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, sbyte* pchVersionString, sbyte** pOutErrMsg)
    {
        fixed (byte* pszInternalCheckInterfaceVersions = STEAMAPI_GAMESERVER_INITEX_INTERFACES)
        {
            return SteamInternal_GameServer_Init_V2(unIP, usGamePort, usQueryPort, eServerMode, pchVersionString, (sbyte*)pszInternalCheckInterfaceVersions, pOutErrMsg);
        }
    }

    public static void SteamGameServer_ReleaseCurrentThreadMemory()
    {
        SteamAPI_ReleaseCurrentThreadMemory();
    }
}
