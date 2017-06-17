using System;
using System.Linq;
using System.Threading.Tasks;

using GeekInformer.Model;
using GeekInformer.Model.API_Model;
using GeekInformer.REST_API.API_Contoller;

using Newtonsoft.Json;

namespace GeekInformer.ViewModel
{
    
    public class NewsViewModel
    {
        private NewsApiController _newsController;
        private User _user;
        private AllNews AllNews{ get; set; }

        public NewsViewModel()
        {
            _newsController = new NewsApiController();
            _user = new User();
            
        }

      public async Task<AllNews> GetAsyncAllNews()
        {
            AllNews = await _newsController.GetAsyncAllNews(_user.UserId, DateTime.Now);
          
          return AllNews;
        } 
    }
}
