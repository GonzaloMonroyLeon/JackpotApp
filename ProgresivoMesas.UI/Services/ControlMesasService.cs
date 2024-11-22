using System.Net.Http.Json;
using JackpotsModel.Controlmesas;

public class ControlMesasService
{
    private readonly HttpClient _httpClient;

    public ControlMesasService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<ControlMesasModel>> GetJackpotAsync(string methodName)
    {
        var response = await _httpClient.GetFromJsonAsync<List<ControlMesasModel>>($"https://localhost:7217/api/Jackpot/{methodName}");
        return response ?? new List<ControlMesasModel>();
    }

    public async Task UpdateJackpotAsync(ControlMesasModel jackpot)
    {
        var response = await _httpClient.PostAsJsonAsync("https://localhost:7217/api/Jackpot/update", jackpot);
        response.EnsureSuccessStatusCode();
    }
}