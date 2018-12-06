using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.DB.Models
{
    [Table("Teams")]
    public class Team
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string NameOfStadium { get; set; }
        public string ImagePath { get; set; }
        public List<TeamPlayer> Players { get; set; }
        public List<TeamStats> Statistics { get; set; }
        //public List<TeamSeason> Players { get; set; }
    }
}