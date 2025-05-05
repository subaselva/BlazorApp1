using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class BackupApiService
{
    private readonly HttpClient _http;

    public BackupApiService(HttpClient http)
    {
        _http = http;
    }

    public async Task<string> RunBackupAsync()
    {
        var response = await _http.PostAsync("api/backup/run", null);
        return await response.Content.ReadAsStringAsync();
    }
}
