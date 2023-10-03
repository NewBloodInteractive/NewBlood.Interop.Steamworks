using System;
using static NewBlood.Interop.Steamworks.Steamworks;
using static NewBlood.Interop.Steamworks.EAccountType;
using static NewBlood.Interop.Steamworks.EUniverse;

namespace NewBlood.Interop.Steamworks;

public readonly partial struct CSteamID : IComparable, IComparable<CSteamID>, IEquatable<CSteamID>, IFormattable
{
    public CSteamID()
    {
        m_unAccountID = 0;
        m_EAccountType = (uint)k_EAccountTypeInvalid;
        m_EUniverse = k_EUniverseInvalid;
        m_unAccountInstance = 0;
    }

    public CSteamID(uint unAccountID, EUniverse eUniverse, EAccountType eAccountType)
    {
        m_unAccountID = unAccountID;
        m_EUniverse = eUniverse;
        m_EAccountType = (uint)eAccountType;

        if (eAccountType == k_EAccountTypeClan || eAccountType == k_EAccountTypeGameServer)
            m_unAccountInstance = 0;
        else
            m_unAccountInstance = k_unSteamUserDefaultInstance;
    }

    public CSteamID(uint unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType)
    {
        m_unAccountID = unAccountID;
        m_unAccountInstance = unAccountInstance;
        m_EUniverse = eUniverse;
        m_EAccountType = (uint)eAccountType;
    }

    private uint m_unAccountID
    {
        get => (uint)(Value & 0xFFFFFFFFu);
        init => Value = (Value & ~0xFFFFFFFFu) | value;
    }

    private uint m_unAccountInstance
    {
        get => (uint)((Value >> 32) & 0xFFFFFu);
        init => Value = (Value & ~(0xFFFFFu << 32)) | ((value & 0xFFFFFu) << 32);
    }

    private uint m_EAccountType
    {
        get => (uint)((Value >> 52) & 0xFu);
        init => Value = (Value & ~(0xFu << 52)) | ((value & 0xFu) << 52);
    }

    private EUniverse m_EUniverse
    {
        get => (EUniverse)((Value >> 56) & 0xFFu);
        init => Value = (Value & ~(0xFFu << 56)) | (((uint)value & 0xFFu) << 56);
    }
}
