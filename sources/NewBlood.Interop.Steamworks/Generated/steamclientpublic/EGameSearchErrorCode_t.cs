namespace NewBlood.Interop.Steamworks;

public enum EGameSearchErrorCode_t
{
    k_EGameSearchErrorCode_OK = 1,
    k_EGameSearchErrorCode_Failed_Search_Already_In_Progress = 2,
    k_EGameSearchErrorCode_Failed_No_Search_In_Progress = 3,
    k_EGameSearchErrorCode_Failed_Not_Lobby_Leader = 4,
    k_EGameSearchErrorCode_Failed_No_Host_Available = 5,
    k_EGameSearchErrorCode_Failed_Search_Params_Invalid = 6,
    k_EGameSearchErrorCode_Failed_Offline = 7,
    k_EGameSearchErrorCode_Failed_NotAuthorized = 8,
    k_EGameSearchErrorCode_Failed_Unknown_Error = 9,
}
