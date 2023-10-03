using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

public static unsafe partial class Steamworks
{
    [NativeTypeName("const uint16")]
    public const ushort STEAMGAMESERVER_QUERY_PORT_SHARED = 0xffff;

    [NativeTypeName("const uint16")]
    public const ushort MASTERSERVERUPDATERPORT_USEGAMESOCKETSHARE = STEAMGAMESERVER_QUERY_PORT_SHARED;

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamGameServer_Shutdown();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamGameServer_BSecure();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64")]
    public static extern ulong SteamGameServer_GetSteamID();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ESteamAPIInitResult SteamInternal_GameServer_Init_V2([NativeTypeName("uint32")] uint unIP, [NativeTypeName("uint16")] ushort usGamePort, [NativeTypeName("uint16")] ushort usQueryPort, EServerMode eServerMode, [NativeTypeName("const char *")] sbyte* pchVersionString, [NativeTypeName("const char *")] sbyte* pszInternalCheckInterfaceVersions, [NativeTypeName("SteamErrMsg *")] sbyte** pOutErrMsg);
}
