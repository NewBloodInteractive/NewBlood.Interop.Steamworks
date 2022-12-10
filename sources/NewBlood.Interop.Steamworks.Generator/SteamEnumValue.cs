using System.Text.Json.Serialization;

namespace NewBlood.Interop.Steamworks.Generator;

public sealed class SteamEnumValue
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("value")]
    public required string Value { get; init; }
}
