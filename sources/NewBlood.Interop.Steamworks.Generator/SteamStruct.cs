using System.Text.Json.Serialization;

namespace NewBlood.Interop.Steamworks.Generator;

public sealed class SteamStruct
{
    [JsonPropertyName("consts")]
    public SteamConstant[]? Constants { get; init; }

    [JsonPropertyName("fields")]
    public required SteamField[] Fields { get; init; }

    [JsonPropertyName("methods")]
    public SteamMethod[]? Methods { get; init; }

    [JsonPropertyName("struct")]
    public required string Name { get; init; }
}
