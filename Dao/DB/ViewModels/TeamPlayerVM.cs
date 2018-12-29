using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dao.DB.ViewModels
{
    public class TeamPlayerVM
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImagePath { get; set; }
        public Guid PersonalDetailsId { get; set; }
        public Guid SocialNetworkInfoId { get; set; }
        public Guid LeagueRecordId { get; set; }

    }
}