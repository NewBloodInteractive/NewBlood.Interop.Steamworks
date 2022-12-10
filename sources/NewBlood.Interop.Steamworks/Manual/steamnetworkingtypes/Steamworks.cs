namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const SteamNetworkingPOPID")]
    public const uint k_SteamDatagramPOPID_dev = ((uint)'d' << 16) | ((uint)'e' << 8) | 'v';
}
