using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

public static unsafe partial class Steamworks
{
    [NativeTypeName("const int")]
    public const int k_nSteamEncryptedAppTicketSymmetricKeyLen = 32;

    [DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamEncryptedAppTicket_BDecryptTicket([NativeTypeName("const uint8 *")] byte* rgubTicketEncrypted, [NativeTypeName("uint32")] uint cubTicketEncrypted, [NativeTypeName("uint8 *")] byte* rgubTicketDecrypted, [NativeTypeName("uint32 *")] uint* pcubTicketDecrypted, [NativeTypeName("const uint8[32]")] byte* rgubKey, int cubKey);

    [DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamEncryptedAppTicket_BIsTicketForApp([NativeTypeName("uint8 *")] byte* rgubTicketDecrypted, [NativeTypeName("uint32")] uint cubTicketDecrypted, AppId_t nAppID);

    [DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("RTime32")]
    public static extern uint SteamEncryptedAppTicket_GetTicketIssueTime([NativeTypeName("uint8 *")] byte* rgubTicketDecrypted, [NativeTypeName("uint32")] uint cubTicketDecrypted);

    [DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SteamEncryptedAppTicket_GetTicketSteamID([NativeTypeName("uint8 *")] byte* rgubTicketDecrypted, [NativeTypeName("uint32")] uint cubTicketDecrypted, CSteamID* psteamID);

    [DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern AppId_t SteamEncryptedAppTicket_GetTicketAppID([NativeTypeName("uint8 *")] byte* rgubTicketDecrypted, [NativeTypeName("uint32")] uint cubTicketDecrypted);

    [DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamEncryptedAppTicket_BUserOwnsAppInTicket([NativeTypeName("uint8 *")] byte* rgubTicketDecrypted, [NativeTypeName("uint32")] uint cubTicketDecrypted, AppId_t nAppID);

    [DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamEncryptedAppTicket_BUserIsVacBanned([NativeTypeName("uint8 *")] byte* rgubTicketDecrypted, [NativeTypeName("uint32")] uint cubTicketDecrypted);

    [DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamEncryptedAppTicket_BGetAppDefinedValue([NativeTypeName("uint8 *")] byte* rgubTicketDecrypted, [NativeTypeName("uint32")] uint cubTicketDecrypted, [NativeTypeName("uint32 *")] uint* pValue);

    [DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const uint8 *")]
    public static extern byte* SteamEncryptedAppTicket_GetUserVariableData([NativeTypeName("uint8 *")] byte* rgubTicketDecrypted, [NativeTypeName("uint32")] uint cubTicketDecrypted, [NativeTypeName("uint32 *")] uint* pcubUserData);

    [DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamEncryptedAppTicket_BIsTicketSigned([NativeTypeName("uint8 *")] byte* rgubTicketDecrypted, [NativeTypeName("uint32")] uint cubTicketDecrypted, [NativeTypeName("const uint8 *")] byte* pubRSAKey, [NativeTypeName("uint32")] uint cubRSAKey);

    [DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamEncryptedAppTicket_BIsLicenseBorrowed([NativeTypeName("uint8 *")] byte* rgubTicketDecrypted, [NativeTypeName("uint32")] uint cubTicketDecrypted);

    [DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte SteamEncryptedAppTicket_BIsLicenseTemporary([NativeTypeName("uint8 *")] byte* rgubTicketDecrypted, [NativeTypeName("uint32")] uint cubTicketDecrypted);
}
