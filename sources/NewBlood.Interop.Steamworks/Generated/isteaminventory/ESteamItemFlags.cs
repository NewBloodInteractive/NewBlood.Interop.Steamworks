using System;

namespace NewBlood.Interop.Steamworks;

[Flags]
public enum ESteamItemFlags
{
    k_ESteamItemNoTrade = 1 << 0,
    k_ESteamItemRemoved = 1 << 8,
    k_ESteamItemConsumed = 1 << 9,
}
