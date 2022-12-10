namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const AppId_t")]
    public const uint k_uAppIdInvalid = 0x0;

    [NativeTypeName("const DepotId_t")]
    public const uint k_uDepotIdInvalid = 0x0;

    [NativeTypeName("const SteamAPICall_t")]
    public const ulong k_uAPICallInvalid = 0x0;

    [NativeTypeName("const PartyBeaconID_t")]
    public const ulong k_ulPartyBeaconIdInvalid = 0;
}
