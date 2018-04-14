using FIAPMinhasReceitas.Models;
using FIAPMinhasReceitas.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAPMinhasReceitas.UWP.ViewModels
{
    public class ReceitasViewModel : NotifyableClass
    {
        public ReceitasViewModel()
        {
            this._receitas = new ObservableCollection<Receita>();
        }

        private ObservableCollection<Receita> _receitas;

        public ObservableCollection<Receita> Receitas
        {
            get { return _receitas; }
            set { Set(ref _receitas, value); }
        }

        public void CarregarReceitasMock()
        {
            _receitas.Add(new Receita
            {
                Categoria = Categoria.Bebida,
                Instrucoes = "",
                Titulo = "Limonada",
                MinutosPreparo = 10
            });

            _receitas.Add(new Receita
            {
                Categoria = Categoria.Doce,
                Instrucoes = "",
                Titulo = "Churros",
                MinutosPreparo = 30
            });
        }
    }
}
