using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = PrivateInteropDetails.SteamCallbackPacking)]
public partial struct SteamItemDetails_t
{
    public SteamItemInstanceID_t m_itemId;

    public SteamItemDef_t m_iDefinition;

    [NativeTypeName("uint16")]
    public ushort m_unQuantity;

    [NativeTypeName("uint16")]
    public ushort m_unFlags;
}
