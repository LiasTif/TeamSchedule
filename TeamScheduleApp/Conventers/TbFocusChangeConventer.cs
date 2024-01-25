using System;
using System.Globalization;
using System.Windows.Data;
using TeamScheduleApp.ViewModels.Elements;
using TeamScheduleApp.ViewModels.UserControls;

namespace TeamScheduleApp.Conventers
{
    public class TbFocusChangeConventer : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var dataContext = (UserInitElementsViewModel)values[1];
            var textBox = values[2] as TextBoxViewModel;

            if (dataContext.TextBoxes.Count > 1 && dataContext.TextBoxes.Count > textBox.Id + 1)
                dataContext.FocusedTextBox = dataContext.TextBoxes[textBox.Id + 1];

            return values[0];
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            object[] obj = new object[1];
            obj[0] = value;
            return obj;
        }
    }
}