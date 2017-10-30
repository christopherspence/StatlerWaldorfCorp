using StatlerWaldorfCorp.TeamService.Models;
using System.Collections.Generic;

namespace StatlerWaldorfCorp.TeamService.Persistence
{
	public interface ITeamRepository
	{
		IEnumerable<Team> GetTeams();
		void AddTeam(Team team);
	}
}