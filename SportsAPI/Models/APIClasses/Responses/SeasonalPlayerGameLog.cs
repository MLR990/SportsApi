using System;
using System.Collections.Generic;
using SportsAPI.Models.APIClasses.Models;

namespace SportsAPI.Models.APIClasses.GetCollections
{
    public class SeasonalPlayerGameLog
    {
        public DateTime LastUpdatedOn { get; set; }
        public IEnumerable<GameLog> GameLogs { get; set; }
        //public References References { get; set; }
    }
}
