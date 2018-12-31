using Dao.DB.Context;
using Dao.DB.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Services
{

    public interface ILeagueService
    {
        Task<IEnumerable<DdlLeagueVM>> GetAll();
    }

    public class LeagueService : ILeagueService
    {
        private DataContext _context;

        public LeagueService(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DdlLeagueVM>> GetAll()
        {
            var leagues = await _context.Leagues
                .Select(x => new DdlLeagueVM()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Teams = new List<DdlTeamVM>()
                })
                .ToListAsync()
                .ConfigureAwait(false);

            var teams = await _context.SeasonTeams
                .Where(x => x.Season.Year.Year == DateTime.Now.Year)
                .Select(x => new DdlTeamVM()
                {
                    Id = x.TeamId,
                    Name = x.Team.Name,
                    LeagueId = x.LeagueId
                })
                .ToListAsync()
                .ConfigureAwait(false);

            foreach (var league in leagues)
            {
                foreach (var team in teams)
                {
                    if (league.Id == team.LeagueId)
                    {
                        league.Teams.Add(team);
                    }
                }
            }

            return leagues;
        }
    }
}
