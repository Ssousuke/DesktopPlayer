using System.Text.Json.Serialization;

namespace Organize.Api.Models
{
    public class CalendarList
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("etag")]
        public string Etag { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; }

        [JsonPropertyName("summaryOverride")]
        public string SummaryOverride { get; set; }

        [JsonPropertyName("colorId")]
        public string ColorId { get; set; }

        [JsonPropertyName("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonPropertyName("foregroundColor")]
        public string ForegroundColor { get; set; }

        [JsonPropertyName("hidden")]
        public bool Hidden { get; set; }

        [JsonPropertyName("selected")]
        public string Selected { get; set; }

        [JsonPropertyName("accessRole")]
        public string AccessRole { get; set; }

        [JsonPropertyName("defaultReminders")]
        public List<DefaultReminder> DefaultReminders { get; set; }

        [JsonPropertyName("notificationSettings")]
        public NotificationSettings NotificationSettings { get; set; }

        [JsonPropertyName("primary")]
        public bool Primary { get; set; }

        [JsonPropertyName("deleted")]
        public bool Deleted { get; set; }

        [JsonPropertyName("conferenceProperties")]
        public ConferenceProperties ConferenceProperties { get; set; }
    }


}
