using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SteamNetworkingIPAddr
{
    [NativeTypeName("__AnonymousRecord_steamnetworkingtypes_L238_C2")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("uint16")]
    public ushort m_port;

    [UnscopedRef]
    public Span<byte> m_ipv6
    {
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.m_ipv6[0], 16);
        }
    }

    [UnscopedRef]
    public ref IPv4MappedAddress m_ipv4
    {
        get
        {
            return ref Anonymous.m_ipv4;
        }
    }

    public const int k_cchMaxString = 48;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct IPv4MappedAddress
    {
        [NativeTypeName("uint64")]
        public ulong m_8zeros;

        [NativeTypeName("uint16")]
        public ushort m_0000;

        [NativeTypeName("uint16")]
        public ushort m_ffff;

        [NativeTypeName("uint8[4]")]
        public fixed byte m_ip[4];
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("uint8[16]")]
        public fixed byte m_ipv6[16];

        [FieldOffset(0)]
        [NativeTypeName("SteamNetworkingIPAddr::IPv4MappedAddress")]
        public IPv4MappedAddress m_ipv4;
    }
}
