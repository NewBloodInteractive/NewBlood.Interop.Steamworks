using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace NewBlood.Interop.Steamworks;

internal sealed class SafeNativeMemoryHandle : SafeHandleZeroOrMinusOneIsInvalid
{
    private SafeNativeMemoryHandle()
        : base(ownsHandle: true)
    {
    }

    protected unsafe override bool ReleaseHandle()
    {
    #if NET6_0_OR_GREATER
        NativeMemory.Free((void*)handle);
    #else
        Marshal.FreeHGlobal(handle);
    #endif
        return true;
    }

    public static unsafe SafeNativeMemoryHandle Alloc(int cb)
    {
        var handle = new SafeNativeMemoryHandle();
    #if NET6_0_OR_GREATER
        var memory = (nint)NativeMemory.Alloc((uint)cb);
    #else
        var memory = Marshal.AllocHGlobal(cb);
    #endif
        handle.SetHandle(memory);
        return handle;
    }
}
