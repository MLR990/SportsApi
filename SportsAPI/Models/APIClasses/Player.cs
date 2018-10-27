using System;
namespace SportsAPI.Models.APIClasses
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string PrimaryPosition { get; set; }
        public int? JerseyNumber { get; set; }
        public Team CurrentTeam { get; set; }
        public string CurrentRosterStatus { get; set; }
        public string CurrentInjury { get; set; }
        public string Height { get; set; }
        public int Weight { get; set; }
        public string BirthDate { get; set; }
        public int Age { get; set; }
        public string BirthCity { get; set; }
        public string BirthCountry { get; set; }
        public bool Rookie { get; set; }
        public string HighSchool { get; set; }
        public string College { get; set; }
        public string OfficialImageSrc { get; set; }
        public bool? CurrentContractYear { get; set; }


    }
}
