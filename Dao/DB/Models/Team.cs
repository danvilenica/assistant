﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dao.DB.Models
{
    [Table("Teams")]
    public class Team
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Since { get; set; }

        public string Name { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}