using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GameDB
{
    public class GameDbContext : DbContext
    {
        public DbSet<TestDb> Tests { get; set; }

        static readonly ILoggerFactory _logger = LoggerFactory.Create(builder => { builder.AddConsole(); });
        
        public GameDbContext(DbContextOptions<GameDbContext> options)
            :base(options)
        {
            
        }
    }
}

