using CatCards.Models;
using RestSharp;
using System.Text.Json;

namespace CatCards.Services
{
    public class CatFactService : ICatFactService
    {
        private readonly string apiUrl = "https://cat-data.netlify.app/api/";
        private readonly RestClient client = new RestClient();
        public CatFact GetFact()
        {
            RestRequest request = new RestRequest(apiUrl + "facts/random");
            IRestResponse<CatFact> response = client.Get<CatFact>(request);

            return response.Data;
        }
    }
}
