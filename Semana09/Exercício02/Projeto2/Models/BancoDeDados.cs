using Microsoft.EntityFrameworkCore;

namespace Projeto2.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\msqllocaldb; Database = CrudTeste; Integrated Security=True");
        }
    }
}
