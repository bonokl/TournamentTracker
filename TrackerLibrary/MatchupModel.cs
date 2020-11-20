using System.Collections.Generic;

namespace TournamentTrackerLibrary
{   
    /// <summary>
    /// Represents one match in the tournament.
    /// </summary>
    public class MatchupModel
    {
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
        public int MatchRound { get; set; }
        
    }
}