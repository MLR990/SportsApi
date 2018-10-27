using System;
using System.Net.Http;

namespace SportsAPI.SportsFeedAPI
{
    public class BaseAPIService
    {
        public HttpClient client = new HttpClient();

        public string APIKey = "eace6d2a-89a4-47cb-a525-b13a09:MYSPORTSFEEDS";
        public string BaseUrl = "https://api.mysportsfeeds.com";
        public string BasePullUrl = "https://api.mysportsfeeds.com/v2.0/pull/nba/";


        public BaseAPIService()
        {
        }

        public void SetUpClient()
        {
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            string auth = Base64Encode(APIKey);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", auth);
        }

        private string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
