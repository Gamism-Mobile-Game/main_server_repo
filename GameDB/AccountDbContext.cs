using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GameDB
{
    public class AccountDbContext : DbContext
    {
        public DbSet<AccountDb> Accounts { get; set; }

        static readonly ILoggerFactory _logger = LoggerFactory.Create(builder => { builder.AddConsole(); });
        
        public AccountDbContext(DbContextOptions<AccountDbContext> options)
            :base(options)
        {
            
        }
    }
}

