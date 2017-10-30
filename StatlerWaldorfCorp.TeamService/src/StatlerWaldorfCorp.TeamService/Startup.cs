using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using StatlerWaldorfCorp.TeamService.Persistence;

namespace StatlerWaldorfCorp.TeamService
{
	public class Startup
	{
		public Startup(IHostingEnvironment env)
		{			
		}
		
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
			services.AddScoped<ITeamRepository, MemoryTeamRepository>();
		}
		
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			app.Run(async (context) => 
			{
				await context.Response.WriteAsync("Fuck Yeah!");
			});
		}
	}
}