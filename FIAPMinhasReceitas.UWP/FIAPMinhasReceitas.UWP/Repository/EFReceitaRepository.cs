using FIAPMinhasReceitas.Dados;
using FIAPMinhasReceitas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAPMinhasReceitas.UWP.Repository
{
    public class EFReceitaRepository : Repository<Receita>
    {
        private static readonly Lazy<EFReceitaRepository> _instance =
                new Lazy<EFReceitaRepository>(() => new EFReceitaRepository());

        public static EFReceitaRepository Instance { get { return _instance.Value; } }

        public override async Task CarregarTodosAsync()
        {
            if (Items.Count > 0)
            {
                return;
            }

            using (var context = new ReceitaDbContext())
            {
                var receitaItems = context.Receitas.ToList();

                foreach (var receita in receitaItems)
                {
                    Items.Add(receita);
                }
            }
        }

        public override async Task CriarAsync(Receita entity)
        {
            using (var context = new ReceitaDbContext())
            {
                Items.Add(entity);
                context.Receitas.Add(entity);

                await context.SaveChangesAsync();
            }
        }

        public override async Task AtualizarAsync(Receita entity)
        {
            using (var context = new ReceitaDbContext())
            {
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }

        public override async Task ExcluirAsync(Receita entity)
        {
            var receita = Items.SingleOrDefault(c => c.Id == entity.Id);

            if (receita != null)
            {
                using (var context = new ReceitaDbContext())
                {
                    Items.Remove(receita);

                    context.Receitas.Remove(receita);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
