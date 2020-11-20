using System.Collections.Generic;

namespace TournamentTrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// List of team members
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Team name
        /// </summary>
        public string TeamName { get; set; }
    }
}