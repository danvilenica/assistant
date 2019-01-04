using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.DB.ViewModels
{
    public class TeamsWithPlayersVM
    {
        public TeamVM HomeTeam { get; set; }
        public TeamVM AwayTeam { get; set; }
        public DuelStatsVM DuelStats { get; set; }
    }
}
