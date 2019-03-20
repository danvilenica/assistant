using AssistantWebApi.Helpers;
using AutoMapper;
using Dao.DB.ViewModels;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
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
        public async Task<ActionResult> Post([FromBody]IdsVM ids)
        {
            try
            {
                var teams = await _teamService.GetByIds(ids);
                if (teams == null)
                {
                    throw new AppException("Teams where not found");
                }
                return Ok(teams);
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return NotFound(new { message = ex.Message });
            }            
        }
    }
}
