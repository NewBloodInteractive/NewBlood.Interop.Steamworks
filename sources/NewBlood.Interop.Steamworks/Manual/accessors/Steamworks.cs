namespace NewBlood.Interop.Steamworks;

public static unsafe partial class Steamworks
{
    public static ISteamClient* SteamClient()
    {
        return (ISteamClient*)SteamInternal_ContextInit(ISteamClient.CallbackCounterAndContext);
    }

    public static ISteamClient* SteamGameServerClient()
    {
        return SteamClient();
    }
}
