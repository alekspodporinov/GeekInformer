using Newtonsoft.Json;

namespace GeekInformer.Model.API_Model
{
    [JsonObject]
    public class Video
    {
        [JsonProperty("videoId")]
        public string Id{ get; set; }
    }

    [JsonObject]
    public class Snippet
    {
        [JsonProperty("channelId")]
        public string ChannelId{ get; set; }

        [JsonProperty("channelTitle")]
        public string ChannelTitle{ get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt{ get; set; }

        [JsonProperty("Title")]
        public string Title{ get; set; }

        [JsonProperty("thumbnails")]
        public Thumbnails Thumbnails{ get; set; }
    }

    [JsonObject]
    public class Thumbnails
    {
        [JsonProperty("medium")]
        public MediumThumbnails Medium{ get; set; }
    }

    [JsonObject]
    public class MediumThumbnails
    {
        [JsonProperty("url")]
        public string Url{ get; set; }
    }

    [JsonObject]
    public class YouTube
    {
        [JsonProperty("id")]
        Video VideoId{ get; set; }

        [JsonProperty("snippet")]
        public Snippet Snippet{ get; set; }

        [JsonProperty("type")]
        public string Type{ get; set; }
    }
}
