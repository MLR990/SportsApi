using System;
namespace SportsAPI.Models.APIClasses.Models.Statistics
{
    public class Miscellaneous
    {
        public int fouls { get; set; }
        public decimal foulsPerGame { get; set; }
        public int foulsDrawn { get; set; }
        public decimal foulsDrawnPerGame { get; set; }
        public int foulPers { get; set; }
        public decimal foulPersPerGame { get; set; }
        public int foulTech { get; set; }
        public decimal foulTechPerGame { get; set; }
        public int foulTechDrawn { get; set; }
        public decimal foulTechDrawnPerGame { get; set; }
        public int foulFlag1 { get; set; }
        public decimal foulFlag1PerGame { get; set; }
        public int foulFlag1Drawn { get; set; }
        public decimal foulFlag1DrawnPerGame { get; set; }
        public int foulFlag2 { get; set; }
        public decimal foulFlag2PerGame { get; set; }
        public int foulFlag2Drawn { get; set; }
        public decimal foulFlag2DrawnPerGame { get; set; }
        public int elections { get; set; }
        public int plusMinus { get; set; }
        public decimal plusMinusPerGame { get; set; }
        public int minSeconds { get; set; }
        public decimal minSecondsPerGame { get; set; }
        public int gamesStarted { get; set; }
    }
}
