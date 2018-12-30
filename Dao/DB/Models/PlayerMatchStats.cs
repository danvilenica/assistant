using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.DB.Models
{
    [Table("PlayersMatchStats")]
    public class PlayerMatchStats
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Goals { get; set; }
        public int HeadedGoals { get; set; }
        public int GoalsWithRightFoot { get; set; }
        public int GoalsWithLeftFoot { get; set; }
        public int PenaltiesScored { get; set; }
        public int FreekicksScored { get; set; }
        public int Shots { get; set; }
        public int ShotsOnTarget { get; set; }
        public decimal Accuracy { get; set; }
        public int HitWoodwork { get; set; }
        public int BigChancesMissed { get; set; }
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
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public int Fauls { get; set; }
        public int Offsides { get; set; }
        public int Assists { get; set; }
        public int Passes { get; set; }
        public int BigChancesCreated { get; set; }
        public int Crosses { get; set; }
        public decimal PassAccuracy { get; set; }
        public int ThroughBalls { get; set; }
        public int AccurateLongBalls { get; set; }
    }
}
