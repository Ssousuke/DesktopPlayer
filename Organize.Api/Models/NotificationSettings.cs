using System.Text.Json.Serialization;

namespace Organize.Api.Models
{
    public class NotificationSettings
    {
        [JsonPropertyName("notifications")]
        public List<Notification> Notifications { get; set; }
    }
}
