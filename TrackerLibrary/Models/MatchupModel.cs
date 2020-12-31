using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one match in the tournament.
    /// </summary>
    public class MatchupModel
    {
        // <summary>
        ///  The unique identifier for the matchup
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The set of teams that are involved in this match.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Winner of the match.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Which round is this match part of.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
