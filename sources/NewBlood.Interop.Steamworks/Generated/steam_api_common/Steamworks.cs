using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const int")]
    public const int k_cchMaxSteamErrMsg = 1024;

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamAPI_RunCallbacks();

    [DllImport("steam_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamGameServer_RunCallbacks();
}
