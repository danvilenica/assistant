using Dao.DB.Context;
using Dao.DB.Models;
using Dao.DB.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Services
{
    public interface ITeamService
    {
        Task<TeamsWithPlayersVM> GetByIds(IdsVM ids);
    }

    public class TeamService : ITeamService
    {
        private DataContext _context;

        public TeamService(DataContext context)
        {
            _context = context;
        }

        public async Task<TeamsWithPlayersVM> GetByIds(IdsVM ids)
        {
            var teams = new List<TeamVM>();
            Random rnd = new Random();

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
            homeTeam.Players = new List<PlayerVM>();
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
            awayTeam.Players = new List<PlayerVM>();

            teams.Add(homeTeam);
            teams.Add(awayTeam);

            var duelStats = new DuelStatsVM()
            {
                HomeId = homeTeam.Id,
                AwayId = awayTeam.Id,
                Played = 43,
                HomeWins = homeTeam.Id == 2 ? 10 : 23,
                AwayWins = homeTeam.Id == 2 ? 23 : 10,
                Drawn = 10,
                HomeGoals = homeTeam.Id == 2 ? 46 : 69,
                HomePenaltiesWon = homeTeam.Id == 2 ? 5 : 4,
                HomePenaltiesScored = homeTeam.Id == 2 ? 4 : 1,
                HomeCleanSheets = homeTeam.Id == 2 ? 10 : 17,
                HomeYellowCards = homeTeam.Id == 2 ? 86 : 66,
                HomeRedCards = homeTeam.Id == 2 ? 8 : 2,
                AwayGoals = homeTeam.Id == 2 ? 69 : 46,
                AwayPenaltiesWon = homeTeam.Id == 2 ? 4 : 5,
                AwayPenaltiesScored = homeTeam.Id == 2 ? 1 : 4,
                AwayCleanSheets = homeTeam.Id == 2 ? 17 : 10,
                AwayYellowCards = homeTeam.Id == 2 ? 66 : 86,
                AwayRedCards = homeTeam.Id == 2 ? 2 : 8
            };

            foreach (var team in teams)
            {
                //Get team players
                var teamPlayers = await _context.TeamPlayers
                    .Where(x => x.TeamId == team.Id)
                    .Select(x => new PlayerVM()
                    {
                        Id = x.PlayerId,
                        LeagueRecord = new LeagueRecordVM()
                        {
                            Appearances = rnd.Next(0, 150),
                            Assists = rnd.Next(0, 30),
                            Goals = rnd.Next(0, 30)
                        },
                        PersonalDetails = new PersonalDetailVM()
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
                        }
                    })
                    .Take(25)
                    .ToListAsync()
                    .ConfigureAwait(false);

                var seasons = await _context.Seasons
                    .OrderBy(x => x.Id)
                    .Take(4)
                    .ToListAsync()
                    .ConfigureAwait(false);

                foreach (var player in teamPlayers)
                {
                    player.Stats = new List<PlayerStatsVM>();
                    foreach (var season in seasons)
                    {
                        var Goals = rnd.Next(0, 150);
                        var GoalsPerMatch = rnd.Next(0, 150);
                        var BigChancesMissed = rnd.Next(9, 20);
                        var FreekicksScored = rnd.Next(2, 30);
                        var GoalsWithLeftFoot = rnd.Next(9, 50);
                        var GoalsWithRightFoot = rnd.Next(8, 20);
                        var HeadedGoals = rnd.Next(5, 10);
                        var HitWoodwork = rnd.Next(4, 25);
                        var PenaltiesScored = rnd.Next(5, 24);
                        var Shots = rnd.Next(150, 350);
                        var ShotsOnTarget = rnd.Next(50, 200);
                        var Accuracy = rnd.Next(0, 150);
                        var Tackles = rnd.Next(0, 150);
                        var TacklesSuccess = rnd.Next(0, 150);
                        var BlockedShots = rnd.Next(0, 150);
                        var Interceptions = rnd.Next(0, 150);
                        var Clearances = rnd.Next(0, 150);
                        var HeadedClearance = rnd.Next(0, 150);
                        var Recoveries = rnd.Next(0, 150);
                        var DuelsWon = rnd.Next(0, 150);
                        var DuelsLost = rnd.Next(0, 150);
                        var Successful = rnd.Next(0, 150);
                        var ErrorsLeadingToGoal = rnd.Next(0, 150);
                        var AerialBattlesWon = rnd.Next(0, 150);
                        var AerialBattlesLost = rnd.Next(0, 150);
                        var Assists = rnd.Next(0, 150);
                        var Passes = rnd.Next(0, 150);
                        var PassesPerMatch = rnd.Next(0, 150);
                        var BigChancesCreated = rnd.Next(0, 150);
                        var Crosses = rnd.Next(0, 150);
                        var ThroughBalls = rnd.Next(0, 150);
                        var AccurateLongBalls = rnd.Next(0, 150);

                        player.Stats.Add(new PlayerStatsVM()
                        {
                            Season = season.Year.Year.ToString(),
                            Attack = new PlayerAttackVM()
                            {
                                Goals = Goals,
                                GoalsPerMatch = GoalsPerMatch,
                                BigChancesMissed = BigChancesMissed,
                                FreekicksScored = FreekicksScored,
                                GoalsWithLeftFoot = GoalsWithLeftFoot,
                                GoalsWithRightFoot = GoalsWithRightFoot,
                                HeadedGoals = HeadedGoals,
                                HitWoodwork = HitWoodwork,
                                PenaltiesScored = PenaltiesScored,
                                Shots = Shots,
                                ShotsOnTarget = ShotsOnTarget,
                                Accuracy = Accuracy
                            },
                            Discipline = new DisciplineVM()
                            {
                                Fauls = rnd.Next(0, 200),
                                Offsides = rnd.Next(0, 150),
                                RedCards = rnd.Next(0, 50),
                                YellowCards = rnd.Next(0, 100)
                            },
                            Defense = new PlayerDefenseVM()
                            {
                                Tackles = Tackles,
                                TacklesSuccess = TacklesSuccess,
                                BlockedShots = BlockedShots,
                                Interceptions = Interceptions,
                                Clearances = Clearances,
                                HeadedClearance = HeadedClearance,
                                Recoveries = Recoveries,
                                DuelsWon = DuelsWon,
                                DuelsLost = DuelsLost,
                                Successful = Successful,
                                ErrorsLeadingToGoal = ErrorsLeadingToGoal,
                                AerialBattlesWon = AerialBattlesWon,
                                AerialBattlesLost = AerialBattlesLost
                            },
                            PlayerTeamPlay = new PlayerTeamPlayVM()
                            {
                                Assists = Assists,
                                Passes = Passes,
                                PassesPerMatch = PassesPerMatch,
                                BigChancesCreated = BigChancesCreated,
                                Crosses = Crosses,
                                Accuracy = Accuracy,
                                ThroughBalls = ThroughBalls,
                                AccurateLongBalls = AccurateLongBalls
                            }
                        });
                    }
                }

                team.Players.AddRange(teamPlayers);
            }
            var TeamsWithPlayers = new TeamsWithPlayersVM()
            {
                HomeTeam = teams[0],
                AwayTeam = teams[1],
                DuelStats = duelStats
            };
            return TeamsWithPlayers;
        }
    }
}