using System;
using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

public unsafe ref partial struct CCallbackBase
{
    private readonly MethodTable* __vftable;

    private ECallbackFlags m_nCallbackFlags;

    private int m_iCallback;

    internal struct MethodTable
    {
        // The MSVC ABI stores overloaded functions grouped in reverse declaration order in the vtable.
        // Both of these methods are called "Run" in the C++ header, so the ABI discrepancy applies here.
    #if WINDOWS
        public delegate* unmanaged[Thiscall]<CCallbackBase*, void*, byte, ulong, void> RunCallResult;
        public delegate* unmanaged[Thiscall]<CCallbackBase*, void*, void> RunCallback;
    #else
        public delegate* unmanaged[Thiscall]<CCallbackBase*, void*, void> RunCallback;
        public delegate* unmanaged[Thiscall]<CCallbackBase*, void*, byte, ulong, void> RunCallResult;
    #endif
        public delegate* unmanaged[Thiscall]<CCallbackBase*, int> GetCallbackSizeBytes;
    }

#if !NET5_0_OR_GREATER
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    internal delegate void RunCallbackDelegate(CCallbackBase* self, void* pvParam);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    internal delegate void RunCallResultDelegate(CCallbackBase* self, void* pvParam, byte bIOFailure, ulong hSteamAPICall);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    internal delegate int GetCallbackSizeBytesDelegate(CCallbackBase* self);
#endif

    [Flags]
    internal enum ECallbackFlags : byte
    {
        None       = 0,
        Registered = 1 << 0,
        GameServer = 1 << 1,
    }

    public int GetICallback()
    {
        return m_iCallback;
    }

    public void Run(void* pvParam)
    {
        fixed (CCallbackBase* self = &this)
        {
            __vftable->RunCallback(self, pvParam);
        }
    }

    public void Run(void* pvParam, byte bIOFailure, SteamAPICall_t hSteamAPICall)
    {
        fixed (CCallbackBase* self = &this)
        {
            __vftable->RunCallResult(self, pvParam, bIOFailure, hSteamAPICall);
        }
    }

    public int GetCallbackSizeBytes()
    {
        fixed (CCallbackBase* self = &this)
        {
            return __vftable->GetCallbackSizeBytes(self);
        }
    }
}
