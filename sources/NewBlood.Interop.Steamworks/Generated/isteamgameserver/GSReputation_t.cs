using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct GSReputation_t
{
    public EResult m_eResult;

    [NativeTypeName("uint32")]
    public uint m_unReputationScore;

    [NativeTypeName("bool")]
    public byte m_bBanned;

    [NativeTypeName("uint32")]
    public uint m_unBannedIP;

    [NativeTypeName("uint16")]
    public ushort m_usBannedPort;

    [NativeTypeName("uint64")]
    public ulong m_ulBannedGameID;

    [NativeTypeName("uint32")]
    public uint m_unBanExpires;

    public const int k_iCallback = k_iSteamGameServerCallbacks + 9;
}
