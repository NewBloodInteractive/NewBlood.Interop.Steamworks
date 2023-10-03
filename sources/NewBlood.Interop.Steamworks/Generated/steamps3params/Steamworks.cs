namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define STEAM_PS3_PATH_MAX 1055")]
    public const int STEAM_PS3_PATH_MAX = 1055;

    [NativeTypeName("#define STEAM_PS3_SERVICE_ID_MAX 32")]
    public const int STEAM_PS3_SERVICE_ID_MAX = 32;

    [NativeTypeName("#define STEAM_PS3_COMMUNICATION_ID_MAX 10")]
    public const int STEAM_PS3_COMMUNICATION_ID_MAX = 10;

    [NativeTypeName("#define STEAM_PS3_COMMUNICATION_SIG_MAX 160")]
    public const int STEAM_PS3_COMMUNICATION_SIG_MAX = 160;

    [NativeTypeName("#define STEAM_PS3_LANGUAGE_MAX 64")]
    public const int STEAM_PS3_LANGUAGE_MAX = 64;

    [NativeTypeName("#define STEAM_PS3_REGION_CODE_MAX 16")]
    public const int STEAM_PS3_REGION_CODE_MAX = 16;

    [NativeTypeName("#define STEAM_PS3_CURRENT_PARAMS_VER 2")]
    public const int STEAM_PS3_CURRENT_PARAMS_VER = 2;

    [NativeTypeName("#define STEAMPS3_MALLOC_INUSE 0x53D04A51")]
    public const int STEAMPS3_MALLOC_INUSE = 0x53D04A51;

    [NativeTypeName("#define STEAMPS3_MALLOC_SYSTEM 0x0D102C48")]
    public const int STEAMPS3_MALLOC_SYSTEM = 0x0D102C48;

    [NativeTypeName("#define STEAMPS3_MALLOC_OK 0xFFD04A51")]
    public const uint STEAMPS3_MALLOC_OK = 0xFFD04A51;
}
