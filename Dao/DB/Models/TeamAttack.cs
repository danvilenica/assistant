using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.DB.Models
{
    [Table("TeamAttacks")]
    public class TeamAttack
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public int Goals { get; set; }
        public decimal GoalsPerMatch { get; set; }
        public int PenaltiesScored { get; set; }
        public int Shots { get; set; }
        public int ShotsOnTarget { get; set; }
        public decimal Accuracy { get; set; }
        public int HitWoodwork { get; set; }
        public int BigChancesCreated { get; set; }
    }
}
