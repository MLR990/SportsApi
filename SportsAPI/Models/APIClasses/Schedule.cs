using System;
namespace SportsAPI.Models.APIClasses
{
    public class Schedule
    {
        public int Id
        {
            get;
            set;
        }

        public DateTime? StartTime
        {
            get;
            set;
        }

        public DateTime? EndedTime
        {
            get;
            set;
        }

        public Team HomeTeam
        {
            get;
            set;
        }

        public Team AwayTeam
        {
            get;
            set;
        }
    }
}
