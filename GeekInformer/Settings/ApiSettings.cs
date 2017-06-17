using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekInformer.Settings
{
    public static class ApiSettings
    {
        public static string GetAllNewsUrl(string id, DateTime date)
        {
            if(id == string.Empty)
                return null;

            var d = date.ToString("O");
            return $"http://geekinformer.net/api/news/get_all_news?id={id}&date={d}";
        }
    }
}
