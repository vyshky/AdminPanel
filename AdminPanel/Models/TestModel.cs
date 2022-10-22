using System.Text.Json.Serialization;
using static AdminPanel.Models.FinishedTestsModel;

namespace AdminPanel.Models
{
    public class TestModel
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("statusDesc")]
        public string StatusDesc { get; set; }
        [JsonPropertyName("lastStep")]
        public string LastStep { get; set; }
        [JsonPropertyName("testName")]
        public string TestName { get; set; }
        [JsonPropertyName("startTime")]
        public string StartTime { get; set; }
        [JsonPropertyName("testDuration")]
        public int TestDuration { get; set; }
        [JsonPropertyName("planDuration")]
        public int PlanDuration { get; set; }
        [JsonPropertyName("scriptName")]
        public string ScriptName { get; set; }
        [JsonPropertyName("profileName")]
        public string ProfileName { get; set; }
        [JsonPropertyName("links")]
        public LinkModel[] Links { get; set; }
        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }
    }
}
