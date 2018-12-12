using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.DB.Models
{
    [Table("Disciplines")]
    public class Discipline
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id{ get; set; }
        public int YellowCards{ get; set; }
        public int RedCards{ get; set; }
        public int Fauls{ get; set; }
        public int Offsides { get; set; }
    }
}
