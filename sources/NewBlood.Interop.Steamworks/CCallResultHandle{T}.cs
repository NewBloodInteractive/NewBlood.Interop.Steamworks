using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

public unsafe sealed class CCallResultHandle<T> : CCallResultHandle
    where T : unmanaged, ISteamCallback
{
    private CCallResultDelegate<T>? _delegate;

    public new CCallResult<T>* Handle => (CCallResult<T>*)base.Handle;

    public CCallResultHandle(bool bGameserver)
        : base(SafeCallResultHandle.Alloc<T>())
    {
        if (bGameserver)
        {
            SetGameserverFlag();
        }
    }

    public CCallResultHandle()
        : this(bGameserver: false)
    {
    }

    public void Set(SteamAPICall_t hAPICall, void* pObj, delegate* unmanaged[Cdecl]<void*, void*, byte, void> func)
    {
        ThrowIfDisposed();

        if (_gcHandle.IsAllocated)
            _gcHandle.Target = this;
        else
            _gcHandle = GCHandle.Alloc(this);

        _handle->Set(hAPICall, pObj, func);
        _delegate = null;
    }

    public void Set(SteamAPICall_t hAPICall, CCallResultDelegate<T> func)
    {
        ThrowIfDisposed();

        if (_gcHandle.IsAllocated)
            _gcHandle.Target = this;
        else
            _gcHandle = GCHandle.Alloc(this);

        _delegate = func;
        _handle->Set(hAPICall, (void*)(nint)_gcHandle, s_Invoke);
    }

    private protected override unsafe void OnInvoke(void* pvParam, byte bIOFailure)
    {
        _delegate?.Invoke((T*)pvParam, bIOFailure != 0);
    }
}
