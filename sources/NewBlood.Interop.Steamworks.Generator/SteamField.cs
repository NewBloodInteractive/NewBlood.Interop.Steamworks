using System.Text.Json.Serialization;

namespace NewBlood.Interop.Steamworks.Generator;

public sealed class SteamField
{
    [JsonPropertyName("fieldname")]
    public required string Name { get; init; }

    [JsonPropertyName("fieldtype")]
    public required string Type { get; init; }
}
