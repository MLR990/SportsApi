using System;
using System.Collections.Generic;

namespace SportsAPI.Models.APIClasses.GetCollections
{
    public class GetPlayers
    {
        public DateTime CurrentRosterStatus { get; set; }
        public IEnumerable<Player> Players { get; set; }
        //public IEnumerable<TeamReference> References { get; set; }
    }
}
