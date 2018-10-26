using System;
using System.Collections.Generic;

namespace SportsAPI.Models.APIClasses
{
    public class References
    {
        public IEnumerable<TeamReference> TeamReferences
        {
            get;
            set;
        }

        public IEnumerable<VenueReference> VenueReferences
        {
            get;
            set;
        }
    }
}
