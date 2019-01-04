using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.DB.ViewModels
{
    public class DuelStatsVM
    {
        public int HomeId { get; set; }
        public int AwayId { get; set; }
        public int Played { get; set; }
        public int HomeWins { get; set; }
        public int AwayWins { get; set; }
        public int Drawn { get; set; }
        public int HomeGoals { get; set; }
        public int HomePenaltiesScored { get; set; }
        public int HomePenaltiesWon { get; set; }
        public int HomeCleanSheets { get; set; }
        public int HomeYellowCards { get; set; }
        public int HomeRedCards { get; set; }
        public int AwayGoals { get; set; }
        public int AwayPenaltiesScored { get; set; }
        public int AwayPenaltiesWon { get; set; }
        public int AwayCleanSheets { get; set; }
        public int AwayYellowCards { get; set; }
        public int AwayRedCards { get; set; }
    }
}
