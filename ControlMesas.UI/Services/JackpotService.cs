using System.Net.Http.Json;
using JackpotsModel.Controlmesas;

public class JackpotService
{
    private readonly HttpClient _httpClient;

    public JackpotService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Jackpot>> GetJackpotAsync(string methodName)
    {
        var response = await _httpClient.GetFromJsonAsync<List<Jackpot>>($"https://localhost:7217/api/Jackpot/{methodName}");
        return response ?? new List<Jackpot>();
    }

    public async Task UpdateJackpotAsync(Jackpot jackpot)
    {
        var response = await _httpClient.PostAsJsonAsync("https://localhost:7217/api/Jackpot/update", jackpot);
        response.EnsureSuccessStatusCode();
    }
}