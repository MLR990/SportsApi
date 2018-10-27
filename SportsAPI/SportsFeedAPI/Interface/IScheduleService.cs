using System;
using System.Threading.Tasks;
using SportsAPI.Models.APIClasses;
using SportsAPI.Models.APIClasses.GetCollections;

namespace SportsAPI.SportsFeedAPI.Interface
{
    public interface IScheduleService
    {
        Task<DailyGames> GetDailyGames(string season, string date);
        Task<GetSeasonSchedule> GetSeasonSchedule(string season);
    }
}
