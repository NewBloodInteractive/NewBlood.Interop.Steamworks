using System;

namespace NewBlood.Interop.Steamworks;

[Flags]
public enum EFriendFlags
{
    k_EFriendFlagNone = 0x00,
    k_EFriendFlagBlocked = 0x01,
    k_EFriendFlagFriendshipRequested = 0x02,
    k_EFriendFlagImmediate = 0x04,
    k_EFriendFlagClanMember = 0x08,
    k_EFriendFlagOnGameServer = 0x10,
    k_EFriendFlagRequestingFriendship = 0x80,
    k_EFriendFlagRequestingInfo = 0x100,
    k_EFriendFlagIgnored = 0x200,
    k_EFriendFlagIgnoredFriend = 0x400,
    k_EFriendFlagChatMember = 0x1000,
    k_EFriendFlagAll = 0xFFFF,
}
