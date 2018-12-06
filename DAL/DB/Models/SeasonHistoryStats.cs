﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.DB.Models
{
    [Table("SeasonHistoryStats")]
    public class SeasonHistoryStats
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public int MyProperty { get; set; }
    //    public id: string;
    //public season: string;
    //public leagueStatus: LeagueStatus;
    //public manager: string;
    //public topGoalscorer: string;
    //public mostAppearances: number;
    //public biggestWin: number;
    //public heaviestDefeat: number;
    }
}