using System.Text.Json.Serialization;

namespace Organize.Api.Models
{
    public class Acl
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("etag")]
        public string Etag { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("scope")]
        public Scope Scope { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }
    }
}
