using System;

namespace NewBlood.Interop.Steamworks;

[Flags]
public enum ERemoteStoragePlatform
{
    k_ERemoteStoragePlatformNone = 0,
    k_ERemoteStoragePlatformWindows = (1 << 0),
    k_ERemoteStoragePlatformOSX = (1 << 1),
    k_ERemoteStoragePlatformPS3 = (1 << 2),
    k_ERemoteStoragePlatformLinux = (1 << 3),
    k_ERemoteStoragePlatformSwitch = (1 << 4),
    k_ERemoteStoragePlatformAndroid = (1 << 5),
    k_ERemoteStoragePlatformIOS = (1 << 6),
    k_ERemoteStoragePlatformAll = unchecked((int)(0xffffffff)),
}
