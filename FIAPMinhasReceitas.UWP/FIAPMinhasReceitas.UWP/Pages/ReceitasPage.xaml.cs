using FIAPMinhasReceitas.Models;
using FIAPMinhasReceitas.UWP.ViewModels;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FIAPMinhasReceitas.UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReceitasPage : Page
    {
        public ReceitasViewModel ViewModel { get; } = new ReceitasViewModel();

        public ReceitasPage()
        {
            this.InitializeComponent();
            this.Loaded += ReceitasPage_Loaded;
        }

        private void ReceitasPage_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.CarregarReceitasMock();
        }
    }
}
