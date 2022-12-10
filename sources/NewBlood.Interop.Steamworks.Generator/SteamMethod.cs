using System.Text.Json.Serialization;

namespace NewBlood.Interop.Steamworks.Generator;

public sealed class SteamMethod
{
    [JsonPropertyName("methodname")]
    public required string Name { get; init; }

    [JsonPropertyName("methodname_flat")]
    public required string FlatName { get; init; }

    [JsonPropertyName("params")]
    public required SteamMethodParameter[] Parameters { get; init; }

    [JsonPropertyName("returntype")]
    public required string ReturnType { get; init; }

    [JsonPropertyName("returntype_flat")]
    public string? FlatReturnType { get; init; }

    [JsonPropertyName("callresult")]
    public string? CallResult { get; init; }

    [JsonPropertyName("callback")]
    public string? Callback { get; init; }
}
