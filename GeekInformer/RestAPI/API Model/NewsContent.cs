using System.Collections.Generic;

using Newtonsoft.Json;

namespace GeekInformer.RestAPI.API_Model
{
    [JsonObject]
    public class NewsContent
    {
        [JsonProperty("author")]
        public string Author{ get; set; }

        [JsonProperty("content")]
        public string Content{ get; set; }

        [JsonProperty("date_published")]
        public string DatePublished{ get; set; }

        [JsonProperty("domain")]
        public string Domain{ get; set; }

        [JsonProperty("items")]
        public IList<NewsContentItem> Items{ get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail{ get; set; }

        [JsonProperty("title")]
        public string Title{ get; set; }

        [JsonProperty("type")]
        public string Type{ get; set; }

        [JsonProperty("url")]
        public string Url{ get; set; }
    }

    [JsonObject]
    public class NewsContentItem
    {
        [JsonProperty("id")]
        public string Id{ get; set; }

        [JsonProperty("type")]
        public string Type{ get; set; }

        [JsonProperty("creator")]
        public string Creator{ get; set; }

        [JsonProperty("searchWithCreator")]
        public string SearchWithCreator{ get; set; }

        [JsonProperty("title")]
        public string Title{ get; set; }

        [JsonProperty("count")]
        public string Count{ get; set; }

    }
}
