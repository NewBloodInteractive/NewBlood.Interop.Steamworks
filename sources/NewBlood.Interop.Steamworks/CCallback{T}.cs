namespace NewBlood.Interop.Steamworks;

public unsafe ref struct CCallback<T>
    where T : unmanaged, ISteamCallback
{
    private CCallback m_Callback;

    public CCallback()
    {
        m_Callback = new(SteamInteropHelpers.GetCallbackId<T>(), sizeof(T));
    }

    public void Register(void* pObj, delegate* unmanaged[Cdecl]<void*, void*, void> func)
    {
        m_Callback.Register(pObj, func, SteamInteropHelpers.GetCallbackId<T>());
    }

    public void Unregister()
    {
        m_Callback.Unregister();
    }

    public int GetICallback()
    {
        return m_Callback.GetICallback();
    }

    public void SetGameserverFlag()
    {
        m_Callback.SetGameserverFlag();
    }

    internal void Dispose()
    {
        m_Callback.Dispose();
    }
}
