using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("#define STEAM_CONTROLLER_MAX_COUNT 16")]
    public const int STEAM_CONTROLLER_MAX_COUNT = 16;

    [NativeTypeName("#define STEAM_CONTROLLER_MAX_ANALOG_ACTIONS 24")]
    public const int STEAM_CONTROLLER_MAX_ANALOG_ACTIONS = 24;

    [NativeTypeName("#define STEAM_CONTROLLER_MAX_DIGITAL_ACTIONS 256")]
    public const int STEAM_CONTROLLER_MAX_DIGITAL_ACTIONS = 256;

    [NativeTypeName("#define STEAM_CONTROLLER_MAX_ORIGINS 8")]
    public const int STEAM_CONTROLLER_MAX_ORIGINS = 8;

    [NativeTypeName("#define STEAM_CONTROLLER_MAX_ACTIVE_LAYERS 16")]
    public const int STEAM_CONTROLLER_MAX_ACTIVE_LAYERS = 16;

    [NativeTypeName("#define STEAM_CONTROLLER_HANDLE_ALL_CONTROLLERS UINT64_MAX")]
    public const ulong STEAM_CONTROLLER_HANDLE_ALL_CONTROLLERS = 0xffffffffffffffffUL;

    [NativeTypeName("#define STEAM_CONTROLLER_MIN_ANALOG_ACTION_DATA -1.0f")]
    public const float STEAM_CONTROLLER_MIN_ANALOG_ACTION_DATA = -1.0f;

    [NativeTypeName("#define STEAM_CONTROLLER_MAX_ANALOG_ACTION_DATA 1.0f")]
    public const float STEAM_CONTROLLER_MAX_ANALOG_ACTION_DATA = 1.0f;

    [NativeTypeName("#define STEAMCONTROLLER_INTERFACE_VERSION \"SteamController008\"")]
    public static ReadOnlySpan<byte> STEAMCONTROLLER_INTERFACE_VERSION => "SteamController008"u8;
}
