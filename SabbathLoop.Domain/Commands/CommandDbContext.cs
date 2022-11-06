
using Microsoft.EntityFrameworkCore;

namespace SabbathLoop.Domain.Commands
{
    public class CommandDbContext : DbContext
    {
        public CommandDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}