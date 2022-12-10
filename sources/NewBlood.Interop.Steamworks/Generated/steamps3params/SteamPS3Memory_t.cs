namespace NewBlood.Interop.Steamworks;

public unsafe partial struct SteamPS3Memory_t
{
    [NativeTypeName("bool")]
    public byte m_bSingleAllocation;

    [NativeTypeName("void *(*)(size_t)")]
    public delegate* unmanaged[Cdecl]<nuint, void*> m_pfMalloc;

    [NativeTypeName("void *(*)(void *, size_t)")]
    public delegate* unmanaged[Cdecl]<void*, nuint, void*> m_pfRealloc;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> m_pfFree;

    [NativeTypeName("size_t (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, nuint> m_pUsable_size;
}
