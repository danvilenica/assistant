using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DB.Models
{
    [Table("LeagueRecords")]
    public class LeagueRecord
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public int Appearances { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
    }
}
