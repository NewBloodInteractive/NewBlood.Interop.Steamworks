namespace NewBlood.Interop.Steamworks;

public unsafe partial struct MatchMakingKeyValuePair_t
{
    [NativeTypeName("char[256]")]
    public fixed sbyte m_szKey[256];

    [NativeTypeName("char[256]")]
    public fixed sbyte m_szValue[256];
}
