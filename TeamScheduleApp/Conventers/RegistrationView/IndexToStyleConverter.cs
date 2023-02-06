using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace TeamScheduleApp.Conventers.RegistrationView
{
    /// <summary>
    /// Change elemnt style based on it`s index 
    /// </summary>
    public class IndexToStyleConverter : IValueConverter
    {
        /// <summary>
        /// If <param name="value"> are 0 we change style of element
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // create URI to ResourceDictionary
            ResourceDictionary resourceDictionary =
                Application.LoadComponent(new Uri("/TeamScheduleApp;component/Resources/StyleResources.xaml",
                    UriKind.Relative))as ResourceDictionary;

            // set style to TextBox depending on whether he is the first on the list
            return (int)value == 0 ?
                resourceDictionary["tbxFirtPinRegistrationView"] : resourceDictionary["tbxPinRegistrationView"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
