using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.DB.Models
{
    [Table("TeamMatches")]
    public class TeamMatch
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MatchStatus { get; set; }
        public int TeamId { get; set; }
        public int MatchId { get; set; }
        public int Goals { get; set; }
        public int PenaltiesScored { get; set; }
        public int PenaltiesWon { get; set; }
        public int CleanSheets { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
  
        public Team Team { get; set; }
        public Match Match { get; set; }
    }
}
