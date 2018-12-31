﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.DB.Models
{
    [Table("TeamPlayers")]
    public class TeamPlayer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int PlayerId { get; set; }
        public int SeasonId { get; set; }

        public Team Team { get; set; }
        public Player Player { get; set; }
        public Season Season { get; set; }
    }
}
