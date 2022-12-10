using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public unsafe partial struct SteamParamStringArray_t
{
    [NativeTypeName("const char **")]
    public sbyte** m_ppStrings;

    [NativeTypeName("int32")]
    public int m_nNumStrings;
}
