using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SportsAPI.Models.APIClasses.GetCollections;
using SportsAPI.SportsFeedAPI.Interface;

namespace SportsAPI.SportsFeedAPI
{
    public class PlayerService : BaseAPIService, IPlayerService
    {
        public PlayerService()
        {
        }

        public async Task<GetPlayers> GetPlayers()
        {
            SetUpClient();

            string url = BasePullUrl + "players.json";
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();

                    GetPlayers playerList = JsonConvert.DeserializeObject<GetPlayers>(jsonString.Replace("\\", ""));

                    foreach (var player in playerList.Players)
                    {
                        Console.Write(player.FirstName + " " + player.LastName);
                    }

                    return playerList;
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

        public async Task<SeasonalPlayerGameLog> GetSeasonPlayerGameLog(string season)
        {
            SetUpClient();

            string url = BasePullUrl + season + "/player_gamelogs.json";
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();

                    SeasonalPlayerGameLog games = JsonConvert.DeserializeObject<SeasonalPlayerGameLog>(jsonString);

                    foreach (var game in games.GameLogs)
                    {
                        //Console.Write(game.Game..HomeTeam.Abbreviation + " (" + game.Score.HomeScoreTotal + ") -" + game.Schedule.AwayTeam.Abbreviation + " (" + game.Score.AwayScoreTotal + ") \r");
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

        public async Task<SeasonalPlayerGameLog> GetDailyPlayerGameLog(string season, DateTime date)
        {
            SetUpClient();

            string url = BasePullUrl + season + "/date/" + date.ToString("yyyyMMdd") + "/player_gamelogs.json";
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();

                    SeasonalPlayerGameLog games = JsonConvert.DeserializeObject<SeasonalPlayerGameLog>(jsonString);
                    Console.Write("On " + date.ToShortDateString() + " here's what everyone did in the NBA: \r");
                    foreach (var game in games.GameLogs)
                    {
                        Console.Write(game.Player.FirstName + " " + game.Player.LastName + " (" + game.Team.Abbreviation + ") had " + game.Stats.Offense.pts + " points, " + game.Stats.Offense.ast + " assists, and " + game.Stats.Rebounds.reb + " rebounds \r");
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
