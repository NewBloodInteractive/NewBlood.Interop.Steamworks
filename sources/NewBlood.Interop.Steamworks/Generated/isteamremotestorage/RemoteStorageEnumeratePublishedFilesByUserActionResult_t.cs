using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t
{
    public EResult m_eResult;

    public EWorkshopFileAction m_eAction;

    [NativeTypeName("int32")]
    public int m_nResultsReturned;

    [NativeTypeName("int32")]
    public int m_nTotalResultCount;

    [NativeTypeName("PublishedFileId_t[50]")]
    public _m_rgPublishedFileId_e__FixedBuffer m_rgPublishedFileId;

    [NativeTypeName("uint32[50]")]
    public fixed uint m_rgRTimeUpdated[50];

    public const int k_iCallback = k_iSteamRemoteStorageCallbacks + 28;

    public partial struct _m_rgPublishedFileId_e__FixedBuffer
    {
        public PublishedFileId_t e0;
        public PublishedFileId_t e1;
        public PublishedFileId_t e2;
        public PublishedFileId_t e3;
        public PublishedFileId_t e4;
        public PublishedFileId_t e5;
        public PublishedFileId_t e6;
        public PublishedFileId_t e7;
        public PublishedFileId_t e8;
        public PublishedFileId_t e9;
        public PublishedFileId_t e10;
        public PublishedFileId_t e11;
        public PublishedFileId_t e12;
        public PublishedFileId_t e13;
        public PublishedFileId_t e14;
        public PublishedFileId_t e15;
        public PublishedFileId_t e16;
        public PublishedFileId_t e17;
        public PublishedFileId_t e18;
        public PublishedFileId_t e19;
        public PublishedFileId_t e20;
        public PublishedFileId_t e21;
        public PublishedFileId_t e22;
        public PublishedFileId_t e23;
        public PublishedFileId_t e24;
        public PublishedFileId_t e25;
        public PublishedFileId_t e26;
        public PublishedFileId_t e27;
        public PublishedFileId_t e28;
        public PublishedFileId_t e29;
        public PublishedFileId_t e30;
        public PublishedFileId_t e31;
        public PublishedFileId_t e32;
        public PublishedFileId_t e33;
        public PublishedFileId_t e34;
        public PublishedFileId_t e35;
        public PublishedFileId_t e36;
        public PublishedFileId_t e37;
        public PublishedFileId_t e38;
        public PublishedFileId_t e39;
        public PublishedFileId_t e40;
        public PublishedFileId_t e41;
        public PublishedFileId_t e42;
        public PublishedFileId_t e43;
        public PublishedFileId_t e44;
        public PublishedFileId_t e45;
        public PublishedFileId_t e46;
        public PublishedFileId_t e47;
        public PublishedFileId_t e48;
        public PublishedFileId_t e49;

        [UnscopedRef]
        public ref PublishedFileId_t this[int index]
        {
            get
            {
                return ref AsSpan()[index];
            }
        }

        [UnscopedRef]
        public Span<PublishedFileId_t> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 50);
    }
}
