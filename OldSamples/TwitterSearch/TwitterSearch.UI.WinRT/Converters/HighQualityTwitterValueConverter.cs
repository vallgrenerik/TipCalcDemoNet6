using System;
using System.Globalization;

namespace TwitterSearch.UI.WinRT.Converters
{
    public class HighQualityTwitterValueConverter
        : MvxValueConverter
    {
        public override object Convert(object value, Type type, object parmeter, CultureInfo cultureInfo)
        {
            return ((string)value).Replace("_normal", string.Empty);
        }
    }

    public class NativeHighQualityTwitterValueConverter : MvxNativeValueConverter<HighQualityTwitterValueConverter>
    { }
}