using System;
namespace SportsAPI.Models.APIClasses.Models.Statistics
{
    public class Defense
    {
        public int tov { get; set; }
        public decimal tovPerGame { get; set; }
        public int stl { get; set; }
        public decimal stlPerGame { get; set; }
        public int blk { get; set; }
        public decimal blkPerGame { get; set; }
        public int blkAgainst { get; set; }
        public decimal blkAgainstPerGame { get; set; }
    }
}
