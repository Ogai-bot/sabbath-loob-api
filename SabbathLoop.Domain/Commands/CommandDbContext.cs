using Microsoft.EntityFrameworkCore;

namespace SabbathLoop.Domain.Commands
{
    public class CommandDbContext : DbContext
    {
        protected CommandDbContext(DbContextOptions<CommandDbContext> options): base(options)
        {
        }
    }
}