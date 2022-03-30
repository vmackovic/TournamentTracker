using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Predstavlja jedan tim u meču
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Bodovi za određeni tim
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Iz kojeg prijašnjeg meča tim dolazi 
        /// kao pobjednik
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
