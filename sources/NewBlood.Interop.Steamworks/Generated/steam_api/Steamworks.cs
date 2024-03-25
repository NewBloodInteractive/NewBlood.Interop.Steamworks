using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

public static unsafe partial class Steamworks
{
    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ESteamAPIInitResult SteamAPI_InitFlat([NativeTypeName("SteamErrMsg *")] sbyte** pOutErrMsg);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamAPI_Shutdown();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamAPI_RestartAppIfNecessary([NativeTypeName("uint32")] uint unOwnAppID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamAPI_ReleaseCurrentThreadMemory();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamAPI_WriteMiniDump([NativeTypeName("uint32")] uint uStructuredExceptionCode, void* pvExceptionInfo, [NativeTypeName("uint32")] uint uBuildID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamAPI_SetMiniDumpComment([NativeTypeName("const char *")] sbyte* pchMsg);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamAPI_IsSteamRunning();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SteamAPI_GetSteamInstallPath();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamAPI_SetTryCatchCallbacks([NativeTypeName("bool")] byte bTryCatchCallbacks);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamAPI_InitSafe();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamAPI_UseBreakpadCrashHandler([NativeTypeName("const char *")] sbyte* pchVersion, [NativeTypeName("const char *")] sbyte* pchDate, [NativeTypeName("const char *")] sbyte* pchTime, [NativeTypeName("bool")] byte bFullMemoryDumps, void* pvContext, [NativeTypeName("PFNPreMinidumpCallback")] delegate* unmanaged[Cdecl]<void*, void> m_pfnPreMinidumpCallback);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamAPI_SetBreakpadAppID([NativeTypeName("uint32")] uint unAppID);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamAPI_ManualDispatch_Init();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamAPI_ManualDispatch_RunFrame(HSteamPipe hSteamPipe);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe hSteamPipe, CallbackMsg_t* pCallbackMsg);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe hSteamPipe);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamAPI_ManualDispatch_GetAPICallResult(HSteamPipe hSteamPipe, SteamAPICall_t hSteamAPICall, void* pCallback, int cubCallback, int iCallbackExpected, bool* pbFailed);

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ESteamAPIInitResult SteamInternal_SteamAPI_Init([NativeTypeName("const char *")] sbyte* pszInternalCheckInterfaceVersions, [NativeTypeName("SteamErrMsg *")] sbyte** pOutErrMsg);
}
