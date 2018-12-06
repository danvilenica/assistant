using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.DB.Models
{
    [Table("PlayerStats")]
    public class PlayerStats
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
    }
}