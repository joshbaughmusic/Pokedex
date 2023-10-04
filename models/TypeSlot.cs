using System.Text.Json.Serialization;

public class TypeSlot
{
    [JsonPropertyName("slot")]
    public int Slot { get; set; }
    [JsonPropertyName("type")]
    public Type Type { get; set; }
    
}