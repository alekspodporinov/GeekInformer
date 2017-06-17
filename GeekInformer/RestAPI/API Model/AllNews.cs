using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace GeekInformer.Model.API_Model
{
    [JsonObject]
    public class AllNews
    {
        [JsonProperty("rss")]
        public IList<Rss> Rss { get; set; }

        [JsonProperty("youtube")]
        public IList<YouTube> YouTube { get; set; }
    }
}
