using System.Text.Json.Serialization;

namespace NewBlood.Interop.Steamworks.Generator;

public sealed class SteamInterface
{
    [JsonPropertyName("classname")]
    public required string Name { get; init; }

    [JsonPropertyName("fields")]
    public required SteamField[] Fields { get; init; }

    [JsonPropertyName("methods")]
    public required SteamMethod[] Methods { get; init; }

    [JsonPropertyName("accessors")]
    public SteamInterfaceAccessor[]? Accessors { get; init; }

    [JsonPropertyName("version_string")]
    public string? Version { get; init; }
}
