using FIAPMinhasReceitas.UWP.ViewModels;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FIAPMinhasReceitas.UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ConfiguracoesPage : Page
    {
        public ConfiguracoesViewModel ViewModel { get; } = new ConfiguracoesViewModel();

        public ConfiguracoesPage()
        {
            this.InitializeComponent();
        }
    }
}
