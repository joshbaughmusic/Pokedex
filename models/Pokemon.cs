using System.Text.Json.Serialization;

public class Pokemon
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("types")]
    public List<TypeSlot> Types { get; set; }
    [JsonPropertyName("sprites")]
    public Sprite Sprite { get; set; }
}