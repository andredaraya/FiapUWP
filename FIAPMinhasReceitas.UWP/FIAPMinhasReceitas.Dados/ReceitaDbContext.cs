using FIAPMinhasReceitas.Models;
using Microsoft.EntityFrameworkCore;
using System;

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
