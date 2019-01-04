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

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
