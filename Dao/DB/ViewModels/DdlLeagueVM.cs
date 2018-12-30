using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.DB.ViewModels
{
    public class DdlLeagueVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<DdlTeamVM> Teams { get; set; }
    }
}
