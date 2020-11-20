using System.Collections.Generic;

namespace TournamentTrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Place number for created prize (1st Place, 2nd place,...)
        /// </summary>
        public int PlaceNumber { get; set; }
        
        /// <summary>
        /// Place number for created prize (Grand Prix Winner, Runner up, ...)
        /// </summary>
        public string PlaceName { get; set; }
        
        /// <summary>
        /// Amount of the prize
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Percentage of total prize fund
        /// </summary>
        public double PrizePercentage { get; set; }
        
    }
}