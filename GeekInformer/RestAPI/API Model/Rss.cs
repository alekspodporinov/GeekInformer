using Newtonsoft.Json;

namespace GeekInformer.Model.API_Model
{
    [JsonObject]
    public class Rss
    {
        [JsonProperty("title")]
        public string Title{ get; set; }

        [JsonProperty("content")]
        public string Content{ get; set; }

        [JsonProperty("cover")]
        public string Cover{ get; set; }

        [JsonProperty("link")]
        public string Link{ get; set; }

        [JsonProperty("contentSnippet")]
        public string ContentSnippet{ get; set; }

        [JsonProperty("publishedDate")]
        public string PublishedDate{ get; set; }

        [JsonProperty("type")]
        public string Type{ get; set; }
    }
}
