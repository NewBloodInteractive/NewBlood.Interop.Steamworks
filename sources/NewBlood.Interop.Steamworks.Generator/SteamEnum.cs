using System.Text.Json.Serialization;

namespace NewBlood.Interop.Steamworks.Generator;

public sealed class SteamEnum
{
    [JsonPropertyName("enumname")]
    public required string Name { get; init; }

    [JsonPropertyName("fqname")]
    public string? FullName { get; init; }

    [JsonPropertyName("values")]
    public required SteamEnumValue[] Values { get; init; }
}
