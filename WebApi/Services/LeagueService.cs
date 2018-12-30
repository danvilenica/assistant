using Dao.DB.Context;
using Dao.DB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Services
{
    
    public interface ILeagueService
    {
        IEnumerable<DdlLeagueVM> GetAll();
    }

    public class LeagueService : ILeagueService
    {
        private DataContext _context;

        public LeagueService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<DdlLeagueVM> GetAll()
        {
            return new List<DdlLeagueVM>();
        }
    }
}
