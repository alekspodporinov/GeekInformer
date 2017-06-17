using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using GeekInformer.Model.API_Model;
using GeekInformer.RestAPI.API_Model;

using Newtonsoft.Json;

namespace GeekInformer.REST_API.API_Contoller
{
    public class NewsApiController
    {

        HttpClient _client = new HttpClient();

        public async Task<AllNews> GetAsyncAllNews(string userId, DateTime date)
        {
            if (userId == string.Empty)
                return null;

            var d = date.ToString("O");
            string getUrl = $"http://geekinformer.net/api/news/get_all_news?id={userId}&date={d}";

            var result = await _client.GetAsync(getUrl);
            var strRes = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<AllNews>(strRes.Replace(@"\n"," "));

        }

        public async Task<NewsContent> GetAsyncNewsContent(string newsUrl)
        {
            if (newsUrl == string.Empty)
                return null;

            string getUrl = $"http://geekinformer.net/api/readability/parse?url={newsUrl}";

            var result = await _client.GetAsync(getUrl);
            var strRes = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<NewsContent>(strRes);

        }
    }
}
