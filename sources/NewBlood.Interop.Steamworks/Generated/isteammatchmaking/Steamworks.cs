using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const uint32")]
    public const uint k_unFavoriteFlagNone = 0x00;

    [NativeTypeName("const uint32")]
    public const uint k_unFavoriteFlagFavorite = 0x01;

    [NativeTypeName("const uint32")]
    public const uint k_unFavoriteFlagHistory = 0x02;

    [NativeTypeName("#define k_nMaxLobbyKeyLength 255")]
    public const int k_nMaxLobbyKeyLength = 255;

    [NativeTypeName("#define STEAMMATCHMAKING_INTERFACE_VERSION \"SteamMatchMaking009\"")]
    public static ReadOnlySpan<byte> STEAMMATCHMAKING_INTERFACE_VERSION => "SteamMatchMaking009"u8;

    [NativeTypeName("#define STEAMMATCHMAKINGSERVERS_INTERFACE_VERSION \"SteamMatchMakingServers002\"")]
    public static ReadOnlySpan<byte> STEAMMATCHMAKINGSERVERS_INTERFACE_VERSION => "SteamMatchMakingServers002"u8;

    [NativeTypeName("#define STEAMGAMESEARCH_INTERFACE_VERSION \"SteamMatchGameSearch001\"")]
    public static ReadOnlySpan<byte> STEAMGAMESEARCH_INTERFACE_VERSION => "SteamMatchGameSearch001"u8;

    [NativeTypeName("#define STEAMPARTIES_INTERFACE_VERSION \"SteamParties002\"")]
    public static ReadOnlySpan<byte> STEAMPARTIES_INTERFACE_VERSION => "SteamParties002"u8;
}
