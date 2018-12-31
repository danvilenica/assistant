using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.DB.ViewModels
{
    public class PlayerDefenseVM
    {
        public int Tackles { get; set; }
        public decimal TacklesSuccess { get; set; }
        public int BlockedShots { get; set; }
        public int Interceptions { get; set; }
        public int Clearances { get; set; }
        public int HeadedClearance { get; set; }
        public int Recoveries { get; set; }
        public int DuelsWon { get; set; }
        public int DuelsLost { get; set; }
        public decimal Successful { get; set; }
        public int ErrorsLeadingToGoal { get; set; }
        public int AerialBattlesWon { get; set; }
        public int AerialBattlesLost { get; set; }
    }
}
