using CatCards.Models;
using RestSharp;

namespace CatCards.Services
{
    public class CatPicService : ICatPicService
    {
        private readonly string apiUrl = "https://cat-data.netlify.app/api/";
        private readonly RestClient client = new RestClient();
        
        public CatPic GetPic()
        {
            RestRequest request = new RestRequest(apiUrl + "pictures/random");
            IRestResponse<CatPic> response = client.Get<CatPic>(request);

            return response.Data;
        }
    }
}
