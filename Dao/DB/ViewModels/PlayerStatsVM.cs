using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dao.DB.ViewModels
{
    public class PlayerStatsVM
    {
        public DisciplineVM Discipline { get; set; }
        public PlayerAttackVM PlayerAttack { get; set; }
        public PlayerDefenseVM PlayerDefense { get; set; }
        public PlayerTeamPlayVM PlayerTeamPlay { get; set; }
    }
}