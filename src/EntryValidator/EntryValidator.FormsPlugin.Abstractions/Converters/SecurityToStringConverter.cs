using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EntryValidator.FormsPlugin.Abstractions.Converters
{
    public class SecurityToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = value.ToString();
            string result;
            switch (val)
            {
                case "AlphaNumeric":
                    result = @"^[a-zA-Z][a-zA-Z0-9]*$";
                    break;
                case "IncludeSymbols":
                    result = @"^(?=.*[a-z])(?=.*\d)*$";
                    break;
                case "IncludeUpperCase":
                    result = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)*$";
                    break;
                default:
                    result = "";
                    break;
            }
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
