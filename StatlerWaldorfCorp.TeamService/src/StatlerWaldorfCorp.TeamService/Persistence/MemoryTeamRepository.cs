using StatlerWaldorfCorp.TeamService.Models;
using System.Collections.Generic;

namespace StatlerWaldorfCorp.TeamService.Persistence
{
	public class MemoryTeamRepository : ITeamRepository
	{
		protected static ICollection<Team> Teams;
		
		public MemoryTeamRepository()
		{
			if (Teams == null)
			{
				Teams = new List<Team>();
			}
		}
		
		public MemoryTeamRepository(ICollection<Team> teams)
		{
			Teams = teams;
		}
		
		public IEnumerable<Team> GetTeams()
		{
			return Teams;
		}
		
		public void AddTeam(Team t)
		{
			Teams.Add(t);
		}
	}
}