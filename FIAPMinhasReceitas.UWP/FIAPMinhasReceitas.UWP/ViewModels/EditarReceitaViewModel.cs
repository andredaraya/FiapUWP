using FIAPMinhasReceitas.Models;
using FIAPMinhasReceitas.Models.Abstracts;
using FIAPMinhasReceitas.UWP.Extensions;
using FIAPMinhasReceitas.UWP.Pages;
using FIAPMinhasReceitas.UWP.Repository;
using FIAPMinhasReceitas.UWP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Xaml.Controls;

namespace FIAPMinhasReceitas.UWP.ViewModels
{
    public class EditarReceitaViewModel : NotifyableClass
    {
        public EditarReceitaViewModel()
        {
            DataTransferManager.GetForCurrentView().DataRequested += EditarReceitaViewModel_DataRequested;
        }

        private MockReceitaRepository ReceitaRepository { get; set; } = MockReceitaRepository.Instance;

        private Receita _receita;

        public Receita Receita
        {
            get { return _receita; }
            set { Set(ref _receita, value); }
        }

        public bool RegistroExcluido { get; set; }

        public IEnumerable<Categoria> Categorias => Receita.Categoria.GetValores<Categoria>();

        public void CarregarReceita(Guid id)
        {
            Receita = ReceitaRepository.Items.FirstOrDefault(r => r.Id == id);
        
            if (Receita == null)
            {
                Receita = new Receita();
            }
        }        

        public async void ExcluirReceita()
        {
            await ReceitaRepository.ExcluirAsync(Receita);
            RegistroExcluido = true;
            NavigationService.GoBack();
        }

        private void EditarReceitaViewModel_DataRequested(DataTransferManager sender, DataRequestedEventArgs args)
        {
            DataRequest request = args.Request;

            StringBuilder text = new StringBuilder();
            text.AppendLine($"Instruções: {Receita.Instrucoes}");
            text.AppendLine($"Tempo de preparo: {Receita.MinutosPreparo} min");

            request.Data.SetText(text.ToString());
            request.Data.Properties.Title = $"App FIAPRecipes.UWP - {Receita.Titulo}";
        }

        public void CompartilharReceita()
        {
            DataTransferManager.ShowShareUI();
        }
    }
}
