using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SteamDatagramRelayAuthTicket
{
    public SteamNetworkingIdentity m_identityGameserver;

    public SteamNetworkingIdentity m_identityAuthorizedClient;

    [NativeTypeName("uint32")]
    public uint m_unPublicIP;

    [NativeTypeName("RTime32")]
    public uint m_rtimeTicketExpiry;

    public SteamDatagramHostedAddress m_routing;

    [NativeTypeName("uint32")]
    public uint m_nAppID;

    public int m_nRestrictToVirtualPort;

    public int m_nExtraFields;

    [NativeTypeName("SteamDatagramRelayAuthTicket::ExtraField[16]")]
    public _m_vecExtraFields_e__FixedBuffer m_vecExtraFields;

    public unsafe partial struct ExtraField
    {
        public int m_eType;

        [NativeTypeName("char[28]")]
        public fixed sbyte m_szName[28];

        [NativeTypeName("SteamDatagramRelayAuthTicket::ExtraField::(anonymous union at ../../sdk/include/steam/steamdatagram_tickets.h:186:3)")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public Span<sbyte> m_szStringValue
        {
            get
            {
                return MemoryMarshal.CreateSpan(ref Anonymous.m_szStringValue[0], 128);
            }
        }

        [UnscopedRef]
        public ref long m_nIntValue
        {
            get
            {
                return ref Anonymous.m_nIntValue;
            }
        }

        [UnscopedRef]
        public ref ulong m_nFixed64Value
        {
            get
            {
                return ref Anonymous.m_nFixed64Value;
            }
        }

        public enum EType
        {
            k_EType_String,
            k_EType_Int,
            k_EType_Fixed64,
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("char[128]")]
            public fixed sbyte m_szStringValue[128];

            [FieldOffset(0)]
            [NativeTypeName("int64")]
            public long m_nIntValue;

            [FieldOffset(0)]
            [NativeTypeName("uint64")]
            public ulong m_nFixed64Value;
        }
    }

    public const int k_nMaxExtraFields = 16;

    public partial struct _m_vecExtraFields_e__FixedBuffer
    {
        public ExtraField e0;
        public ExtraField e1;
        public ExtraField e2;
        public ExtraField e3;
        public ExtraField e4;
        public ExtraField e5;
        public ExtraField e6;
        public ExtraField e7;
        public ExtraField e8;
        public ExtraField e9;
        public ExtraField e10;
        public ExtraField e11;
        public ExtraField e12;
        public ExtraField e13;
        public ExtraField e14;
        public ExtraField e15;

        [UnscopedRef]
        public ref ExtraField this[int index]
        {
            get
            {
                return ref AsSpan()[index];
            }
        }

        [UnscopedRef]
        public Span<ExtraField> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
    }
}
