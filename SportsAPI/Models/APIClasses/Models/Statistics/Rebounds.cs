using System;
namespace SportsAPI.Models.APIClasses.Models.Statistics
{
    public class Rebounds
    {
        public int offReb { get; set; }
        public decimal offRebPerGame { get; set; }
        public int defReb { get; set; }
        public decimal defRebPerGame { get; set; }
        public int reb { get; set; }
        public decimal rebPerGame { get; set; }

    }
}
