using AutoMapper;
using Dao.DB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Services;
using static WebApi.Services.TeamService;

namespace WebApi.Controllers
{
    [Route("api/teams")]
    public class TeamsController : Controller
    {
        private ITeamService _teamService;
        private IMapper _mapper;

        public TeamsController(ITeamService teamService, IMapper mapper)
        {
            _teamService = teamService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post([FromBody]IdsVM ids)
        {
            var teams = _teamService.GetByIds(ids);
            return Ok(teams);
        }
    }
}
