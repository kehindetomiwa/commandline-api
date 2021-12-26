using commandline_api.Models;
using Microsoft.EntityFrameworkCore;

namespace commandline_api.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }
        public DbSet<Command> Commands {get; set;}

    }
}