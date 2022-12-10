namespace NewBlood.Interop.Steamworks;

public interface ISteamCallback
{
#if NET6_0_OR_GREATER
    internal static abstract int CallbackId { get; }
#else
    internal int CallbackId { get; }
#endif
}
