
using Microsoft.EntityFrameworkCore;
using SabbathLoop.Domain.Commands.Companies.Entities.DbConfig;

namespace SabbathLoop.Domain.Commands
{
    public class CommandDbContext : DbContext
    {
        public CommandDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.UseCollation("latin1_general_ci_ai").HasDefaultSchema("dbo");
            builder.ApplyConfiguration(new CompanyDbConfig());
        }
    }
}