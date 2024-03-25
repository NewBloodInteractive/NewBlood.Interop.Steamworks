using System;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const int")]
    public const int k_cchMaxFriendsGroupName = 64;

    [NativeTypeName("const int")]
    public const int k_cFriendsGroupLimit = 100;

    [NativeTypeName("const FriendsGroupID_t")]
    public const short k_FriendsGroupID_Invalid = -1;

    [NativeTypeName("const int")]
    public const int k_cEnumerateFollowersMax = 50;

    [NativeTypeName("const uint16")]
    public const ushort k_usFriendGameInfoQueryPort_NotInitialized = 0xFFFF;

    [NativeTypeName("const uint16")]
    public const ushort k_usFriendGameInfoQueryPort_Error = 0xFFFE;

    public const int k_cchPersonaNameMax = 128;
    public const int k_cwchPersonaNameMax = 32;

    [NativeTypeName("const uint32")]
    public const uint k_cubChatMetadataMax = 8192;

    public const int k_cchMaxRichPresenceKeys = 30;

    public const int k_cchMaxRichPresenceKeyLength = 64;

    public const int k_cchMaxRichPresenceValueLength = 256;

    [NativeTypeName("#define STEAMFRIENDS_INTERFACE_VERSION \"SteamFriends017\"")]
    public static ReadOnlySpan<byte> STEAMFRIENDS_INTERFACE_VERSION => "SteamFriends017"u8;
}
