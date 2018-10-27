using System;
namespace SportsAPI.Models.APIClasses.Models.Statistics
{
    public class FieldGoals
    {
        public int fg2PtAtt { get; set; }
        public decimal fg2PtAttPerGame { get; set; }
        public int fg2PtMade { get; set; }
        public decimal fg2PtMadePerGame { get; set; }
        public decimal fg2PtPct { get; set; }
        public int fg3PtAtt { get; set; }
        public decimal fg3PtAttPerGame { get; set; }
        public int fg3PtMade { get; set; }
        public decimal fg3PtMadePerGame { get; set; }
        public decimal fg3PtPct { get; set; }
        public int fgAtt { get; set; }
        public decimal fgAttPerGame { get; set; }
        public int fgMade { get; set; }
        public decimal fgMadePerGame { get; set; }
        public decimal fgPct { get; set; }
    }
}
