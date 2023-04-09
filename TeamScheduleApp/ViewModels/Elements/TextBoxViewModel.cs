using System.Text.RegularExpressions;
using TeamScheduleApp.ViewModels.UserControls;

namespace TeamScheduleApp.ViewModels.Elements
{
    /// <summary>
    /// ViewModel for TextBoxes from RegistrationView.xaml
    /// </summary>
    public class TextBoxViewModel : BaseViewModel
    {
        private UserInitElementsViewModel ParentVM { get; set; }
        public TextBoxViewModel(UserInitElementsViewModel parentVM) => ParentVM = parentVM;

        public int Id { get; set; }
        public bool IsSelected { get; set; }

        private string _text;
        public string Text
        {
            get => _text;
            set
            {
                // only numbers from 0 to 9 and an empty value are allowed
                if (Regex.IsMatch(value, @"^[0-9]*$") || value == "")
                {
                    SetField(ref _text, value, "Text");

                    // check Continue Button status with new params
                    ParentVM.ContinueButtonProcessor.SetButtonStatus
                            (ParentVM.TextBoxes, ParentVM.PersonDataProcessor.FirstName, ParentVM.PersonDataProcessor.LastName);
                }
            }
        }
    }
}