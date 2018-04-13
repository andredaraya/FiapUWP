using FIAPMinhasReceitas.Models;
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
        public ReceitasPage()
        {
            this.InitializeComponent();
            this.Loaded += ReceitasPage_Loaded;
        }

        private void ReceitasPage_Loaded(object sender, RoutedEventArgs e)
        {
            List<Receita> receitas = CarregarReceitasMock();

            lstReceitas.ItemsSource = receitas;
        }

        private static List<Receita> CarregarReceitasMock()
        {
            List<Receita> receitas = new List<Receita>();

            receitas.AddRange(
                new Receita[]
                {
            new Receita
            {
                Categoria = Categoria.Bebida,
                Instrucoes = "",
                Titulo = "Limonada",
                MinutosPreparo = 10
            },
            new Receita
            {
                Categoria = Categoria.Doce,
                Instrucoes = "",
                Titulo = "Churros",
                MinutosPreparo = 30
            }
                }
            );
            return receitas;
        }

    }
}
