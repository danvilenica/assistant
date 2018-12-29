using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.DB.ViewModels
{
    public class LeagueStatusVM
    {
        public Guid Id { get; set; }
        public string Season { get; set; }
        public int Position { get; set; }
        public Guid ClubId { get; set; }
        public string ImagePath { get; set; }
        public string Played { get; set; }
        public int Win { get; set; }
        public int Loss { get; set; }
        public int Draw { get; set; }
        public int GoalDifference { get; set; }
        public int Points { get; set; }
    }
}
