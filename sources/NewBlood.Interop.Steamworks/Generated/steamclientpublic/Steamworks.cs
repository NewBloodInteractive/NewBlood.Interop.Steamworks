using static NewBlood.Interop.Steamworks.EAccountType;
using static NewBlood.Interop.Steamworks.EUniverse;

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

    [NativeTypeName("#define k_steamIDNil CSteamID()")]
    public static readonly CSteamID k_steamIDNil = new CSteamID();

    [NativeTypeName("#define k_steamIDOutofDateGS CSteamID( 0, 0, k_EUniverseInvalid, k_EAccountTypeInvalid )")]
    public static readonly CSteamID k_steamIDOutofDateGS = new CSteamID(0, 0, k_EUniverseInvalid, k_EAccountTypeInvalid);

    [NativeTypeName("#define k_steamIDLanModeGS CSteamID( 0, 0, k_EUniversePublic, k_EAccountTypeInvalid )")]
    public static readonly CSteamID k_steamIDLanModeGS = new CSteamID(0, 0, k_EUniversePublic, k_EAccountTypeInvalid);

    [NativeTypeName("#define k_steamIDNotInitYetGS CSteamID( 1, 0, k_EUniverseInvalid, k_EAccountTypeInvalid )")]
    public static readonly CSteamID k_steamIDNotInitYetGS = new CSteamID(1, 0, k_EUniverseInvalid, k_EAccountTypeInvalid);

    [NativeTypeName("#define k_steamIDNonSteamGS CSteamID( 2, 0, k_EUniverseInvalid, k_EAccountTypeInvalid )")]
    public static readonly CSteamID k_steamIDNonSteamGS = new CSteamID(2, 0, k_EUniverseInvalid, k_EAccountTypeInvalid);
}
