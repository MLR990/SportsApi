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
using SportsAPI.Models.APIClasses.GetCollections;
using SportsAPI.SportsFeedAPI.Interface;

namespace SportsAPI.Controllers
{
    public class HomeController : Controller
    {
        static string results = "";



        public async Task<ActionResult> Index()
        {
            SportsFeedAPI.ScheduleService scheduleService = new SportsFeedAPI.ScheduleService();
            SportsFeedAPI.PlayerService playerService = new SportsFeedAPI.PlayerService();


            //DailyGames dailyGames = await scheduleService.GetDailyGames("2018-2019-regular", "20181027");
            //GetSeasonSchedule seasonGames = await scheduleService.GetSeasonSchedule("2018-2019-regular");
            SeasonalPlayerGameLog gameLog = await playerService.GetDailyPlayerGameLog("2017-2018-regular", DateTime.Now.AddYears(-1).AddDays(-1));
            string literal = "";
            //foreach (var game in seasonGames.Games)
            //{
            //    literal += game.Schedule.AwayTeam.Abbreviation + " at " + game.Schedule.HomeTeam.Abbreviation + "      /       ";
            //}

            results = literal;
            return RedirectToAction("HomePage");


        }
        public ActionResult HomePage()
        {
            ViewData["APIData"] = results;
            return View("Index");
        }

    }
}
