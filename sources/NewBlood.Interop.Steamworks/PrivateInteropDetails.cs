namespace NewBlood.Interop.Steamworks;

internal static class PrivateInteropDetails
{
#if WINDOWS
    public const int SteamCallbackPacking = 8;
#else
    public const int SteamCallbackPacking = 4;
#endif
}
