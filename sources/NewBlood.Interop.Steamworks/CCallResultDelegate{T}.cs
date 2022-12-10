namespace NewBlood.Interop.Steamworks;

public unsafe delegate void CCallResultDelegate<T>(T* pCallback, bool bIOFailure)
    where T : unmanaged, ISteamCallback;
