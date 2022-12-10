using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

internal unsafe ref struct CCallback
{
    //
    // CCallbackBase
    //
    private readonly CCallbackBase.MethodTable* __vftable = s_MethodTable;

    private CCallbackBase.ECallbackFlags m_nCallbackFlags;

    private int m_iCallback;

    //
    // CCallback
    //
    private void* m_pObj;

    private delegate* unmanaged[Cdecl]<void*, void*, void> m_Func;

    private int m_cubSize;

#if !NET5_0_OR_GREATER
    private static readonly CCallbackBase.RunCallbackDelegate s_RunCallback = RunCallback;

    private static readonly CCallbackBase.RunCallResultDelegate s_RunCallResult = RunCallResult;

    private static readonly CCallbackBase.GetCallbackSizeBytesDelegate s_GetCallbackSizeBytes = GetCallbackSizeBytes;
#endif

    private static readonly CCallbackBase.MethodTable* s_MethodTable = AllocateMethodTable();

    private static CCallbackBase.MethodTable* AllocateMethodTable()
    {
        var vtable = (CCallbackBase.MethodTable*)SteamInteropHelpers.AllocateTypeAssociatedMemory(typeof(CCallback), sizeof(CCallbackBase.MethodTable));

    #if NET5_0_OR_GREATER
        vtable->RunCallback          = &RunCallback;
        vtable->RunCallResult        = &RunCallResult;
        vtable->GetCallbackSizeBytes = &GetCallbackSizeBytes;
    #else
        *(void**)&vtable->RunCallback          = (void*)Marshal.GetFunctionPointerForDelegate(s_RunCallback);
        *(void**)&vtable->RunCallResult        = (void*)Marshal.GetFunctionPointerForDelegate(s_RunCallResult);
        *(void**)&vtable->GetCallbackSizeBytes = (void*)Marshal.GetFunctionPointerForDelegate(s_GetCallbackSizeBytes);
    #endif

        return vtable;
    }

#if NET5_0_OR_GREATER
    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvThiscall) })]
#else
    [MonoPInvokeCallback(typeof(CCallbackBase.RunCallbackDelegate))]
#endif
    private static void RunCallback(CCallbackBase* self, void* pvParam)
    {
        ((CCallback*)self)->m_Func(((CCallback*)self)->m_pObj, pvParam);
    }

#if NET5_0_OR_GREATER
    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvThiscall) })]
#else
    [MonoPInvokeCallback(typeof(CCallbackBase.RunCallResultDelegate))]
#endif
    private static void RunCallResult(CCallbackBase* self, void* pvParam, byte bIOFailure, ulong hSteamAPICall)
    {
        ((CCallback*)self)->m_Func(((CCallback*)self)->m_pObj,pvParam);
    }

#if NET5_0_OR_GREATER
    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvThiscall) })]
#else
    [MonoPInvokeCallback(typeof(CCallbackBase.GetCallbackSizeBytesDelegate))]
#endif
    private static int GetCallbackSizeBytes(CCallbackBase* self)
    {
        return ((CCallback*)self)->m_cubSize;
    }

    public CCallback(int iCallback, int cubLength)
    {
        m_iCallback = iCallback;
        m_cubSize   = cubLength;
    }

    public void Register(void* pObj, delegate* unmanaged[Cdecl]<void*, void*, void> func, int iCallback)
    {
        if ((m_nCallbackFlags & CCallbackBase.ECallbackFlags.Registered) != 0)
            Unregister();

        m_pObj = pObj;
        m_Func = func;

        fixed (CCallback* self = &this)
        {
            SteamAPI_RegisterCallback((CCallbackBase*)self, iCallback);
        }
    }

    public void Unregister()
    {
        fixed (CCallback* self = &this)
        {
            SteamAPI_UnregisterCallback((CCallbackBase*)self);
        }
    }

    public int GetICallback()
    {
        return m_iCallback;
    }

    public void SetGameserverFlag()
    {
        m_nCallbackFlags |= CCallbackBase.ECallbackFlags.GameServer;
    }

    public void Dispose()
    {
        if ((m_nCallbackFlags & CCallbackBase.ECallbackFlags.Registered) != 0)
        {
            Unregister();
        }
    }
}
