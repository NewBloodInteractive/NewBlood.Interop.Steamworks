using System.Text.Json.Serialization;

namespace NewBlood.Interop.Steamworks.Generator;

public sealed class SteamConstant
{
    [JsonPropertyName("constname")]
    public required string Name { get; init; }

    [JsonPropertyName("consttype")]
    public required string Type { get; init; }

    [JsonPropertyName("constval")]
    public required string Value { get; init; }
}
