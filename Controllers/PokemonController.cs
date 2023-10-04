using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace pokedex_v2.Controllers;

[ApiController]
[Route("[controller]")]
public class PokemonController : ControllerBase
{
    [HttpGet]
    public async Task<AllPokemon> GetAllPokemon()
    {
        var uri = "https://pokeapi.co/api/v2/pokemon?limit=1008";
        var client = new HttpClient();

        // Set request header to accept JSON
        client.DefaultRequestHeaders
            .Accept
            .Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        var response = await client.GetAsync(uri);

        var json = await response.Content.ReadAsStreamAsync();
        var pokemon = await JsonSerializer.DeserializeAsync<AllPokemon>(json);

        return pokemon;

    }
    [HttpGet("{id}")]
    public async Task<Pokemon> GetSinglePokemon(string id)
    {
        int pokeId;
        if (int.TryParse(id, out pokeId))
        {

            var uri = $"https://pokeapi.co/api/v2/pokemon/{pokeId}";
            var client = new HttpClient();

            // Set request header to accept JSON
            client.DefaultRequestHeaders
                .Accept
                .Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync(uri);

            var json = await response.Content.ReadAsStreamAsync();
            var pokemon = await JsonSerializer.DeserializeAsync<Pokemon>(json);

            return pokemon;
        }
        else
        {
            var uri = $"https://pokeapi.co/api/v2/pokemon/{id}";
            var client = new HttpClient();

            // Set request header to accept JSON
            client.DefaultRequestHeaders
                .Accept
                .Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync(uri);

            var json = await response.Content.ReadAsStreamAsync();
            var pokemon = await JsonSerializer.DeserializeAsync<Pokemon>(json);

            return pokemon;
        }

    }
    [HttpGet("description/{id}")]
    public async Task<PokemonDescription> GetSinglePokemonDescription(string id)
    {
        int pokeId;
        if (int.TryParse(id, out pokeId))
        {

            var uri = $"https://pokeapi.co/api/v2/pokemon-species/{pokeId}";
            var client = new HttpClient();

            // Set request header to accept JSON
            client.DefaultRequestHeaders
                .Accept
                .Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync(uri);

            var json = await response.Content.ReadAsStreamAsync();
            var pokemon = await JsonSerializer.DeserializeAsync<PokemonDescription>(json);

            return pokemon;
        }
        else
        {
            var uri = $"https://pokeapi.co/api/v2/pokemon-species/{id}";
            var client = new HttpClient();

            // Set request header to accept JSON
            client.DefaultRequestHeaders
                .Accept
                .Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync(uri);

            var json = await response.Content.ReadAsStreamAsync();
            var pokemon = await JsonSerializer.DeserializeAsync<PokemonDescription>(json);

            return pokemon;
        }

    }
}
