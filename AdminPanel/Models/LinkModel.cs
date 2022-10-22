using System.Text.Json.Serialization;

namespace AdminPanel.Models
{
    public class LinkModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
