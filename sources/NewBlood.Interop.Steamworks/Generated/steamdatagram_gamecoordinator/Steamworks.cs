using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

public static unsafe partial class Steamworks
{
    [DllImport("steamdatagram_gamecoordinator", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamDatagram_GameCoordinator_Init([NativeTypeName("bool")] byte bInsecureDevMode, [NativeTypeName("FSteamNetworkingSocketsDebugOutput")] delegate* unmanaged[Cdecl]<ESteamNetworkingSocketsDebugOutputType, sbyte*, void> fnDebugOutput);

    [DllImport("steamdatagram_gamecoordinator", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SteamDatagram_GameCoordinator_GetNetworkConfigURL(AppId_t nAppID);

    [DllImport("steamdatagram_gamecoordinator", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamDatagram_GameCoordinator_SetNetworkConfig([NativeTypeName("const void *")] void* pData, [NativeTypeName("size_t")] nuint cbData, [NativeTypeName("SteamNetworkingErrMsg &")] sbyte** errMsg);

    [DllImport("steamdatagram_gamecoordinator", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamDatagram_SetPrivateKey_Ed25519(void* pvPrivateKey, [NativeTypeName("size_t")] nuint cbPrivateKey, [NativeTypeName("SteamNetworkingErrMsg &")] sbyte** errMsg);

    [DllImport("steamdatagram_gamecoordinator", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamDatagram_SerializeAndSignTicket([NativeTypeName("const SteamDatagramRelayAuthTicket &")] SteamDatagramRelayAuthTicket* ticket, [NativeTypeName("SteamDatagramSignedBlob &")] SteamDatagramSignedBlob* outBlob, [NativeTypeName("SteamNetworkingErrMsg &")] sbyte** errMsg);

    [DllImport("steamdatagram_gamecoordinator", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamDatagram_CreateCert([NativeTypeName("const SteamNetworkingIdentity &")] SteamNetworkingIdentity* identity, [NativeTypeName("uint32")] uint nAppID, [NativeTypeName("const void *")] void* pRequest, [NativeTypeName("size_t")] nuint cbRequest, [NativeTypeName("SteamDatagramSignedBlob &")] SteamDatagramSignedBlob* outBlob, [NativeTypeName("SteamNetworkingErrMsg &")] sbyte** errMsg);

    [DllImport("steamdatagram_gamecoordinator", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamDatagram_ParseHostedServerLogin([NativeTypeName("const void *")] void* pvBlob, [NativeTypeName("size_t")] nuint cbBlob, [NativeTypeName("SteamDatagramGameCoordinatorServerLogin &")] SteamDatagramGameCoordinatorServerLogin* outLogin, [NativeTypeName("bool")] byte bAllowInsecureLoginToDevPOP, [NativeTypeName("SteamNetworkingErrMsg &")] sbyte** errMsg);

    [DllImport("steamdatagram_gamecoordinator", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamDatagram_ParsePingLocation([NativeTypeName("const char *")] sbyte* pszString, [NativeTypeName("SteamNetworkPingLocation_t &")] SteamNetworkPingLocation_t* outLocation);

    [DllImport("steamdatagram_gamecoordinator", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int SteamDatagram_EstimatePingBetweenTwoLocations([NativeTypeName("const SteamNetworkPingLocation_t &")] SteamNetworkPingLocation_t* location1, [NativeTypeName("const SteamNetworkPingLocation_t &")] SteamNetworkPingLocation_t* location2);

    [DllImport("steamdatagram_gamecoordinator", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamDatagram_GameCoordinator_SetUniverse(EUniverse eUniverse);
}
