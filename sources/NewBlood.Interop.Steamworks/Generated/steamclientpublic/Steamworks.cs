namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const HAuthTicket")]
    public const uint k_HAuthTicketInvalid = 0;

    [NativeTypeName("const unsigned int")]
    public const uint k_unSteamAccountIDMask = 0xFFFFFFFF;

    [NativeTypeName("const unsigned int")]
    public const uint k_unSteamAccountInstanceMask = 0x000FFFFF;

    [NativeTypeName("const unsigned int")]
    public const uint k_unSteamUserDefaultInstance = 1;

    [NativeTypeName("const int")]
    public const int k_cchGameExtraInfoMax = 64;
}
