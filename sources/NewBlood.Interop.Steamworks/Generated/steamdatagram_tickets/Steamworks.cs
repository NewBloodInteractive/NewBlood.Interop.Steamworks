namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const size_t")]
    public const nuint k_cbSteamDatagramMaxSerializedTicket = 512;

    [NativeTypeName("const size_t")]
    public const nuint k_cbMaxSteamDatagramGameCoordinatorServerLoginAppData = 2048;

    [NativeTypeName("const size_t")]
    public const nuint k_cbMaxSteamDatagramGameCoordinatorServerLoginSerialized = 4096;
}
