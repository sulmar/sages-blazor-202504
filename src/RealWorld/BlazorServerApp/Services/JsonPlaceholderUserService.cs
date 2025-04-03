using BlazorServerApp.Models;

namespace BlazorServerApp.Services;

public class JsonPlaceholderUserService
{
    private readonly HttpClient _http;

    public JsonPlaceholderUserService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<User>?> GetAllAsync()
    {
        return await _http.GetFromJsonAsync<List<User>>("/users");
    }
}
