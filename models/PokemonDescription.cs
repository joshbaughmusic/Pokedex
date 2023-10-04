using System.Text.Json.Serialization;

public class PokemonDescription
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("flavor_text_entries")]
    public List<FlavorTextEntry> FlavorTextEntries { get; set; }
}