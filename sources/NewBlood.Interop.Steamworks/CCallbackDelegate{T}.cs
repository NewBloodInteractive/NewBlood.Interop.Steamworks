namespace NewBlood.Interop.Steamworks;

public unsafe delegate void CCallbackDelegate<T>(T* pCallback)
    where T : unmanaged, ISteamCallback;
