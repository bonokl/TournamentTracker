using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }

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

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercetage)
        {
            PlaceName = placeName;
            
            int.TryParse(placeNumber, out int placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal.TryParse(prizeAmount, out decimal prizeAmountValue);

            PrizeAmount = prizeAmountValue;

            double.TryParse(prizePercetage, out double prizePercentageValue);

            PrizePercentage = prizePercentageValue;
        }
    }
}
