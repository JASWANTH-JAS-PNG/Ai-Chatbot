using System.Text;
using System.Text.Json;

namespace backend.Services
{
    public class OllamaServices
    {
        private readonly HttpClient _httpClient;

        public OllamaServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetOllamaResponse(IEnumerable<object> messages)
        {
            var payload = new { model = "dolphin-llama3:latest", messages, stream = false };
            var requestContent = new StringContent(
                JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("http://localhost:11434/api/chat", requestContent);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(responseContent);
            return doc.RootElement
                .GetProperty("message")
                .GetProperty("content")
                .GetString() ?? string.Empty;
        }
    }
}