using System;
using System.Threading.Tasks;
using SportsAPI.Models.APIClasses.GetCollections;

namespace SportsAPI.SportsFeedAPI.Interface
{
    public interface IPlayerService
    {
        Task<GetPlayers> GetPlayers();
    }
}
