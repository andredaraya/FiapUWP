using FIAPMinhasReceitas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAPMinhasReceitas.UWP.Repository
{
    public class MockReceitaRepository : Repository<Receita>
    {
        private static readonly Lazy<MockReceitaRepository> _instance =
                new Lazy<MockReceitaRepository>(() => new MockReceitaRepository());

        public static MockReceitaRepository Instance { get { return _instance.Value; } }

        public override async Task CarregarTodosAsync()
        {
            if (Items.Count == 0)
            {
                var receitas = new List<Receita>()
            {
                new Receita
                {
                    Id = Guid.NewGuid(),
                    Categoria = Categoria.Bebida,
                    Instrucoes = "",
                    Titulo = "Limonada",
                    MinutosPreparo = 10,
                    Preco = 5.5M
                },
                new Receita
                {
                    Id = Guid.NewGuid(),
                    Categoria = Categoria.Doce,
                    Instrucoes = "",
                    Titulo = "Churros",
                    MinutosPreparo = 30,
                    Preco = 15
                }
            };

                receitas.ForEach(c => Items.Add(c));
            }
        }

        public override async Task CriarAsync(Receita entity)
        {
            entity.Id = Guid.NewGuid();
            Items.Add(entity);
        }

        public override async Task AtualizarAsync(Receita entity)
        {
            var receita = Items.SingleOrDefault(c => c.Id == entity.Id);

            if (receita != null)
            {
                receita.Categoria = entity.Categoria;
                receita.Instrucoes = entity.Instrucoes;
                receita.Titulo = entity.Titulo;
                receita.MinutosPreparo = entity.MinutosPreparo;
                receita.Preco = entity.Preco;
            }
        }

        public override async Task ExcluirAsync(Receita entity)
        {
            var receita = Items.SingleOrDefault(c => c.Id == entity.Id);

            if (receita != null)
            {
                Items.Remove(receita);
            }
        }
    }

}
