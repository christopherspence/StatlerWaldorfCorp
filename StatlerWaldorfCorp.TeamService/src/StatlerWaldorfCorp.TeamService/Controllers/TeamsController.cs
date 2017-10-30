using Microsoft.AspNetCore.Mvc;
using StatlerWaldorfCorp.TeamService.Models;
using StatlerWaldorfCorp.TeamService.Persistence;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace StatlerWaldorfCorp.TeamService.Controllers
{
	public class TeamsController : Controller
	{
		ITeamRepository repository;
		
		public TeamsController(ITeamRepository repo) 
		{
			repository = repo;
		}
		
		[HttpGet]
		public async Task<IActionResult> GetAllTeams()
		{
			return this.Ok(repository.GetTeams());
		}
		
		[HttpPost]
		public async Task<IActionResult> CreateTeam(Team t)
		{
			repository.AddTeam(t);
			return this.Ok();
		}
	}
}