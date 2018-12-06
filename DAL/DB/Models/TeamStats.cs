using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.DB.Models
{
    [Table("TeamStats")]
    public class TeamStats
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Season { get; set; }

        public Guid TeamAttackId { get; set; }
        public Guid DisciplineId { get; set; }
        public Guid TeamDefenceId { get; set; }
        public Guid ClubTeamPlayId { get; set; }

        [ForeignKey("TeamAttackId")]
        public virtual TeamAttack TeamAttack { get; set; }

        [ForeignKey("DisciplineId")]
        public virtual Discipline Discipline { get; set; }

        [ForeignKey("TeamDefenceId")]
        public virtual TeamDefense TeamDefence { get; set; }

        [ForeignKey("ClubTeamPlayId")]
        public virtual ClubTeamPlay ClubTeamPlay { get; set; }
    }
}