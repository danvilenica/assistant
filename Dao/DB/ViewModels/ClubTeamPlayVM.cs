using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.DB.ViewModels
{
    public class ClubTeamPlayVM
    {
        public Guid Id { get; set; }
        public int Assists { get; set; }
        public int Passes { get; set; }
        public decimal PassesPerMatch { get; set; }
        public int BigChancesCreated { get; set; }
        public int Crosses { get; set; }
        public decimal Accuracy { get; set; }
        public int ThroughBalls { get; set; }
        public int AccurateLongBalls { get; set; }
    }
}
