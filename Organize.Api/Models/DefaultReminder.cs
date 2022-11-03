using System.Text.Json.Serialization;

namespace Organize.Api.Models
{
    public class DefaultReminder
    {
        [JsonPropertyName("method")]
        public string Method { get; set; }

        [JsonPropertyName("minutes")]
        public int Minutes { get; set; }
    }
}
