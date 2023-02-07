using System.Text.RegularExpressions;

namespace TeamScheduleApp.ViewModels.Elements
{
    /// <summary>
    /// ViewModel for TextBoxes from RegistrationView.xaml
    /// </summary>
    public class RegistrationTextBoxViewModel : BaseViewModel
    {
        public int Id { get; set; }

        private string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                if (Regex.IsMatch(value, @"^[0-9]*$") || value == "")
                {
                    _text = value;
                    OnPropertyChanged("Text");
                }
            }
        }
    }
}