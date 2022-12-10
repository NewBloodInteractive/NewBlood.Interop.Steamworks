namespace NewBlood.Interop.Steamworks;

public partial struct servernetadr_t
{
    [NativeTypeName("uint16")]
    private ushort m_usConnectionPort;

    [NativeTypeName("uint16")]
    private ushort m_usQueryPort;

    [NativeTypeName("uint32")]
    private uint m_unIP;
}
