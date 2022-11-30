
using Microsoft.EntityFrameworkCore;
using SabbathLoop.Domain.Commands.Churches.Entities;
using SabbathLoop.Domain.Commands.Churches.Entities.DbConfig;
using SabbathLoop.Domain.Commands.Classes.Entities;
using SabbathLoop.Domain.Commands.Classes.Entities.DbConfig;
using SabbathLoop.Domain.Commands.Companies.Entities;
using SabbathLoop.Domain.Commands.Companies.Entities.DbConfig;
using SabbathLoop.Domain.Commands.Members.Entities;
using SabbathLoop.Domain.Commands.Members.Entities.DbConfig;
using SabbathLoop.Domain.Commands.Quarters.Entities;
using SabbathLoop.Domain.Commands.Quarters.Entities.DbConfig;
using SabbathLoop.Domain.Commands.Responses.Entities;
using SabbathLoop.Domain.Commands.Responses.Entities.DbConfig;
using SabbathLoop.Domain.Commands.UserAccessClasses.Entities;
using SabbathLoop.Domain.Commands.UserAccessClasses.Entities.DbConfig;
using SabbathLoop.Domain.Commands.Users.Entities;
using SabbathLoop.Domain.Commands.Users.Entities.DbConfig;

namespace SabbathLoop.Domain.Commands
{
    public class CommandDbContext : DbContext
    {
        public CommandDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Church> Churches { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Quarter> Quarters { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<UserAccessClass> UserAccessClasses { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.UseCollation("latin1_general_ci_ai").HasDefaultSchema("dbo");
            builder.ApplyConfiguration(new ChurchDbConfig());
            builder.ApplyConfiguration(new ClassDbConfig());
            builder.ApplyConfiguration(new CompanyDbConfig());
            builder.ApplyConfiguration(new MemberDbConfig());
            builder.ApplyConfiguration(new QuarterDbConfig());
            builder.ApplyConfiguration(new ResponseDbConfig());
            builder.ApplyConfiguration(new UserAccessClassDbConfig());
            builder.ApplyConfiguration(new UserDbConfig());
        }
    }
}