namespace NewBlood.Interop.Steamworks;

public unsafe partial struct SteamPS3Params_t
{
    [NativeTypeName("uint32")]
    public uint m_unVersion;

    public void* pReserved;

    [NativeTypeName("uint32")]
    public uint m_nAppId;

    [NativeTypeName("char[1055]")]
    public fixed sbyte m_rgchInstallationPath[1055];

    [NativeTypeName("char[1055]")]
    public fixed sbyte m_rgchSystemCache[1055];

    [NativeTypeName("char[1055]")]
    public fixed sbyte m_rgchGameData[1055];

    [NativeTypeName("char[32]")]
    public fixed sbyte m_rgchNpServiceID[32];

    [NativeTypeName("char[10]")]
    public fixed sbyte m_rgchNpCommunicationID[10];

    [NativeTypeName("char[160]")]
    public fixed sbyte m_rgchNpCommunicationSig[160];

    [NativeTypeName("char[64]")]
    public fixed sbyte m_rgchSteamLanguage[64];

    [NativeTypeName("char[16]")]
    public fixed sbyte m_rgchRegionCode[16];

    [NativeTypeName("unsigned int")]
    public uint m_cSteamInputTTY;

    [NativeTypeName("struct Ps3netInit_t")]
    public Ps3netInit_t m_sysNetInitInfo;

    [NativeTypeName("struct Ps3jpgInit_t")]
    public Ps3jpgInit_t m_sysJpgInitInfo;

    [NativeTypeName("struct Ps3pngInit_t")]
    public Ps3pngInit_t m_sysPngInitInfo;

    [NativeTypeName("struct Ps3sysutilUserInfo_t")]
    public Ps3sysutilUserInfo_t m_sysSysUtilUserInfo;

    [NativeTypeName("bool")]
    public byte m_bIncludeNewsPage;

    public unsafe partial struct Ps3netInit_t
    {
        [NativeTypeName("bool")]
        public byte m_bNeedInit;

        public void* m_pMemory;

        public int m_nMemorySize;

        public int m_flags;
    }

    public partial struct Ps3jpgInit_t
    {
        [NativeTypeName("bool")]
        public byte m_bNeedInit;
    }

    public partial struct Ps3pngInit_t
    {
        [NativeTypeName("bool")]
        public byte m_bNeedInit;
    }

    public partial struct Ps3sysutilUserInfo_t
    {
        [NativeTypeName("bool")]
        public byte m_bNeedInit;
    }
}
