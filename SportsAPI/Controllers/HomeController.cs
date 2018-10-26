using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Newtonsoft.Json;
using SportsAPI.Models;
using SportsAPI.Models.APIClasses;

namespace SportsAPI.Controllers
{
    public class HomeController : Controller
    {
        static HttpClient client = new HttpClient();
        static string results = "";
        static string key = "eace6d2a-89a4-47cb-a525-b13a09:MYSPORTSFEEDS";
        static string baseUrl = "https://api.mysportsfeeds.com";
        static string season = "2018-2019-regular";


        public async Task<ActionResult> Index()
        {
            results = await GetDailyGames();

            return RedirectToAction("HomePage");

  
        }
        public ActionResult HomePage()
        {
            ViewData["APIData"] = results;
            return View("Index");
        }


        static async Task<string> GetDailyGames()
        {
            SetUpClient();

            string date = "20181126";
            string url = "https://api.mysportsfeeds.com/v2.0/pull/nba/" + season + "/date/"+ date +"/games.json";
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();

                    DailyGames games = JsonConvert.DeserializeObject<DailyGames>(jsonString);

                    foreach (var game in games.Games)
                    {
                        Console.Write(game.Schedule.HomeTeam.Abbreviation + "-" + game.Schedule.AwayTeam.Abbreviation + "\r");
                    }

                    return jsonString;
                } 
                else
                {
                    return "";
                }   
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "";
            }

        }

        private static void SetUpClient()
        {
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            string auth = Base64Encode(key);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", auth);
        }

        private static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

    }
}
