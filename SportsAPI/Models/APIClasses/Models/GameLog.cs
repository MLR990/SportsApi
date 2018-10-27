using System;
using SportsAPI.Models.APIClasses.Models.Statistics;

namespace SportsAPI.Models.APIClasses.Models
{
    public class GameLog
    {
        public Game Game { get; set; }
        public Player Player { get; set; }
        public Team Team { get; set; }
        public Stats Stats { get; set; }
    }
}
