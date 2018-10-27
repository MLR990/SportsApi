using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using SportsAPI.Models.APIClasses;
using SportsAPI.Models.APIClasses.GetCollections;
using SportsAPI.SportsFeedAPI.Interface;

namespace SportsAPI.SportsFeedAPI
{
    public class ScheduleService : BaseAPIService, IScheduleService
    {
        public ScheduleService()
        {

        }

        public async Task<DailyGames> GetDailyGames(string season, string date)
        {
            SetUpClient();

            string url = BasePullUrl + season + "/date/" + date + "/games.json";
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

                    return games;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<GetSeasonSchedule> GetSeasonSchedule(string season)
        {
            SetUpClient();

            string url = BasePullUrl + season + "/games.json";
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();

                    GetSeasonSchedule games = JsonConvert.DeserializeObject<GetSeasonSchedule>(jsonString);

                    foreach (var game in games.Games)
                    {
                        Console.Write(game.Schedule.HomeTeam.Abbreviation + " (" + game.Score.HomeScoreTotal + ") -" + game.Schedule.AwayTeam.Abbreviation + " (" + game.Score.AwayScoreTotal + ") \r");
                    }

                    return games;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
