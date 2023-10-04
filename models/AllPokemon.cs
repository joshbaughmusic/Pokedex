using System.Text.Json.Serialization;

public class AllPokemon
{
    [JsonPropertyName("results")]
    public List<PokemonMinimal> Results { get; set; }
}