using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DB.Models
{
    [Table("TeamDefenses")]
    public class TeamDefense
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public int Tackles { get; set; }
        public decimal TacklesSuccess { get; set; }
        public int BlockedShots { get; set; }
        public int Interceptions { get; set; }
        public int Clearances { get; set; }
        public int HeadedClearance { get; set; }
        public int AerialBattlesWon { get; set; }
        public int ErrorsLeadingToGoal { get; set; }
        public int CleanSheets { get; set; }
        public int GoalsConceded { get; set; }
        public int GoalsConcededPerMatch { get; set; }
        public int Saves { get; set; }
        public int OwnGoals { get; set; }
    }
}
