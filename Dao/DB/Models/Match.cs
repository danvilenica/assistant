using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.DB.Models
{
    [Table("Matches")]
    public class Match
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public int StadiumId { get; set; }
        public DateTime MatchDate { get; set; }

        public Stadium Stadium { get; set; }
        public SeasonTeam HomeTeam { get; set; }
        public SeasonTeam AwayTeam { get; set; }
    }
}
