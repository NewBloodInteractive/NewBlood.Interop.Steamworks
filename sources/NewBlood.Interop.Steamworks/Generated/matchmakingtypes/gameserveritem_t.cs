namespace NewBlood.Interop.Steamworks;

public unsafe partial struct gameserveritem_t
{
    public servernetadr_t m_NetAdr;

    public int m_nPing;

    [NativeTypeName("bool")]
    public byte m_bHadSuccessfulResponse;

    [NativeTypeName("bool")]
    public byte m_bDoNotRefresh;

    [NativeTypeName("char[32]")]
    public fixed sbyte m_szGameDir[32];

    [NativeTypeName("char[32]")]
    public fixed sbyte m_szMap[32];

    [NativeTypeName("char[64]")]
    public fixed sbyte m_szGameDescription[64];

    [NativeTypeName("uint32")]
    public uint m_nAppID;

    public int m_nPlayers;

    public int m_nMaxPlayers;

    public int m_nBotPlayers;

    [NativeTypeName("bool")]
    public byte m_bPassword;

    [NativeTypeName("bool")]
    public byte m_bSecure;

    [NativeTypeName("uint32")]
    public uint m_ulTimeLastPlayed;

    public int m_nServerVersion;

    [NativeTypeName("char[64]")]
    private fixed sbyte m_szServerName[64];

    [NativeTypeName("char[128]")]
    public fixed sbyte m_szGameTags[128];

    public CSteamID m_steamID;
}
