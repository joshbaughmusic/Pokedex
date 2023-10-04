using System.Text.Json.Serialization;

public class PokemonMinimal
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("url")]
    public string Url { get; set; }
}