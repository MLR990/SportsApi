using System;
using System.Collections;
using System.Collections.Generic;

namespace SportsAPI.Models.APIClasses
{
    public class DailyGames
    {
        public DateTime LastUpdatedOn
        {
            get;
            set;
        }

        public IEnumerable<Game> Games
        {
            get;
            set;
        }

        public References References
        {
            get;
            set;
        }


    }
}
