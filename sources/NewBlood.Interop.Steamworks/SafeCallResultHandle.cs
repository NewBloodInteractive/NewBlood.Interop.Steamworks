using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace NewBlood.Interop.Steamworks;

internal sealed class SafeCallResultHandle : SafeHandleZeroOrMinusOneIsInvalid
{
    private SafeCallResultHandle()
        : base(ownsHandle: true)
    {
    }

    protected unsafe override bool ReleaseHandle()
    {
        ((CCallResult*)handle)->Dispose();
    #if NET6_0_OR_GREATER
        NativeMemory.Free((void*)handle);
    #else
        Marshal.FreeHGlobal(handle);
    #endif
        return true;
    }

    public static unsafe SafeCallResultHandle Alloc<T>()
        where T : unmanaged, ISteamCallback
    {
        var handle = new SafeCallResultHandle();
    #if NET6_0_OR_GREATER
        var memory = (nint)NativeMemory.Alloc((uint)sizeof(CCallResult<T>));
    #else
        var memory = Marshal.AllocHGlobal(sizeof(CCallResult<T>));
    #endif
        *(CCallResult<T>*)memory = new();
        handle.SetHandle(memory);
        return handle;
    }
}
