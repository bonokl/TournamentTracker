using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class TournamentModel
    {
        /// <summary>
        /// name of the tournament
        /// </summary>
        public string TournamentName { get; set; }
        
        /// <summary>
        /// Entry fee for the teams
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// List of teams that are competing in tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// List of prizes
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// List of list  of mathcups in tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
