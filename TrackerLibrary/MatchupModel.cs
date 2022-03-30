using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Predstavlja jedan meč u turniru
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Lista timova koji su bili u meču
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }

        /// <summary>
        /// Pobjednik meča
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Kojoj rundi turnira ovaj meč pripada
        /// </summary>
        public int MatchupRound { get; set; }

        public MatchupModel()
        {
            Entries = new List<MatchupEntryModel>(); 
        }
    }
}
