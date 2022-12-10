namespace NewBlood.Interop.Steamworks;

public unsafe ref struct CCallResult<T>
    where T : unmanaged, ISteamCallback
{
    private CCallResult m_Callback;

    public CCallResult()
    {
        m_Callback = new(SteamInteropHelpers.GetCallbackId<T>(), sizeof(T));
    }

    public int GetICallback()
    {
        return m_Callback.GetICallback();
    }

    public void SetGameserverFlag()
    {
        m_Callback.SetGameserverFlag();
    }

    public void Cancel()
    {
        m_Callback.Cancel();
    }

    public bool IsActive()
    {
        return m_Callback.IsActive();
    }

    public void Set(SteamAPICall_t hAPICall, void* pObj, delegate* unmanaged[Cdecl]<void*, void*, byte, void> func)
    {
        m_Callback.Set(hAPICall, pObj, func);
    }

    internal void Dispose()
    {
        m_Callback.Dispose();
    }
}
