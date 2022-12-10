namespace NewBlood.Interop.Steamworks;

public unsafe partial struct SteamDatagramSignedBlob
{
    public int m_sz;

    [NativeTypeName("uint8[2048]")]
    public fixed byte m_blob[2048];
}
