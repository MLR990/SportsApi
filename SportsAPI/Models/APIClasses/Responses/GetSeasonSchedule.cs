using System;
using System.Collections.Generic;

namespace SportsAPI.Models.APIClasses.GetCollections
{
    public class GetSeasonSchedule
    {
        public DateTime LastUpdatedOn { get; set; }
        public IEnumerable<Game> Games { get; set; }
        public References References { get; set; }
    }
}
