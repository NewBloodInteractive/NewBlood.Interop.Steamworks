using System;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[Flags]
public enum EChatSteamIDInstanceFlags
{
    k_EChatAccountInstanceMask = 0x00000FFF,
    k_EChatInstanceFlagClan = unchecked((int)(k_unSteamAccountInstanceMask + 1)) >> 1,
    k_EChatInstanceFlagLobby = unchecked((int)(k_unSteamAccountInstanceMask + 1)) >> 2,
    k_EChatInstanceFlagMMSLobby = unchecked((int)(k_unSteamAccountInstanceMask + 1)) >> 3,
}
