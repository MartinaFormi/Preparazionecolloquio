using Microsoft.EntityFrameworkCore;

namespace Amazon.Models
{
    public class ProdottoContext : DbContext
    {
        public ProdottoContext(DbContextOptions<ProdottoContext> options)
            : base(options)
        {
        }

        public DbSet<Prodotto> Prodotti { get; set; }
    }
}
