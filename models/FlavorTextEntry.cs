using System.Text.Json.Serialization;

public class FlavorTextEntry
{
    [JsonPropertyName("flavor_text")]
    public string FlavorText { get; set; }
}