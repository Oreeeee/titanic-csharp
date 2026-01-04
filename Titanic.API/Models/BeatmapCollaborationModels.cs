using System;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class BeatmapCollaborationModel
    {
        [JsonProperty("user")]
        public UserModelCompact User { get; set; }

        [JsonProperty("beatmap")]
        public BeatmapModel Beatmap { get; set; }

        [JsonProperty("is_beatmap_author")]
        public bool IsBeatmapAuthor { get; set; }

        [JsonProperty("allow_resource_updates")]
        public bool AllowResourceUpdates { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }

    public class BeatmapCollaborationModelWithoutBeatmap
    {
        [JsonProperty("user")]
        public UserModelCompact User { get; set; }

        [JsonProperty("is_beatmap_author")]
        public bool IsBeatmapAuthor { get; set; }

        [JsonProperty("allow_resource_updates")]
        public bool AllowResourceUpdates { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }

    public class BeatmapCollaborationRequestModelWithoutBeatmap
    {
        [JsonProperty("user")]
        public UserModelCompact User { get; set; }

        [JsonProperty("target")]
        public UserModelCompact Target { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }

    public class CollaborationUpdateRequest
    {
        [JsonProperty("allow_resource_updates")]
        public bool AllowResourceUpdates { get; set; }
    }

    public class BeatmapCollaborationRequestModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("user")]
        public UserModelCompact User { get; set; }

        [JsonProperty("beatmap")]
        public BeatmapModel Beatmap { get; set; }

        [JsonProperty("time")]
        public DateTime Time { get; set; }
    }

    public class BeatmapCollaborationCreateRequest
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}
