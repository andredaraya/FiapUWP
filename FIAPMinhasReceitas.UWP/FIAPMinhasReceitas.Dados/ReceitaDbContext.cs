using FIAPMinhasReceitas.Models;
using Microsoft.EntityFrameworkCore;

namespace FIAPMinhasReceitas.Dados
{
    public class ReceitaDbContext : DbContext
    {
        public DbSet<Receita> Receitas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=receitas.db");
        }
    }
}
