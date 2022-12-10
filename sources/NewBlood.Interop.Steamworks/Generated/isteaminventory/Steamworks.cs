namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const SteamInventoryResult_t")]
    public const int k_SteamInventoryResultInvalid = -1;

    [NativeTypeName("const SteamInventoryUpdateHandle_t")]
    public const ulong k_SteamInventoryUpdateHandleInvalid = 0xffffffffffffffffUL;
}
