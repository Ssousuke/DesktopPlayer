using System.Text.Json.Serialization;

namespace Organize.Api.Models
{
    /// <summary>
    /// ACL ROLE
    /// </summary>
    public class Scope
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
