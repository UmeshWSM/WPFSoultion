using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFDemoApp.Converters
{
    public class EligibilityConverter : IValueConverter
    {
        int _age;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            _age = (int)value;
            if (_age > 17)
            {
                return "Eligible";
            }
            return "Not Eligible";
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }
        

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    public class ForeColorConv : IValueConverter
    {
        string strColor;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            strColor = (string)value;
            if (strColor.ToUpper() =="WHITE")
            {
                return "Black";
            }
            return "WHITE";
        }
        

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
