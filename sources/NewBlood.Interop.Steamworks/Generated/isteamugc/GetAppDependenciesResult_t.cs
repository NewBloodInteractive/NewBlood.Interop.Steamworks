using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct GetAppDependenciesResult_t
{
    public EResult m_eResult;

    public PublishedFileId_t m_nPublishedFileId;

    [NativeTypeName("AppId_t[32]")]
    public _m_rgAppIDs_e__FixedBuffer m_rgAppIDs;

    [NativeTypeName("uint32")]
    public uint m_nNumAppDependencies;

    [NativeTypeName("uint32")]
    public uint m_nTotalNumAppDependencies;

    public const int k_iCallback = k_iSteamUGCCallbacks + 16;

    public partial struct _m_rgAppIDs_e__FixedBuffer
    {
        public AppId_t e0;
        public AppId_t e1;
        public AppId_t e2;
        public AppId_t e3;
        public AppId_t e4;
        public AppId_t e5;
        public AppId_t e6;
        public AppId_t e7;
        public AppId_t e8;
        public AppId_t e9;
        public AppId_t e10;
        public AppId_t e11;
        public AppId_t e12;
        public AppId_t e13;
        public AppId_t e14;
        public AppId_t e15;
        public AppId_t e16;
        public AppId_t e17;
        public AppId_t e18;
        public AppId_t e19;
        public AppId_t e20;
        public AppId_t e21;
        public AppId_t e22;
        public AppId_t e23;
        public AppId_t e24;
        public AppId_t e25;
        public AppId_t e26;
        public AppId_t e27;
        public AppId_t e28;
        public AppId_t e29;
        public AppId_t e30;
        public AppId_t e31;

        [UnscopedRef]
        public ref AppId_t this[int index]
        {
            get
            {
                return ref AsSpan()[index];
            }
        }

        [UnscopedRef]
        public Span<AppId_t> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 32);
    }
}
