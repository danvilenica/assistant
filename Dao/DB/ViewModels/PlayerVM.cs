using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.DB.ViewModels
{
    public class PlayerVM
    {
        public int Id { get; set; }
        public List<PlayerStatsVM> Stats { get; set; }
        public PersonalDetailVM PersonalDetail { get; set; }
        public LeagueRecordVM LeagueRecord { get; set; }
        public SocialNetworkInfoVM SocialNetworkInfo { get; set; }
        public int Number { get; set; }
    }
}
