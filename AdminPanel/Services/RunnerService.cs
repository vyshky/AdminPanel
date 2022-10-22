using AdminPanel.Models;
using AdminPanel.Options;
using Microsoft.Extensions.Options;
using System.Text.Json;
using static AdminPanel.Models.FinishedTestsModel;

namespace AdminPanel.Services
{
    public class RunnerService : IRunnerService
    {
        private readonly IOptions<RunnerOption> _options;
        private readonly HttpClient _httpClient;
        public RunnerService(IOptions<RunnerOption> options, IHttpClientFactory httpClientFactory)
        {
            _options = options;
            _httpClient = httpClientFactory.CreateClient();
        }
        public async Task<FinishedTestsModel> GetFinishedTests()
        {
            string url = $"{_options.Value.BaseUrl}{_options.Value.FinishedUrl}";
            var respons = await _httpClient.GetAsync(url);
            var json = await respons.Content.ReadAsStringAsync();
            var tests = JsonSerializer.Deserialize<List<TestModel>>(json);
            var result = new FinishedTestsModel(tests);
            return result;
        }
    }
}
