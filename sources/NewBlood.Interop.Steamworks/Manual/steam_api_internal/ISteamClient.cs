using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using static NewBlood.Interop.Steamworks.Steamworks;

namespace NewBlood.Interop.Steamworks;

public unsafe ref partial struct ISteamClient
{
#if !NET5_0_OR_GREATER
    private static readonly ContextInitData.ContextCallbackDelegate s_Callback = ContextCallback;
#endif

    internal static readonly ContextInitData* CallbackCounterAndContext = AllocContext();

    private static ContextInitData* AllocContext()
    {
        var context = (ContextInitData*)SteamInteropHelpers.AllocateTypeAssociatedMemory(typeof(ISteamClient), sizeof(ContextInitData));

    #if NET5_0_OR_GREATER
        context->Callback = &ContextCallback;
    #else
        *(void**)&context->Callback = (void*)Marshal.GetFunctionPointerForDelegate(s_Callback);
    #endif

        return context;
    }

#if NET5_0_OR_GREATER
    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
#else
    [MonoPInvokeCallback(typeof(ContextInitData.ContextCallbackDelegate))]
#endif
    private static void ContextCallback(void* pCtx)
    {
        fixed (byte* pVer = "SteamClient020"u8)
        {
            *(void**)pCtx = SteamInternal_CreateInterface((sbyte*)pVer);
        }
    }
}
