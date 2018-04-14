using FIAPMinhasReceitas.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace FIAPMinhasReceitas.UWP.UserControls
{
    public sealed partial class ReceitasListUserControl : UserControl
    {
        public ReceitasListUserControl()
        {
            this.InitializeComponent();
        }

        public Receita Receita
        {
            get { return (Receita)GetValue(ReceitaProperty); }
            set { SetValue(ReceitaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Receita.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ReceitaProperty =
            DependencyProperty.Register("Receita", typeof(Receita), typeof(ReceitasListUserControl), new PropertyMetadata(null));




    }
}
