using Microsoft.AspNetCore.Mvc;
using StatlerWaldorfCorp.TeamService.Controllers;
using StatlerWaldorfCorp.TeamService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace StatlerWaldorfCorp.TeamService.Tests
{
    public class TeamsControllerTest
    {
		TeamsController controller = new TeamsController(new ControllerTestTeamRepository());
	
        [Fact]
        public async void QueryTeamListReturnsCorrectTeams()
        {
			var result = (IEnumerable<Team>)(await controller.GetAllTeams() as ObjectResult).Value;
			List<Team> teams = new List<Team>(result);
			Assert.Equal(2, teams.Count);
        }

		[Fact]
		public async void CreateTeamAddsTeamToList()
		{
			var teams = (IEnumerable<Team>)(await controller.GetAllTeams() as ObjectResult).Value;
			List<Team> original = new List<Team>(teams);
			
			Team t = new Team("sample");
			var result = await controller.CreateTeam(t);

			var newTeamsRaw = (IEnumerable<Team>)(await controller.GetAllTeams() as ObjectResult).Value;
			
			List<Team> newTeams = new List<Team>(newTeamsRaw);
			Assert.Equal(newTeams.Count, original.Count+1);
			var sampleTeam = newTeams.FirstOrDefault(target => target.Name == "sample");
			Assert.NotNull(sampleTeam);
		}
    }
}
