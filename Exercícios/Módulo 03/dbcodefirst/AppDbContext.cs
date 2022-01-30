using Microsoft.EntityFrameworkCore;

namespace dbcodefirst
{
    public class AppDbContext : DbContext
    {
        // Mapeamento da entidade para tabela
        public DbSet<Produto> produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=jvs-PC246;" +
            "Initial Catalog=EFCoreDB; Integrated Security=True; Trusted_Connection=false");
        }
    }
}