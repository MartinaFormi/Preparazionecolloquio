using Microsoft.EntityFrameworkCore;

namespace Amazon.Models
{
    public class CommentoContext : DbContext
    {
        public CommentoContext(DbContextOptions<CommentoContext> options)
            : base(options)
        {
        }

        public DbSet<Commento> Commenti { get; set; }
    }
}


