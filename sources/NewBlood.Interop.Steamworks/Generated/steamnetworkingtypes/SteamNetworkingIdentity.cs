using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SteamNetworkingIdentity
{
    public ESteamNetworkingIdentityType m_eType;

    public int m_cbSize;

    [NativeTypeName("__AnonymousRecord_steamnetworkingtypes_L339_C2")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref ulong m_steamID64
    {
        get
        {
            return ref Anonymous.m_steamID64;
        }
    }

    [UnscopedRef]
    public ref ulong m_PSNID
    {
        get
        {
            return ref Anonymous.m_PSNID;
        }
    }

    [UnscopedRef]
    public ref ulong m_stadiaID
    {
        get
        {
            return ref Anonymous.m_stadiaID;
        }
    }

    [UnscopedRef]
    public Span<sbyte> m_szGenericString
    {
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.m_szGenericString[0], 32);
        }
    }

    [UnscopedRef]
    public Span<sbyte> m_szXboxPairwiseID
    {
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.m_szXboxPairwiseID[0], 33);
        }
    }

    [UnscopedRef]
    public Span<byte> m_genericBytes
    {
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.m_genericBytes[0], 32);
        }
    }

    [UnscopedRef]
    public Span<sbyte> m_szUnknownRawString
    {
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.m_szUnknownRawString[0], 128);
        }
    }

    [UnscopedRef]
    public ref SteamNetworkingIPAddr m_ip
    {
        get
        {
            return ref Anonymous.m_ip;
        }
    }

    [UnscopedRef]
    public Span<uint> m_reserved
    {
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.m_reserved[0], 32);
        }
    }

    public const int k_cchMaxString = 128;
    public const int k_cchMaxGenericString = 32;
    public const int k_cchMaxXboxPairwiseID = 33;
    public const int k_cbMaxGenericBytes = 32;

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("uint64")]
        public ulong m_steamID64;

        [FieldOffset(0)]
        [NativeTypeName("uint64")]
        public ulong m_PSNID;

        [FieldOffset(0)]
        [NativeTypeName("uint64")]
        public ulong m_stadiaID;

        [FieldOffset(0)]
        [NativeTypeName("char[32]")]
        public fixed sbyte m_szGenericString[32];

        [FieldOffset(0)]
        [NativeTypeName("char[33]")]
        public fixed sbyte m_szXboxPairwiseID[33];

        [FieldOffset(0)]
        [NativeTypeName("uint8[32]")]
        public fixed byte m_genericBytes[32];

        [FieldOffset(0)]
        [NativeTypeName("char[128]")]
        public fixed sbyte m_szUnknownRawString[128];

        [FieldOffset(0)]
        public SteamNetworkingIPAddr m_ip;

        [FieldOffset(0)]
        [NativeTypeName("uint32[32]")]
        public fixed uint m_reserved[32];
    }
}
