using System.Text.Json.Serialization;

namespace NewBlood.Interop.Steamworks.Generator;

public sealed class SteamTypeDef
{
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("typedef")]
    public required string Name { get; init; }
}
