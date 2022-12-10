using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

public unsafe sealed class CCallbackHandle<T> : CCallbackHandle
    where T : unmanaged, ISteamCallback
{
    private CCallbackDelegate<T>? _delegate;

    public new CCallback<T>* Handle => (CCallback<T>*)base.Handle;

    public CCallbackHandle(bool bGameserver)
        : base(SafeCallbackHandle.Alloc<T>())
    {
        if (bGameserver)
        {
            SetGameserverFlag();
        }
    }

    public CCallbackHandle(CCallbackDelegate<T> func, bool bGameserver)
        : this(bGameserver)
    {
        Register(func);
    }

    public CCallbackHandle()
        : this(bGameserver: false)
    {
    }

    public CCallbackHandle(CCallbackDelegate<T> func)
        : this(func, bGameserver: false)
    {
        Register(func);
    }

    public void Register(void* pObj, delegate* unmanaged[Cdecl]<void*, void*, void> func)
    {
        ThrowIfDisposed();

        if (_gcHandle.IsAllocated)
            _gcHandle.Target = this;
        else
            _gcHandle = GCHandle.Alloc(this);

        _handle->Register(pObj, func, SteamInteropHelpers.GetCallbackId<T>());
        _delegate = null;
    }

    public void Register(CCallbackDelegate<T> func)
    {
        ThrowIfDisposed();

        if (_gcHandle.IsAllocated)
            _gcHandle.Target = this;
        else
            _gcHandle = GCHandle.Alloc(this);

        _delegate = func;
        _handle->Register((void*)(nint)_gcHandle, s_Invoke, SteamInteropHelpers.GetCallbackId<T>());
    }

    public void Unregister()
    {
        ThrowIfDisposed();
        _handle->Unregister();

        if (_gcHandle.IsAllocated)
        {
            _gcHandle.Target = null;
        }
    }

    private protected override unsafe void OnInvoke(void* pvParam)
    {
        _delegate?.Invoke((T*)pvParam);
    }
}
