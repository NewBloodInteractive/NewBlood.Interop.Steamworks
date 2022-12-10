using System.Text.Json.Serialization;

namespace NewBlood.Interop.Steamworks.Generator;

public sealed class SteamMethodParameter
{
    [JsonPropertyName("paramname")]
    public required string Name { get; init; }

    [JsonPropertyName("paramtype")]
    public required string Type { get; init; }

    [JsonPropertyName("paramtype_flat")]
    public string? FlatType { get; init; }

    [JsonPropertyName("desc")]
    public string? Description { get; init; }

    [JsonPropertyName("out_array_count")]
    public string? OutArrayCount { get; init; }

    [JsonPropertyName("array_count")]
    public string? ArrayCount { get; init; }
}
