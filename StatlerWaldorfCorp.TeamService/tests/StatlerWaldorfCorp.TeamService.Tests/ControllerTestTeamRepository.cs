using StatlerWaldorfCorp.TeamService.Models;
using StatlerWaldorfCorp.TeamService.Persistence;
using System.Collections.Generic;

namespace StatlerWaldorfCorp.TeamService.Tests
{
	public class ControllerTestTeamRepository : MemoryTeamRepository 
	{
		public ControllerTestTeamRepository() : base(new List<Team>
		{
			new Team("One"),
			new Team("Two")			
		}) {}
	}
}