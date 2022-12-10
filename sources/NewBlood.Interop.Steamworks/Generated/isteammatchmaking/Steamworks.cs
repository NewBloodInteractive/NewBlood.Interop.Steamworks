namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const uint32")]
    public const uint k_unFavoriteFlagNone = 0x00;

    [NativeTypeName("const uint32")]
    public const uint k_unFavoriteFlagFavorite = 0x01;

    [NativeTypeName("const uint32")]
    public const uint k_unFavoriteFlagHistory = 0x02;
}
