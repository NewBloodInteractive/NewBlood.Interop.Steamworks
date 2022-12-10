using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace NewBlood.Interop.Steamworks;

internal sealed class SafeCallbackHandle : SafeHandleZeroOrMinusOneIsInvalid
{
    private SafeCallbackHandle()
        : base(ownsHandle: true)
    {
    }

    protected unsafe override bool ReleaseHandle()
    {
        ((CCallback*)handle)->Dispose();
    #if NET6_0_OR_GREATER
        NativeMemory.Free((void*)handle);
    #else
        Marshal.FreeHGlobal(handle);
    #endif
        return true;
    }

    public static unsafe SafeCallbackHandle Alloc<T>()
        where T : unmanaged, ISteamCallback
    {
        var handle = new SafeCallbackHandle();
    #if NET6_0_OR_GREATER
        var memory = (nint)NativeMemory.Alloc((uint)sizeof(CCallback<T>));
    #else
        var memory = Marshal.AllocHGlobal(sizeof(CCallback<T>));
    #endif
        *(CCallback<T>*)memory = new();
        handle.SetHandle(memory);
        return handle;
    }
}
