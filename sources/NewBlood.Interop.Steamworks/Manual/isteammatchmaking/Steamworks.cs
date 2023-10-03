using static NewBlood.Interop.Steamworks.EChatMemberStateChange;

namespace NewBlood.Interop.Steamworks;

public static partial class Steamworks
{
    [NativeTypeName("const int")]
    public const int HSERVERQUERY_INVALID = unchecked((int)0xFFFFFFFF);

    public static byte BChatMemberStateChangeRemoved(EChatMemberStateChange rgfChatMemberStateChangeFlags)
    {
        return (rgfChatMemberStateChangeFlags & (k_EChatMemberStateChangeDisconnected | k_EChatMemberStateChangeLeft | k_EChatMemberStateChangeKicked | k_EChatMemberStateChangeBanned)) != 0 ? (byte)1 : (byte)0;
    }
}
