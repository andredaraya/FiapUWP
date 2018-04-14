using FIAPMinhasReceitas.Models;
using FIAPMinhasReceitas.Models.Abstracts;
using FIAPMinhasReceitas.UWP.Pages;
using FIAPMinhasReceitas.UWP.Repository;
using FIAPMinhasReceitas.UWP.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace FIAPMinhasReceitas.UWP.ViewModels
{
    public class ReceitasViewModel : NotifyableClass
    {
        private MockReceitaRepository ReceitaRepository { get; set; } = MockReceitaRepository.Instance;

        public ObservableCollection<Receita> Receitas => ReceitaRepository.Items;

        public async Task Initialize()
        {
            await ReceitaRepository.CarregarTodosAsync();
        }

        public void ListaReceitas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listView = (ListView)sender;

            if (listView.SelectedItem == null || listView.SelectedItem as Receita == null)
            {
                return;
            }

            var receitaId = ((Receita)listView.SelectedItem).Id;

            NavigationService.Navigate<EditarReceitaPage>(receitaId);
        }

    }
}
