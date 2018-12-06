using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.DB.Models
{
    [Table("Players")]
    public class TeamPlayer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImagePath { get; set; }
        public Guid PersonalDetailsId { get; set; }
        public Guid SocialNetworkInfoId { get; set; }
        public Guid LeagueRecordId { get; set; }

        [ForeignKey("PersonalDetailsId")]
        public virtual PersonalDetail PersonalDetail { get; set; }

        [ForeignKey("SocialNetworkInfoId")]
        public virtual SocialNetworkInfo SocialNetworkInfo { get; set; }

        [ForeignKey("LeagueRecordId")]
        public virtual LeagueRecord LeagueRecord { get; set; }

        public List<PlayerStats> PlayerStats { get; set; }
        public List<SeasonHistoryStats> SeasonHistoryStats { get; set; }
    }
}