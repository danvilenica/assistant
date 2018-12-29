using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dao.DB.ViewModels
{
    public class TeamStatsVM
    {
        public Guid Id { get; set; }

        public string Season { get; set; }

        public Guid TeamAttackId { get; set; }
        public Guid DisciplineId { get; set; }
        public Guid TeamDefenceId { get; set; }
        public Guid ClubTeamPlayId { get; set; }

        [ForeignKey("TeamAttackId")]
        public virtual TeamAttackVM TeamAttack { get; set; }

        [ForeignKey("DisciplineId")]
        public virtual DisciplineVM Discipline { get; set; }

        [ForeignKey("TeamDefenceId")]
        public virtual TeamDefenseVM TeamDefence { get; set; }

        [ForeignKey("ClubTeamPlayId")]
        public virtual ClubTeamPlayVM ClubTeamPlay { get; set; }
    }
}