using System.Text.Json.Serialization;

namespace NewBlood.Interop.Steamworks.Generator;

public sealed class SteamAPI
{
    [JsonPropertyName("callback_structs")]
    public required SteamCallbackStruct[] CallbackStructs { get; init; }

    [JsonPropertyName("consts")]
    public required SteamConstant[] Constants { get; init; }

    [JsonPropertyName("enums")]
    public required SteamEnum[] Enums { get; init; }

    [JsonPropertyName("interfaces")]
    public required SteamInterface[] Interfaces { get; init; }

    [JsonPropertyName("structs")]
    public required SteamStruct[] Structs { get; init; }

    [JsonPropertyName("typedefs")]
    public required SteamTypeDef[] TypeDefs { get; init; }
}
