using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

public unsafe abstract class CCallbackHandle : IDisposable
{
    private bool _disposed;

    private protected GCHandle _gcHandle;

    private protected readonly CCallback* _handle;

    private protected readonly SafeCallbackHandle _safeHandle;

#if NET5_0_OR_GREATER
    private protected static readonly delegate* unmanaged[Cdecl]<void*, void*, void> s_Invoke = &Invoke;
#else
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private protected delegate void InvokeDelegate(void* pObj, void* pvParam);

    private static readonly InvokeDelegate s_InvokeDelegate = Invoke;

    private protected static readonly delegate* unmanaged[Cdecl]<void*, void*, void> s_Invoke = (delegate* unmanaged[Cdecl]<void*, void*, void>)Marshal.GetFunctionPointerForDelegate(s_InvokeDelegate);
#endif

    private protected abstract void OnInvoke(void* pvParam);

    private protected CCallbackHandle(SafeCallbackHandle handle)
    {
        _safeHandle = handle;
        _handle     = (CCallback*)handle.DangerousGetHandle();
        SteamInteropHelpers.RegisterCallbackHandle(this);
    }

    public SafeHandle SafeHandle
    {
        get
        {
            ThrowIfDisposed();
            return _safeHandle;
        }
    }

    public CCallbackBase* Handle
    {
        get
        {
            ThrowIfDisposed();
            return (CCallbackBase*)_handle;
        }
    }

    public int GetICallback()
    {
        ThrowIfDisposed();
        return _handle->GetICallback();
    }

    public void SetGameserverFlag()
    {
        ThrowIfDisposed();
        _handle->SetGameserverFlag();
    }

    public void Dispose()
    {
        if (_disposed)
            return;

        _disposed = true;
        _safeHandle.Dispose();

        if (_gcHandle.IsAllocated)
            _gcHandle.Free();

        SteamInteropHelpers.UnregisterCallbackHandle(this);
    }

    private protected void ThrowIfDisposed()
    {
        if (_disposed)
        {
            throw new ObjectDisposedException(GetType().FullName);
        }
    }

#if NET5_0_OR_GREATER
    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
#else
    [MonoPInvokeCallback(typeof(InvokeDelegate))]
#endif
    private protected static void Invoke(void* pObj, void* pvParam)
    {
        var obj = (CCallbackHandle?)GCHandle.FromIntPtr((nint)pObj).Target;

        if (obj is null)
            return;

        obj.OnInvoke(pvParam);
    }
}
