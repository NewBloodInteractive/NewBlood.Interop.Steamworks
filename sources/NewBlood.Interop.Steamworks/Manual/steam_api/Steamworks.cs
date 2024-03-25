namespace NewBlood.Interop.Steamworks;

public static unsafe partial class Steamworks
{
    public static byte SteamAPI_Init()
    {
        return SteamAPI_InitFlat(null) == ESteamAPIInitResult.k_ESteamAPIInitResult_OK ? (byte)1 : (byte)0;
    }

    public static ESteamAPIInitResult SteamAPI_InitEx(sbyte** pOutErrMsg)
    {
        return SteamAPI_InitFlat(pOutErrMsg);
    }
}
