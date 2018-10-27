using System;
namespace SportsAPI.Models.APIClasses.Models.Statistics
{
    public class FreeThrows
    {
        public int ftAtt { get; set; }
        public decimal ftAttPerGame { get; set; }
        public int ftMade { get; set; }
        public decimal ftMadePerGame { get; set; }
        public decimal ftPct { get; set; }
    }
}
