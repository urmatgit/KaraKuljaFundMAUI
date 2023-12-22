using KaraKuljaFund.Navigator.Models.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.MAUI.Converters
{
    public class MonthNumberToStringNameConverter : IValueConverter
    {
        string[] monthStr = { "Январь", "Февраль", "Марь", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        public object Convert(object value, Type targetType, object? parameter, CultureInfo culture)
        {

            int? month =value!=null? ((int)(Months)value) :null ;
            if (month.HasValue) { return monthStr[month.Value-1];}
            return "";
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            string monthname=value as string;
            if (string.IsNullOrEmpty(monthname) || !monthStr.Any(m=>m== monthname)) { return null; };
            return monthname.IndexOf(monthname)+1;
            
        }
    }
}
