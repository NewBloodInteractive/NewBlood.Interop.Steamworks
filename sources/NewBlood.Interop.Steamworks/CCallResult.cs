using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

internal unsafe ref struct CCallResult
{
    //
    // CCallbackBase
    //
    private readonly CCallbackBase.MethodTable* __vftable = s_MethodTable;

    private CCallbackBase.ECallbackFlags m_nCallbackFlags;

    private int m_iCallback;

    //
    // CCallResult
    //
    private SteamAPICall_t m_hAPICall;

    private void* m_pObj;

    private delegate* unmanaged[Cdecl]<void*, void*, byte, void> m_Func;

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
        ((CCallResult*)self)->m_hAPICall = k_uAPICallInvalid;
        ((CCallResult*)self)->m_Func(((CCallResult*)self)->m_pObj, pvParam, 0);
    }

#if NET5_0_OR_GREATER
    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvThiscall) })]
#else
    [MonoPInvokeCallback(typeof(CCallbackBase.RunCallResultDelegate))]
#endif
    private static void RunCallResult(CCallbackBase* self, void* pvParam, byte bIOFailure, ulong hSteamAPICall)
    {
        if (hSteamAPICall == ((CCallResult*)self)->m_hAPICall.Value)
        {
            ((CCallResult*)self)->m_hAPICall = k_uAPICallInvalid;
            ((CCallResult*)self)->m_Func(((CCallResult*)self)->m_pObj, pvParam, bIOFailure);
        }
    }

#if NET5_0_OR_GREATER
    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvThiscall) })]
#else
    [MonoPInvokeCallback(typeof(CCallbackBase.GetCallbackSizeBytesDelegate))]
#endif
    private static int GetCallbackSizeBytes(CCallbackBase* self)
    {
        return ((CCallResult*)self)->m_cubSize;
    }

    public CCallResult(int iCallback, int cubLength)
    {
        m_iCallback = iCallback;
        m_cubSize   = cubLength;
    }

    public int GetICallback()
    {
        return m_iCallback;
    }

    public void SetGameserverFlag()
    {
        m_nCallbackFlags |= CCallbackBase.ECallbackFlags.GameServer;
    }

    public bool IsActive()
    {
        return m_hAPICall != k_uAPICallInvalid;
    }

    public void Cancel()
    {
        if (m_hAPICall != k_uAPICallInvalid)
        {
            Unregister();
            m_hAPICall = k_uAPICallInvalid;
        }
    }

    public void Register()
    {
        fixed (CCallResult* self = &this)
        {
            SteamAPI_RegisterCallResult((CCallbackBase*)self, m_hAPICall);
        }
    }

    public void Unregister()
    {
        fixed (CCallResult* self = &this)
        {
            SteamAPI_UnregisterCallResult((CCallbackBase*)self, m_hAPICall);
        }
    }

    public void Set(SteamAPICall_t hAPICall, void* pObj, delegate* unmanaged[Cdecl]<void*, void*, byte, void> func)
    {
        if (m_hAPICall != 0)
        {
            Unregister();
        }

        m_hAPICall = hAPICall;
        m_pObj     = pObj;
        m_Func     = func;

        if (hAPICall != 0)
        {
            Register();
        }
    }

    public void Dispose()
    {
        Cancel();
    }
}
