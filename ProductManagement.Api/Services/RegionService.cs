using ProductManagement.Api.Models;
using System.Text.Json;

public class RegionService
{
    private readonly HttpClient _httpClient;

    public RegionService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://api-colombia.com/");
    }

    public async Task<List<Region>> GetRegiones()
    {
        var response = await _httpClient.GetAsync("api/v1/Region");

        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<List<Region>>(json);
    }

    public async Task<Region> GetRegion(int id)
    {
        var response = await _httpClient.GetAsync($"api/v1/Region/{id}");

        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<Region>(json);
    }
}