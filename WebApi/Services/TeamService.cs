using Dao.DB.Context;
using Dao.DB.Enums;
using Dao.DB.Models;
using Dao.DB.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Services
{
    public interface ITeamService
    {
        Task<List<TeamVM>> GetByIds(IdsVM ids);
    }


    public class TeamService : ITeamService
    {
        private DataContext _context;
        public TeamService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<TeamVM>> GetByIds(IdsVM ids)
        {
            var teams = new List<TeamVM>();

            //Get home team by id
            var homeTeam = await _context.Teams
                .Where(x => x.Id == ids.HomeId)
                .Select(x => new TeamVM()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Since = x.Since,
                    Description = x.Description,
                    ImagePath = x.ImagePath,
                    Key = x.Key
                })
                .FirstOrDefaultAsync()
                .ConfigureAwait(false);

            //Get away team by id
            var awayTeam = await _context.Teams
                .Where(x => x.Id == ids.AwayId)
                .Select(x => new TeamVM()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Since = x.Since,
                    Description = x.Description,
                    ImagePath = x.ImagePath,
                    Key = x.Key
                })
                .FirstOrDefaultAsync()
                .ConfigureAwait(false);

            teams.Add(homeTeam);
            teams.Add(awayTeam);

            //Get every team match of home and away team
            var teamMatches = await _context.TeamMatches
                .Include(x => x.Team)
                .Where(x => x.Match.HomeTeamId == teams[0].Id && x.Match.AwayTeamId == teams[1].Id)
                .ToListAsync()
                .ConfigureAwait(false);

            var duelStats = new DuelStatsVM()
            {
                HomeId = homeTeam.Id,
                AwayId = awayTeam.Id,
                Played = 0,
                HomeWins = 0,
                AwayWins = 0,
                Drawn = 0,
                HomePenaltiesWon = 0,
                HomePenaltiesScored = 0,
                HomeCleanSheets = 0,
                HomeYellowCards = 0,
                HomeRedCards = 0,
                AwayPenaltiesWon = 0,
                AwayPenaltiesScored = 0,
                AwayCleanSheets = 0,
                AwayYellowCards = 0,
                AwayRedCards = 0
            };

            //Set duel stats values
            foreach (var match in teamMatches)
            {
                if (match.TeamId == duelStats.HomeId)
                {
                    //for every home team increment values

                    if (match.MatchStatus == MatchStatus.Win)
                    {
                        duelStats.HomeWins++;
                    }
                    else if (match.MatchStatus == MatchStatus.Draw)
                    {
                        duelStats.Drawn++;
                    }
                    duelStats.HomeCleanSheets += match.CleanSheets;
                    duelStats.HomePenaltiesScored += match.PenaltiesScored;
                    duelStats.HomePenaltiesWon += match.PenaltiesWon;
                    duelStats.HomeYellowCards += match.YellowCards;
                    duelStats.HomeRedCards += match.RedCards;
                }

                if (match.TeamId == duelStats.AwayId)
                {
                    //for every away team increment values

                    if (match.MatchStatus == MatchStatus.Win)
                    {
                        duelStats.AwayWins++;
                    }

                    duelStats.AwayCleanSheets += match.CleanSheets;
                    duelStats.AwayPenaltiesScored += match.PenaltiesScored;
                    duelStats.AwayPenaltiesWon += match.PenaltiesWon;
                    duelStats.AwayYellowCards += match.YellowCards;
                    duelStats.AwayRedCards += match.RedCards;
                }
            }
            duelStats.Played = duelStats.HomeWins + duelStats.AwayWins + duelStats.Drawn;

            foreach (var team in teams)
            {
                //Get team players
                var teamPlayers = await _context.TeamPlayers
                    .Where(x => x.TeamId == team.Id)
                    .Select(x => new PlayerVM()
                    {
                        Id = x.PlayerId,
                        PersonalDetail = new PersonalDetailVM()
                        {
                            FirstName = x.Player.FirstName,
                            LastName = x.Player.LastName,
                            ImagePath = x.Player.ImagePath,
                            DateOfBirth = x.Player.DateOfBirth,
                            Nationality = x.Player.Nationality,
                            Height = x.Player.Height,
                            Weight = x.Player.Weight
                        },
                        SocialNetworkInfo = new SocialNetworkInfoVM()
                        {
                            Facebook = x.Player.Facebook,
                            Twitter = x.Player.Twitter,
                            Instagram = x.Player.Instagram
                        },
                        Stats = new List<PlayerStatsVM>()
                    })
                    .ToListAsync()
                    .ConfigureAwait(false);

                var teamPlayerMatchStats = await _context.PlayerMatchStats
                    .Where(x => x.SeasonTeam.TeamId == team.Id)
                    .ToListAsync()
                    .ConfigureAwait(false);

                var statsBySeasonDictionary = from tpms in teamPlayerMatchStats
                                              group tpms by tpms.SeasonTeam.Season.Year.Year into ss
                                              select new { Season = ss.Key, TeamPlayerMatchStats = ss.ToList() };


                foreach (var player in teamPlayers)
                {
                    foreach (var seasonStats in statsBySeasonDictionary)
                    {
                        foreach (var playerStats in seasonStats.TeamPlayerMatchStats)
                        {
                            if (player.Id == playerStats.PlayerId)
                            {
                                player.Stats.Add(new PlayerStatsVM()
                                {
                                    PlayerAttack = new PlayerAttackVM()
                                    {
                                        Goals = playerStats.Goals,
                                        BigChancesMissed = playerStats.BigChancesMissed,
                                        FreekicksScored = playerStats.FreekicksScored,
                                        GoalsWithLeftFoot = playerStats.GoalsWithLeftFoot,
                                        GoalsWithRightFoot = playerStats.GoalsWithRightFoot,
                                        HeadedGoals = playerStats.HeadedGoals,
                                        HitWoodwork = playerStats.HitWoodwork,
                                        PenaltiesScored = playerStats.PenaltiesScored,
                                        Shots = playerStats.Shots,
                                        ShotsOnTarget = playerStats.ShotsOnTarget,
                                        Accuracy = playerStats.ShotsOnTarget / playerStats.Goals
                                    }
                                });
                            }
                        }
                    }
                }

                team.Players.AddRange(teamPlayers);
            }
            return teams;
        }


    }
}
