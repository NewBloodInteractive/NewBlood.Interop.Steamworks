using System.Text.Json.Serialization;

namespace NewBlood.Interop.Steamworks.Generator;

public sealed class SteamCallbackStruct
{
    [JsonPropertyName("callback_id")]
    public required int Id { get; init; }

    [JsonPropertyName("fields")]
    public required SteamField[] Fields { get; init; }

    [JsonPropertyName("enums")]
    public SteamEnum[]? Enums { get; init; }

    [JsonPropertyName("struct")]
    public required string Name { get; init; }
}
