using System;
namespace SportsAPI.Models.APIClasses.Models.Statistics
{
    public class Stats
    {
        public FieldGoals FieldGoals { get; set; }
        public FreeThrows FreeThrows { get; set; }
        public Rebounds Rebounds { get; set; }
        public Offense Offense { get; set; }
        public Defense Defense { get; set; }
        public Miscellaneous Miscellaneous { get; set; }
    }
}
