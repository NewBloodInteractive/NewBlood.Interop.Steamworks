using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SteamIPAddress_t
{
    [NativeTypeName("__AnonymousRecord_steamtypes_L117_C2")]
    public _Anonymous_e__Union Anonymous;

    public ESteamIPType m_eType;

    [UnscopedRef]
    public ref uint m_unIPv4
    {
        get
        {
            return ref Anonymous.m_unIPv4;
        }
    }

    [UnscopedRef]
    public Span<byte> m_rgubIPv6
    {
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.m_rgubIPv6[0], 16);
        }
    }

    [UnscopedRef]
    public Span<ulong> m_ipv6Qword
    {
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.m_ipv6Qword[0], 2);
        }
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("uint32")]
        public uint m_unIPv4;

        [FieldOffset(0)]
        [NativeTypeName("uint8[16]")]
        public fixed byte m_rgubIPv6[16];

        [FieldOffset(0)]
        [NativeTypeName("uint64[2]")]
        public fixed ulong m_ipv6Qword[2];
    }
}
