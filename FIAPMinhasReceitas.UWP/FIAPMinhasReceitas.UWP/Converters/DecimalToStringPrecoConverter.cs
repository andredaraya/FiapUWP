using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace FIAPMinhasReceitas.UWP.Converters
{
    public class DecimalToStringPrecoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            decimal.TryParse(System.Convert.ToString(value), out decimal valor);

            if (valor == 0)
                return string.Empty;
            else if (valor < 10)
                return "Barato";
            else if (valor < 20)
                return "Médio";
            else
                return "Caro";

        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
