using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NewBlood.Interop.Steamworks;

public static class SteamInteropHelpers
{
    private static readonly ConditionalWeakTable<IDisposable, object?> s_CallbackHandles = new();

#if !NET5_0_OR_GREATER
    private static readonly ConditionalWeakTable<Type, ConcurrentBag<SafeHandle>> s_TypeAssociatedMemory = new();
#endif

    internal static void RegisterCallbackHandle(IDisposable handle)
    {
        s_CallbackHandles.Add(handle, null);
    }

    internal static void UnregisterCallbackHandle(IDisposable handle)
    {
        s_CallbackHandles.Remove(handle);
    }

    internal static IntPtr AllocateTypeAssociatedMemory(Type type, int size)
    {
    #if NET5_0_OR_GREATER
        return RuntimeHelpers.AllocateTypeAssociatedMemory(type, size);
    #else
        var handle = SafeNativeMemoryHandle.Alloc(size);
        s_TypeAssociatedMemory.GetOrCreateValue(type).Add(handle);
        return handle.DangerousGetHandle();
    #endif
    }

    public static void DisposeCallbackHandles()
    {
        foreach (KeyValuePair<IDisposable, object?> pair in s_CallbackHandles)
        {
            // CCallbackHandle.Dispose and CCallResultHandle.Dispose will both make a call
            // to UnregisterCallbackHandle, so we don't need to remove the table entry here.
            pair.Key.Dispose();
        }
    }

    public static unsafe int GetCallbackId<T>()
        where T : unmanaged, ISteamCallback
    {
    #if NET6_0_OR_GREATER
        return T.CallbackId;
    #else
        T temp;
        return (&temp)->CallbackId;
    #endif
    }
}
