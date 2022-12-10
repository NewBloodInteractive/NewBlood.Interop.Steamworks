using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct FriendsEnumerateFollowingList_t
{
    public EResult m_eResult;

    [NativeTypeName("CSteamID[50]")]
    public _m_rgSteamID_e__FixedBuffer m_rgSteamID;

    [NativeTypeName("int32")]
    public int m_nResultsReturned;

    [NativeTypeName("int32")]
    public int m_nTotalResultCount;

    public const int k_iCallback = k_iSteamFriendsCallbacks + 46;

    public partial struct _m_rgSteamID_e__FixedBuffer
    {
        public CSteamID e0;
        public CSteamID e1;
        public CSteamID e2;
        public CSteamID e3;
        public CSteamID e4;
        public CSteamID e5;
        public CSteamID e6;
        public CSteamID e7;
        public CSteamID e8;
        public CSteamID e9;
        public CSteamID e10;
        public CSteamID e11;
        public CSteamID e12;
        public CSteamID e13;
        public CSteamID e14;
        public CSteamID e15;
        public CSteamID e16;
        public CSteamID e17;
        public CSteamID e18;
        public CSteamID e19;
        public CSteamID e20;
        public CSteamID e21;
        public CSteamID e22;
        public CSteamID e23;
        public CSteamID e24;
        public CSteamID e25;
        public CSteamID e26;
        public CSteamID e27;
        public CSteamID e28;
        public CSteamID e29;
        public CSteamID e30;
        public CSteamID e31;
        public CSteamID e32;
        public CSteamID e33;
        public CSteamID e34;
        public CSteamID e35;
        public CSteamID e36;
        public CSteamID e37;
        public CSteamID e38;
        public CSteamID e39;
        public CSteamID e40;
        public CSteamID e41;
        public CSteamID e42;
        public CSteamID e43;
        public CSteamID e44;
        public CSteamID e45;
        public CSteamID e46;
        public CSteamID e47;
        public CSteamID e48;
        public CSteamID e49;

        [UnscopedRef]
        public ref CSteamID this[int index]
        {
            get
            {
                return ref AsSpan()[index];
            }
        }

        [UnscopedRef]
        public Span<CSteamID> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 50);
    }
}
