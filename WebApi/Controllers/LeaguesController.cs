using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssistantWebApi.Helpers;
using AutoMapper;
using Dao.DB.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/leagues")]
    public class LeaguesController : Controller
    {
        private ILeagueService _leagueService;
        private IMapper _mapper;

        public LeaguesController(ILeagueService leagueService, IMapper mapper)
        {
            _leagueService = leagueService;
            _mapper = mapper;
        }

        [HttpGet]
        public Task<List<DdlLeagueVM>> GetAll()
        {
            var leagues = _leagueService.GetAll();
            return leagues;
        }
    }
}
