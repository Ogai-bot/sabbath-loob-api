using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using SabbathLoop.Domain.Commands;

namespace SabbathLoop.API
{
	public class Startup
	{
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
		{
            Configuration = configuration;
		}

        public void ConfigureServices(IServiceCollection services)
		{
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddDbContext<CommandDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("CommandsSabbathLoopDb"),
                x => x.MigrationsAssembly("SabbathLoop.Domain")));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            else
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

