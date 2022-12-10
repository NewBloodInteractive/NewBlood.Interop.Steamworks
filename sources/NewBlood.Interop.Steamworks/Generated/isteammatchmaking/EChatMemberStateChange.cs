using System;

namespace NewBlood.Interop.Steamworks;

[Flags]
public enum EChatMemberStateChange
{
    k_EChatMemberStateChangeEntered = 0x0001,
    k_EChatMemberStateChangeLeft = 0x0002,
    k_EChatMemberStateChangeDisconnected = 0x0004,
    k_EChatMemberStateChangeKicked = 0x0008,
    k_EChatMemberStateChangeBanned = 0x0010,
}
