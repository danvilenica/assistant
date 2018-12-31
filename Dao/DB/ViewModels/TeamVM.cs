using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.DB.ViewModels
{
    public class TeamVM
    {
        public int Id { get; set; }
        public int Since { get; set; }

        public string Name { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public List<PlayerVM> Players { get; set; }
    }
}
