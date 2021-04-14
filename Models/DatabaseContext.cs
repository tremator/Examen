using Microsoft.EntityFrameworkCore;


namespace Examen.Models
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }

        public DbSet<Event> Events { get; set; }

    }
}