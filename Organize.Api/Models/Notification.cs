using System.Text.Json.Serialization;

namespace Organize.Api.Models
{
    public class Notification
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("method")]
        public string Method { get; set; }
    }

}
