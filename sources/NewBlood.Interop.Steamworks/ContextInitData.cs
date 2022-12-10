using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

[StructLayout(LayoutKind.Sequential)]
internal unsafe struct ContextInitData
{
    public delegate* unmanaged[Cdecl]<void*, void> Callback;

    public nuint Counter;

    public void* Context;

#if !NET5_0_OR_GREATER
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ContextCallbackDelegate(void* pCtx);
#endif
}
