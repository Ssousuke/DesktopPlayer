using System.Text.Json.Serialization;

namespace Organize.Api.Models
{
    public class ConferenceProperties
    {
        [JsonPropertyName("allowedConferenceSolutionTypes")]
        public List<string> AllowedConferenceSolutionTypes { get; set; }
    }
}
