using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dao.DB.ViewModels
{
    public class PlayerStatsVM
    {
        public string Season { get; set; }
        public DisciplineVM Discipline { get; set; }
        public PlayerAttackVM Attack { get; set; }
        public PlayerDefenseVM Defense { get; set; }
        public PlayerTeamPlayVM PlayerTeamPlay { get; set; }
    }
}